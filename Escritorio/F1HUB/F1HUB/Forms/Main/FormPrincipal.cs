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
    public partial class FormPrincipal : Form
    {
        private static readonly Color BorderColor = Color.FromArgb(46, 46, 46);
        private static readonly Color TextMuted = Color.FromArgb(135, 135, 135);

        private readonly ApiClient _apiClient;
        private readonly Usuario _usuario;

        public FormPrincipal(ApiClient apiClient, Usuario usuario)
        {
            _apiClient = apiClient;
            _usuario = usuario;

            InitializeComponent();
            AplicarDatosUsuario();
            WireEvents();
        }

        private void WireEvents()
        {
            _btnPublicar.Click += async (sender, e) => await PublicarAsync();
            _btnPerfil.Click += BtnPerfil_Click;
            _btnCerrarSesion.Click += (sender, e) => Close();
            _txtNuevaPublicacion.TextChanged += (sender, e) =>
            {
                _lblPlaceholderPublicacion.Visible = string.IsNullOrWhiteSpace(_txtNuevaPublicacion.Text);
            };
            Resize += (sender, e) => AjustarAnchuras();
            Load += async (sender, e) => await RecargarDatosAsync();
            _topBar.Resize += (sender, e) => ReposicionarTopBar();
        }

        private void AplicarDatosUsuario()
        {
            Text = "F1HUB - @" + _usuario.NombreUsuario;
            _lblTopUsuario.Text = "@" + _usuario.NombreUsuario;
            _lblSidebarNombre.Text = _usuario.NombreUsuario;
            _lblSidebarTag.Text = "@" + _usuario.NombreUsuario;

            var initial = string.IsNullOrWhiteSpace(_usuario.NombreUsuario)
                ? "U"
                : _usuario.NombreUsuario.Substring(0, 1).ToUpperInvariant();

            _lblTopAvatar.Text = initial;
            _lblSidebarAvatar.Text = initial;
            _lblComposerAvatar.Text = initial;

            ReposicionarTopBar();
        }

        private void ReposicionarTopBar()
        {
            _lblTopUsuario.Location = new Point(_topBar.Width - _lblTopUsuario.Width - 18, 15);
            _lblTopAvatar.Location = new Point(_lblTopUsuario.Left - 38, 10);
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            using (var perfil = new FormPerfil(_apiClient, _usuario))
            {
                Hide();
                perfil.ShowDialog(this);
                Show();
            }
        }

        private async Task PublicarAsync()
        {
            var texto = (_txtNuevaPublicacion.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Escribe algo para publicar.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ToggleUi(false);
            try
            {
                var ok = await _apiClient.SubirPublicacionAsync(_usuario.IdUsuario, texto);
                if (!ok)
                {
                    MessageBox.Show("No se pudo publicar.", "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _txtNuevaPublicacion.Text = string.Empty;
                await RecargarDatosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al publicar.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var todas = await _apiClient.ObtenerTodasPublicacionesAsync();
                CargarPublicaciones(todas);
                AjustarAnchuras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las publicaciones.\n" + ex.Message, "F1HUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUi(true);
            }
        }

        private void CargarPublicaciones(IEnumerable<Publicacion> publicaciones)
        {
            _feedContainer.SuspendLayout();
            _feedContainer.Controls.Clear();

            var ordered = publicaciones.OrderByDescending(p => p.FechaPublicacion).ToList();
            if (ordered.Count == 0)
            {
                _feedContainer.Controls.Add(new Label
                {
                    Text = "No hay publicaciones todavia.",
                    AutoSize = true,
                    ForeColor = TextMuted,
                    Margin = new Padding(18, 18, 0, 0)
                });
                _feedContainer.ResumeLayout();
                return;
            }

            foreach (var publicacion in ordered)
            {
                _feedContainer.Controls.Add(CrearTarjetaPublicacion(publicacion));
            }

            _feedContainer.ResumeLayout();
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
                Width = Math.Max(400, _centerColumn.ClientSize.Width - 2),
                Height = 88,
                BackColor = Color.FromArgb(18, 10, 12),
                Margin = new Padding(0),
                Padding = new Padding(18, 14, 18, 12)
            };

            var user = new Label
            {
                Text = "@" + (publicacion.NombreUsuario ?? string.Empty),
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point),
                Location = new Point(18, 14)
            };

            var text = new Label
            {
                Text = publicacion.Texto ?? string.Empty,
                AutoSize = true,
                MaximumSize = new Size(card.Width - 36, 0),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(18, 34)
            };

            var date = new Label
            {
                Text = fecha,
                AutoSize = true,
                ForeColor = TextMuted,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(18, 62)
            };

            card.Controls.Add(user);
            card.Controls.Add(text);
            card.Controls.Add(date);
            card.Controls.Add(CreateLineDock(DockStyle.Bottom));
            return card;
        }

        private void AjustarAnchuras()
        {
            foreach (Control control in _feedContainer.Controls)
            {
                var panel = control as Panel;
                if (panel != null)
                {
                    panel.Width = Math.Max(400, _centerColumn.ClientSize.Width - 2);
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
