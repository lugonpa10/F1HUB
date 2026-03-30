using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using F1HUB.Models;
using F1HUB.Services;

namespace F1HUB
{
    public partial class FormRegistro : Form
    {
        private readonly ApiClient _apiClient;

        public FormRegistro(ApiClient apiClient)
        {
            _apiClient = apiClient;
            InitializeComponent();
            _cmbGenero.SelectedIndex = 3;
            _btnCrear.Click += async (s, e) => await RegistrarAsync();
            ConfigurarPlaceholder(_txtFecha, "yyyy-MM-dd");
        }

        private static void ConfigurarPlaceholder(TextBox textBox, string placeholder)
        {
            if (!string.IsNullOrWhiteSpace(placeholder))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                textBox.GotFocus += (s, e) =>
                {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = string.Empty;
                        textBox.ForeColor = Color.Black;
                    }
                };
                textBox.LostFocus += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                    }
                };
            }
        }

        private async Task RegistrarAsync()
        {
            var nombre = Normalizar(_txtNombre.Text);
            var apellidos = Normalizar(_txtApellidos.Text);
            var nombreUsuario = Normalizar(_txtNombreUsuario.Text);
            var email = Normalizar(_txtEmail.Text);
            var fecha = Normalizar(_txtFecha.Text, "yyyy-MM-dd");
            var password = _txtPassword.Text ?? string.Empty;
            var confirmPassword = _txtConfirmPassword.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(fecha) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El email no tiene un formato valido.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(fecha, out _))
            {
                MessageBox.Show("La fecha debe tener formato yyyy-MM-dd.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleUi(false);
            try
            {
                var ok = await _apiClient.RegistrarUsuarioAsync(new Usuario
                {
                    Nombre = nombre,
                    Apellidos = apellidos,
                    NombreUsuario = nombreUsuario,
                    Email = email,
                    FechaNacimiento = fecha,
                    Genero = _cmbGenero.SelectedItem?.ToString() ?? "No especificado",
                    PasswordHash = password
                });

                if (!ok)
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Usuario registrado correctamente.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de registro.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private void ToggleUi(bool enabled)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = enabled;
            }
            Cursor = enabled ? Cursors.Default : Cursors.WaitCursor;
        }

        private static string Normalizar(string value, string placeholder = "")
        {
            var text = (value ?? string.Empty).Trim();
            if (!string.IsNullOrWhiteSpace(placeholder) && text == placeholder)
            {
                return string.Empty;
            }
            return text;
        }
    }
}
