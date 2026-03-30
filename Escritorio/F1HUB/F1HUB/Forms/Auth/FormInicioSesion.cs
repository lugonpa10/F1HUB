using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using F1HUB.Models;
using F1HUB.Services;
using MetroSet_UI.Forms;

namespace F1HUB
{
    public partial class FormInicioSesion : MetroSetForm
    {
        private readonly ApiClient _apiClient = new ApiClient();

        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            await IniciarSesionAsync();
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var registro = new FormRegistro(_apiClient))
            {
                registro.ShowDialog(this);
            }
        }

        private async Task IniciarSesionAsync()
        {
            var nombreUsuario = (txtUsuario.Text ?? string.Empty).Trim();
            var password = (txtPassword.Text ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Usuario y contraseña son obligatorios.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleUi(false);
            try
            {
                var usuario = await _apiClient.IniciarSesionAsync(nombreUsuario, password);
                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Hide();
                using (var principal = new FormPrincipal(_apiClient, usuario))
                {
                    principal.ShowDialog(this);
                }
                Show();
                txtPassword.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private void ToggleUi(bool enabled)
        {
            txtUsuario.Enabled = enabled;
            txtPassword.Enabled = enabled;
            btnIniciarSesion.Enabled = enabled;
            lnkRegistro.Enabled = enabled;
            Cursor = enabled ? Cursors.Default : Cursors.WaitCursor;
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
