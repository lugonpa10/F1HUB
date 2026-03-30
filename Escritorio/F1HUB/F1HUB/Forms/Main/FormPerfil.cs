using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using F1HUB.Models;
using F1HUB.Services;

namespace F1HUB
{
    public partial class FormPerfil : Form
    {
        private static readonly Color PanelBlack = Color.FromArgb(20, 20, 20);
        private static readonly Color BorderColor = Color.FromArgb(46, 46, 46);
        private static readonly Color TextMuted = Color.FromArgb(135, 135, 135);

        private readonly ApiClient _apiClient;
        private readonly Usuario _usuario;

        public FormPerfil(ApiClient apiClient, Usuario usuario)
        {
            _apiClient = apiClient;
            _usuario = usuario;

            InitializeComponent();
            AplicarDatosUsuario();
            WireEvents();
        }

        private void WireEvents()
        {
            _btnGuardar.Click += async (sender, e) => await GuardarPerfilAsync();
            _btnMuro.Click += (sender, e) => DialogResult = DialogResult.OK;
            _btnCerrarSesion.Click += (sender, e) => Close();
            Resize += (sender, e) => AjustarAnchuras();
            Load += async (sender, e) => await RecargarDatosAsync();
            _topBar.Resize += (sender, e) => ReposicionarTopBar();
        }

        private void AplicarDatosUsuario()
        {
            Text = "F1HUB - Perfil @" + _usuario.NombreUsuario;
            _lblTopUsuario.Text = "@" + _usuario.NombreUsuario;
            _lblSidebarNombre.Text = _usuario.NombreUsuario;
            _lblSidebarTag.Text = "@" + _usuario.NombreUsuario;
            _lblProfileTag.Text = "@" + _usuario.NombreUsuario;

            var fullName = ((_usuario.Nombre ?? string.Empty) + " " + (_usuario.Apellidos ?? string.Empty)).Trim();
            _lblProfileNombre.Text = string.IsNullOrWhiteSpace(fullName) ? _usuario.NombreUsuario : fullName;

            var initial = string.IsNullOrWhiteSpace(_usuario.NombreUsuario)
                ? "U"
                : _usuario.NombreUsuario.Substring(0, 1).ToUpperInvariant();

            _lblTopAvatar.Text = initial;
            _lblSidebarAvatar.Text = initial;
            _lblProfileAvatar.Text = initial;

            _txtNombre.Text = _usuario.Nombre ?? string.Empty;
            _txtApellidos.Text = _usuario.Apellidos ?? string.Empty;
            _txtEmail.Text = _usuario.Email ?? string.Empty;

            DateTime fecha;
            if (DateTime.TryParse(_usuario.FechaNacimiento, out fecha))
            {
                _dtpFechaNacimiento.Value = fecha;
            }

            _cmbGenero.SelectedItem = _cmbGenero.Items.Cast<object>().FirstOrDefault(i => i.ToString() == _usuario.Genero) ?? "No especificado";
            ReposicionarTopBar();
        }

        private void ReposicionarTopBar()
        {
            _lblTopUsuario.Location = new Point(_topBar.Width - _lblTopUsuario.Width - 18, 15);
            _lblTopAvatar.Location = new Point(_lblTopUsuario.Left - 38, 10);
        }

        private async Task GuardarPerfilAsync()
        {
            _usuario.Nombre = (_txtNombre.Text ?? string.Empty).Trim();
            _usuario.Apellidos = (_txtApellidos.Text ?? string.Empty).Trim();
            _usuario.Email = (_txtEmail.Text ?? string.Empty).Trim();
            _usuario.FechaNacimiento = _dtpFechaNacimiento.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            _usuario.Genero = _cmbGenero.SelectedItem == null ? "No especificado" : _cmbGenero.SelectedItem.ToString();

            ToggleUi(false);
            try
            {
                var ok = await _apiClient.EditarUsuarioAsync(_usuario);
                MessageBox.Show(ok ? "Perfil actualizado." : "No se pudo actualizar.", "F1HUB", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                var fullName = ((_usuario.Nombre ?? string.Empty) + " " + (_usuario.Apellidos ?? string.Empty)).Trim();
                _lblProfileNombre.Text = string.IsNullOrWhiteSpace(fullName) ? _usuario.NombreUsuario : fullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar perfil.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private async Task EliminarPublicacionAsync(int idPublicacion)
        {
            ToggleUi(false);
            try
            {
                var ok = await _apiClient.EliminarPublicacionAsync(idPublicacion);
                if (!ok)
                {
                    MessageBox.Show("No se pudo eliminar.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await RecargarDatosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private async Task RecargarDatosAsync()
        {
            ToggleUi(false);
            try
            {
                var publicaciones = await _apiClient.ObtenerPublicacionesUsuarioAsync(_usuario.IdUsuario, _usuario.NombreUsuario);
                CargarPublicaciones(publicaciones);
                AjustarAnchuras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos del perfil.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private void CargarPublicaciones(IEnumerable<Publicacion> publicaciones)
        {
            _postsContainer.SuspendLayout();
            _postsContainer.Controls.Clear();

            var ordered = publicaciones.OrderByDescending(p => p.FechaPublicacion).ToList();
            if (ordered.Count == 0)
            {
                _postsContainer.Controls.Add(new Label
                {
                    Text = "Todavia no tienes publicaciones.",
                    AutoSize = true,
                    ForeColor = TextMuted,
                    Margin = new Padding(20, 20, 0, 0)
                });
                _postsContainer.ResumeLayout();
                return;
            }

            foreach (var publicacion in ordered)
            {
                _postsContainer.Controls.Add(CrearTarjetaPublicacion(publicacion));
            }

            _postsContainer.ResumeLayout();
        }

        private Panel CrearTarjetaPublicacion(Publicacion publicacion)
        {
            var fecha = publicacion.FechaPublicacion > 0
                ? DateTimeOffset.FromUnixTimeMilliseconds(publicacion.FechaPublicacion)
                    .ToLocalTime()
                    .ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)
                : string.Empty;

            var card = new Panel
            {
                Width = Math.Max(500, _contentColumn.ClientSize.Width - 2),
                Height = 74,
                BackColor = PanelBlack,
                Margin = new Padding(0),
                Padding = new Padding(20, 12, 20, 10)
            };

            var text = new Label
            {
                Text = publicacion.Texto ?? string.Empty,
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(20, 10)
            };

            var deleteButton = new Button
            {
                Text = "x",
                Size = new Size(24, 24),
                FlatStyle = FlatStyle.Flat,
                ForeColor = TextMuted,
                BackColor = PanelBlack,
                Location = new Point(card.Width - 52, 8),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Click += async (sender, e) => await EliminarPublicacionAsync(publicacion.IdPubli);

            var date = new Label
            {
                Text = fecha,
                AutoSize = true,
                ForeColor = TextMuted,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(20, 40)
            };

            card.Controls.Add(text);
            card.Controls.Add(deleteButton);
            card.Controls.Add(date);
            card.Controls.Add(CreateLineDock(DockStyle.Bottom));
            return card;
        }

        private void AjustarAnchuras()
        {
            foreach (Control control in _postsContainer.Controls)
            {
                var panel = control as Panel;
                if (panel != null)
                {
                    panel.Width = Math.Max(500, _contentColumn.ClientSize.Width - 2);
                }
            }
        }

        private void ToggleUi(bool enabled)
        {
            _layoutRoot.Enabled = enabled;
            _topBar.Enabled = enabled;
            Cursor = enabled ? Cursors.Default : Cursors.WaitCursor;
        }

        private static Panel CreateLineDock(DockStyle dock)
        {
            return new Panel
            {
                Dock = dock,
                BackColor = BorderColor,
                Height = dock == DockStyle.Bottom || dock == DockStyle.Top ? 1 : 0,
                Width = dock == DockStyle.Left || dock == DockStyle.Right ? 1 : 0
            };
        }
    }
}
