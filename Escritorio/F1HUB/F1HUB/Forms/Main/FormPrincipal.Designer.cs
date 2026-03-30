namespace F1HUB
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this._topBar = new System.Windows.Forms.Panel();
            this._lblTopUsuario = new System.Windows.Forms.Label();
            this._lblTopAvatar = new System.Windows.Forms.Label();
            this._lblLogo = new System.Windows.Forms.Label();
            this._layoutRoot = new System.Windows.Forms.Panel();
            this._centerColumn = new System.Windows.Forms.Panel();
            this._feedContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._composerPanel = new System.Windows.Forms.Panel();
            this._buttonHost = new System.Windows.Forms.Panel();
            this._btnPublicar = new System.Windows.Forms.Button();
            this._dividerComposer = new System.Windows.Forms.Panel();
            this._editorHost = new System.Windows.Forms.Panel();
            this._txtNuevaPublicacion = new System.Windows.Forms.RichTextBox();
            this._lblPlaceholderPublicacion = new System.Windows.Forms.Label();
            this._lblComposerAvatar = new System.Windows.Forms.Label();
            this._headerPanel = new System.Windows.Forms.Panel();
            this._lblMuro = new System.Windows.Forms.Label();
            this._rightColumn = new System.Windows.Forms.Panel();
            this._racesCard = new System.Windows.Forms.Panel();
            this._raceDivider3 = new System.Windows.Forms.Panel();
            this._lblRaceDate3 = new System.Windows.Forms.Label();
            this._lblRaceName3 = new System.Windows.Forms.Label();
            this._lblRaceCode3 = new System.Windows.Forms.Label();
            this._raceDivider2 = new System.Windows.Forms.Panel();
            this._lblRaceDate2 = new System.Windows.Forms.Label();
            this._lblRaceName2 = new System.Windows.Forms.Label();
            this._lblRaceCode2 = new System.Windows.Forms.Label();
            this._raceDivider1 = new System.Windows.Forms.Panel();
            this._lblRaceDate1 = new System.Windows.Forms.Label();
            this._lblRaceName1 = new System.Windows.Forms.Label();
            this._lblRaceCode1 = new System.Windows.Forms.Label();
            this._raceHeaderAccent = new System.Windows.Forms.Panel();
            this._lblRacesTitle = new System.Windows.Forms.Label();
            this._leftColumn = new System.Windows.Forms.Panel();
            this._btnCerrarSesion = new System.Windows.Forms.Button();
            this._btnPerfil = new System.Windows.Forms.Button();
            this._btnMuro = new System.Windows.Forms.Button();
            this._navAccent = new System.Windows.Forms.Panel();
            this._lblNav = new System.Windows.Forms.Label();
            this._sidebarCard = new System.Windows.Forms.Panel();
            this._lblSidebarTag = new System.Windows.Forms.Label();
            this._lblSidebarNombre = new System.Windows.Forms.Label();
            this._lblSidebarAvatar = new System.Windows.Forms.Label();
            this._topBar.SuspendLayout();
            this._layoutRoot.SuspendLayout();
            this._centerColumn.SuspendLayout();
            this._composerPanel.SuspendLayout();
            this._buttonHost.SuspendLayout();
            this._editorHost.SuspendLayout();
            this._headerPanel.SuspendLayout();
            this._rightColumn.SuspendLayout();
            this._racesCard.SuspendLayout();
            this._leftColumn.SuspendLayout();
            this._sidebarCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // _topBar
            // 
            this._topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this._topBar.Controls.Add(this._lblTopUsuario);
            this._topBar.Controls.Add(this._lblTopAvatar);
            this._topBar.Controls.Add(this._lblLogo);
            this._topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._topBar.Location = new System.Drawing.Point(0, 0);
            this._topBar.Name = "_topBar";
            this._topBar.Size = new System.Drawing.Size(1166, 43);
            this._topBar.TabIndex = 0;
            // 
            // _lblTopUsuario
            // 
            this._lblTopUsuario.AutoSize = true;
            this._lblTopUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this._lblTopUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblTopUsuario.Location = new System.Drawing.Point(1114, 13);
            this._lblTopUsuario.Name = "_lblTopUsuario";
            this._lblTopUsuario.Size = new System.Drawing.Size(48, 19);
            this._lblTopUsuario.TabIndex = 2;
            this._lblTopUsuario.Text = "@user";
            // 
            // _lblTopAvatar
            // 
            this._lblTopAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._lblTopAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this._lblTopAvatar.ForeColor = System.Drawing.Color.White;
            this._lblTopAvatar.Location = new System.Drawing.Point(1080, 9);
            this._lblTopAvatar.Name = "_lblTopAvatar";
            this._lblTopAvatar.Size = new System.Drawing.Size(26, 26);
            this._lblTopAvatar.TabIndex = 1;
            this._lblTopAvatar.Text = "U";
            this._lblTopAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblLogo
            // 
            this._lblLogo.AutoSize = true;
            this._lblLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this._lblLogo.ForeColor = System.Drawing.Color.White;
            this._lblLogo.Location = new System.Drawing.Point(21, 9);
            this._lblLogo.Name = "_lblLogo";
            this._lblLogo.Size = new System.Drawing.Size(86, 32);
            this._lblLogo.TabIndex = 0;
            this._lblLogo.Text = "F1HUB";
            // 
            // _layoutRoot
            // 
            this._layoutRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this._layoutRoot.Controls.Add(this._centerColumn);
            this._layoutRoot.Controls.Add(this._rightColumn);
            this._layoutRoot.Controls.Add(this._leftColumn);
            this._layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this._layoutRoot.Location = new System.Drawing.Point(0, 43);
            this._layoutRoot.Name = "_layoutRoot";
            this._layoutRoot.Size = new System.Drawing.Size(1166, 616);
            this._layoutRoot.TabIndex = 1;
            // 
            // _centerColumn
            // 
            this._centerColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this._centerColumn.Controls.Add(this._feedContainer);
            this._centerColumn.Controls.Add(this._composerPanel);
            this._centerColumn.Controls.Add(this._headerPanel);
            this._centerColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._centerColumn.Location = new System.Drawing.Point(360, 0);
            this._centerColumn.Name = "_centerColumn";
            this._centerColumn.Size = new System.Drawing.Size(497, 616);
            this._centerColumn.TabIndex = 2;
            // 
            // _feedContainer
            // 
            this._feedContainer.AutoScroll = true;
            this._feedContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this._feedContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._feedContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._feedContainer.Location = new System.Drawing.Point(0, 163);
            this._feedContainer.Name = "_feedContainer";
            this._feedContainer.Size = new System.Drawing.Size(497, 453);
            this._feedContainer.TabIndex = 2;
            this._feedContainer.WrapContents = false;
            // 
            // _composerPanel
            // 
            this._composerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._composerPanel.Controls.Add(this._buttonHost);
            this._composerPanel.Controls.Add(this._dividerComposer);
            this._composerPanel.Controls.Add(this._editorHost);
            this._composerPanel.Controls.Add(this._lblComposerAvatar);
            this._composerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._composerPanel.Location = new System.Drawing.Point(0, 43);
            this._composerPanel.Name = "_composerPanel";
            this._composerPanel.Size = new System.Drawing.Size(497, 120);
            this._composerPanel.TabIndex = 1;
            // 
            // _buttonHost
            // 
            this._buttonHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._buttonHost.Controls.Add(this._btnPublicar);
            this._buttonHost.Location = new System.Drawing.Point(57, 80);
            this._buttonHost.Name = "_buttonHost";
            this._buttonHost.Size = new System.Drawing.Size(463, 29);
            this._buttonHost.TabIndex = 3;
            // 
            // _btnPublicar
            // 
            this._btnPublicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._btnPublicar.FlatAppearance.BorderSize = 0;
            this._btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPublicar.ForeColor = System.Drawing.Color.White;
            this._btnPublicar.Location = new System.Drawing.Point(0, 2);
            this._btnPublicar.Name = "_btnPublicar";
            this._btnPublicar.Size = new System.Drawing.Size(86, 24);
            this._btnPublicar.TabIndex = 0;
            this._btnPublicar.Text = "PUBLICAR";
            this._btnPublicar.UseVisualStyleBackColor = false;
            // 
            // _dividerComposer
            // 
            this._dividerComposer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this._dividerComposer.Location = new System.Drawing.Point(57, 73);
            this._dividerComposer.Name = "_dividerComposer";
            this._dividerComposer.Size = new System.Drawing.Size(463, 1);
            this._dividerComposer.TabIndex = 2;
            // 
            // _editorHost
            // 
            this._editorHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._editorHost.Controls.Add(this._txtNuevaPublicacion);
            this._editorHost.Controls.Add(this._lblPlaceholderPublicacion);
            this._editorHost.Location = new System.Drawing.Point(57, 14);
            this._editorHost.Name = "_editorHost";
            this._editorHost.Size = new System.Drawing.Size(463, 47);
            this._editorHost.TabIndex = 1;
            // 
            // _txtNuevaPublicacion
            // 
            this._txtNuevaPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._txtNuevaPublicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtNuevaPublicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtNuevaPublicacion.ForeColor = System.Drawing.Color.White;
            this._txtNuevaPublicacion.Location = new System.Drawing.Point(0, 0);
            this._txtNuevaPublicacion.Name = "_txtNuevaPublicacion";
            this._txtNuevaPublicacion.Size = new System.Drawing.Size(463, 47);
            this._txtNuevaPublicacion.TabIndex = 0;
            this._txtNuevaPublicacion.Text = "";
            // 
            // _lblPlaceholderPublicacion
            // 
            this._lblPlaceholderPublicacion.AutoSize = true;
            this._lblPlaceholderPublicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._lblPlaceholderPublicacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this._lblPlaceholderPublicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblPlaceholderPublicacion.Location = new System.Drawing.Point(0, 3);
            this._lblPlaceholderPublicacion.Name = "_lblPlaceholderPublicacion";
            this._lblPlaceholderPublicacion.Size = new System.Drawing.Size(233, 20);
            this._lblPlaceholderPublicacion.TabIndex = 1;
            this._lblPlaceholderPublicacion.Text = "Que esta pasando en el paddock?";
            // 
            // _lblComposerAvatar
            // 
            this._lblComposerAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._lblComposerAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this._lblComposerAvatar.ForeColor = System.Drawing.Color.White;
            this._lblComposerAvatar.Location = new System.Drawing.Point(15, 16);
            this._lblComposerAvatar.Name = "_lblComposerAvatar";
            this._lblComposerAvatar.Size = new System.Drawing.Size(27, 28);
            this._lblComposerAvatar.TabIndex = 0;
            this._lblComposerAvatar.Text = "U";
            this._lblComposerAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _headerPanel
            // 
            this._headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this._headerPanel.Controls.Add(this._lblMuro);
            this._headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._headerPanel.Location = new System.Drawing.Point(0, 0);
            this._headerPanel.Name = "_headerPanel";
            this._headerPanel.Size = new System.Drawing.Size(497, 43);
            this._headerPanel.TabIndex = 0;
            // 
            // _lblMuro
            // 
            this._lblMuro.AutoSize = true;
            this._lblMuro.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this._lblMuro.ForeColor = System.Drawing.Color.White;
            this._lblMuro.Location = new System.Drawing.Point(17, 10);
            this._lblMuro.Name = "_lblMuro";
            this._lblMuro.Size = new System.Drawing.Size(79, 30);
            this._lblMuro.TabIndex = 0;
            this._lblMuro.Text = "MURO";
            // 
            // _rightColumn
            // 
            this._rightColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this._rightColumn.Controls.Add(this._racesCard);
            this._rightColumn.Dock = System.Windows.Forms.DockStyle.Right;
            this._rightColumn.Location = new System.Drawing.Point(857, 0);
            this._rightColumn.Name = "_rightColumn";
            this._rightColumn.Size = new System.Drawing.Size(309, 616);
            this._rightColumn.TabIndex = 1;
            // 
            // _racesCard
            // 
            this._racesCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this._racesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._racesCard.Controls.Add(this._raceDivider3);
            this._racesCard.Controls.Add(this._lblRaceDate3);
            this._racesCard.Controls.Add(this._lblRaceName3);
            this._racesCard.Controls.Add(this._lblRaceCode3);
            this._racesCard.Controls.Add(this._raceDivider2);
            this._racesCard.Controls.Add(this._lblRaceDate2);
            this._racesCard.Controls.Add(this._lblRaceName2);
            this._racesCard.Controls.Add(this._lblRaceCode2);
            this._racesCard.Controls.Add(this._raceDivider1);
            this._racesCard.Controls.Add(this._lblRaceDate1);
            this._racesCard.Controls.Add(this._lblRaceName1);
            this._racesCard.Controls.Add(this._lblRaceCode1);
            this._racesCard.Controls.Add(this._raceHeaderAccent);
            this._racesCard.Controls.Add(this._lblRacesTitle);
            this._racesCard.Location = new System.Drawing.Point(15, 0);
            this._racesCard.Name = "_racesCard";
            this._racesCard.Size = new System.Drawing.Size(206, 252);
            this._racesCard.TabIndex = 0;
            // 
            // _raceDivider3
            // 
            this._raceDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this._raceDivider3.Location = new System.Drawing.Point(14, 149);
            this._raceDivider3.Name = "_raceDivider3";
            this._raceDivider3.Size = new System.Drawing.Size(163, 1);
            this._raceDivider3.TabIndex = 0;
            // 
            // _lblRaceDate3
            // 
            this._lblRaceDate3.AutoSize = true;
            this._lblRaceDate3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblRaceDate3.Location = new System.Drawing.Point(34, 132);
            this._lblRaceDate3.Name = "_lblRaceDate3";
            this._lblRaceDate3.Size = new System.Drawing.Size(67, 13);
            this._lblRaceDate3.TabIndex = 1;
            this._lblRaceDate3.Text = "29 Mar 2026";
            // 
            // _lblRaceName3
            // 
            this._lblRaceName3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this._lblRaceName3.ForeColor = System.Drawing.Color.White;
            this._lblRaceName3.Location = new System.Drawing.Point(34, 116);
            this._lblRaceName3.Name = "_lblRaceName3";
            this._lblRaceName3.Size = new System.Drawing.Size(146, 17);
            this._lblRaceName3.TabIndex = 2;
            this._lblRaceName3.Text = "Gran Premio de Japon";
            // 
            // _lblRaceCode3
            // 
            this._lblRaceCode3.AutoSize = true;
            this._lblRaceCode3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._lblRaceCode3.Location = new System.Drawing.Point(14, 120);
            this._lblRaceCode3.Name = "_lblRaceCode3";
            this._lblRaceCode3.Size = new System.Drawing.Size(19, 13);
            this._lblRaceCode3.TabIndex = 3;
            this._lblRaceCode3.Text = "JP";
            // 
            // _raceDivider2
            // 
            this._raceDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this._raceDivider2.Location = new System.Drawing.Point(14, 111);
            this._raceDivider2.Name = "_raceDivider2";
            this._raceDivider2.Size = new System.Drawing.Size(163, 1);
            this._raceDivider2.TabIndex = 4;
            // 
            // _lblRaceDate2
            // 
            this._lblRaceDate2.AutoSize = true;
            this._lblRaceDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblRaceDate2.Location = new System.Drawing.Point(34, 94);
            this._lblRaceDate2.Name = "_lblRaceDate2";
            this._lblRaceDate2.Size = new System.Drawing.Size(67, 13);
            this._lblRaceDate2.TabIndex = 5;
            this._lblRaceDate2.Text = "15 Mar 2026";
            // 
            // _lblRaceName2
            // 
            this._lblRaceName2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this._lblRaceName2.ForeColor = System.Drawing.Color.White;
            this._lblRaceName2.Location = new System.Drawing.Point(34, 78);
            this._lblRaceName2.Name = "_lblRaceName2";
            this._lblRaceName2.Size = new System.Drawing.Size(146, 17);
            this._lblRaceName2.TabIndex = 6;
            this._lblRaceName2.Text = "Gran Premio de China";
            // 
            // _lblRaceCode2
            // 
            this._lblRaceCode2.AutoSize = true;
            this._lblRaceCode2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._lblRaceCode2.Location = new System.Drawing.Point(14, 81);
            this._lblRaceCode2.Name = "_lblRaceCode2";
            this._lblRaceCode2.Size = new System.Drawing.Size(22, 13);
            this._lblRaceCode2.TabIndex = 7;
            this._lblRaceCode2.Text = "CN";
            // 
            // _raceDivider1
            // 
            this._raceDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this._raceDivider1.Location = new System.Drawing.Point(14, 73);
            this._raceDivider1.Name = "_raceDivider1";
            this._raceDivider1.Size = new System.Drawing.Size(163, 1);
            this._raceDivider1.TabIndex = 8;
            // 
            // _lblRaceDate1
            // 
            this._lblRaceDate1.AutoSize = true;
            this._lblRaceDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblRaceDate1.Location = new System.Drawing.Point(34, 55);
            this._lblRaceDate1.Name = "_lblRaceDate1";
            this._lblRaceDate1.Size = new System.Drawing.Size(61, 13);
            this._lblRaceDate1.TabIndex = 9;
            this._lblRaceDate1.Text = "8 Mar 2026";
            // 
            // _lblRaceName1
            // 
            this._lblRaceName1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this._lblRaceName1.ForeColor = System.Drawing.Color.White;
            this._lblRaceName1.Location = new System.Drawing.Point(34, 40);
            this._lblRaceName1.Name = "_lblRaceName1";
            this._lblRaceName1.Size = new System.Drawing.Size(146, 17);
            this._lblRaceName1.TabIndex = 10;
            this._lblRaceName1.Text = "Gran Premio de Australia";
            // 
            // _lblRaceCode1
            // 
            this._lblRaceCode1.AutoSize = true;
            this._lblRaceCode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._lblRaceCode1.Location = new System.Drawing.Point(14, 43);
            this._lblRaceCode1.Name = "_lblRaceCode1";
            this._lblRaceCode1.Size = new System.Drawing.Size(22, 13);
            this._lblRaceCode1.TabIndex = 11;
            this._lblRaceCode1.Text = "AU";
            // 
            // _raceHeaderAccent
            // 
            this._raceHeaderAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._raceHeaderAccent.Location = new System.Drawing.Point(14, 14);
            this._raceHeaderAccent.Name = "_raceHeaderAccent";
            this._raceHeaderAccent.Size = new System.Drawing.Size(2, 12);
            this._raceHeaderAccent.TabIndex = 12;
            // 
            // _lblRacesTitle
            // 
            this._lblRacesTitle.AutoSize = true;
            this._lblRacesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this._lblRacesTitle.ForeColor = System.Drawing.Color.White;
            this._lblRacesTitle.Location = new System.Drawing.Point(22, 10);
            this._lblRacesTitle.Name = "_lblRacesTitle";
            this._lblRacesTitle.Size = new System.Drawing.Size(176, 21);
            this._lblRacesTitle.TabIndex = 13;
            this._lblRacesTitle.Text = "PROXIMAS CARRERAS";
            // 
            // _leftColumn
            // 
            this._leftColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this._leftColumn.Controls.Add(this._btnCerrarSesion);
            this._leftColumn.Controls.Add(this._btnPerfil);
            this._leftColumn.Controls.Add(this._btnMuro);
            this._leftColumn.Controls.Add(this._navAccent);
            this._leftColumn.Controls.Add(this._lblNav);
            this._leftColumn.Controls.Add(this._sidebarCard);
            this._leftColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this._leftColumn.Location = new System.Drawing.Point(0, 0);
            this._leftColumn.Name = "_leftColumn";
            this._leftColumn.Size = new System.Drawing.Size(360, 616);
            this._leftColumn.TabIndex = 0;
            // 
            // _btnCerrarSesion
            // 
            this._btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this._btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this._btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._btnCerrarSesion.Location = new System.Drawing.Point(180, 215);
            this._btnCerrarSesion.Name = "_btnCerrarSesion";
            this._btnCerrarSesion.Size = new System.Drawing.Size(146, 26);
            this._btnCerrarSesion.TabIndex = 0;
            this._btnCerrarSesion.Text = "Cerrar sesion";
            this._btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // _btnPerfil
            // 
            this._btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this._btnPerfil.FlatAppearance.BorderSize = 0;
            this._btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._btnPerfil.Location = new System.Drawing.Point(180, 185);
            this._btnPerfil.Name = "_btnPerfil";
            this._btnPerfil.Size = new System.Drawing.Size(146, 26);
            this._btnPerfil.TabIndex = 1;
            this._btnPerfil.Text = "Perfil";
            this._btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPerfil.UseVisualStyleBackColor = false;
            // 
            // _btnMuro
            // 
            this._btnMuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
            this._btnMuro.FlatAppearance.BorderSize = 0;
            this._btnMuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._btnMuro.Location = new System.Drawing.Point(180, 156);
            this._btnMuro.Name = "_btnMuro";
            this._btnMuro.Size = new System.Drawing.Size(146, 26);
            this._btnMuro.TabIndex = 2;
            this._btnMuro.Text = "Muro";
            this._btnMuro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMuro.UseVisualStyleBackColor = false;
            // 
            // _navAccent
            // 
            this._navAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._navAccent.Location = new System.Drawing.Point(180, 136);
            this._navAccent.Name = "_navAccent";
            this._navAccent.Size = new System.Drawing.Size(2, 10);
            this._navAccent.TabIndex = 3;
            // 
            // _lblNav
            // 
            this._lblNav.AutoSize = true;
            this._lblNav.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this._lblNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblNav.Location = new System.Drawing.Point(180, 135);
            this._lblNav.Name = "_lblNav";
            this._lblNav.Size = new System.Drawing.Size(79, 13);
            this._lblNav.TabIndex = 4;
            this._lblNav.Text = "NAVEGACION";
            // 
            // _sidebarCard
            // 
            this._sidebarCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this._sidebarCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._sidebarCard.Controls.Add(this._lblSidebarTag);
            this._sidebarCard.Controls.Add(this._lblSidebarNombre);
            this._sidebarCard.Controls.Add(this._lblSidebarAvatar);
            this._sidebarCard.Location = new System.Drawing.Point(180, 23);
            this._sidebarCard.Name = "_sidebarCard";
            this._sidebarCard.Size = new System.Drawing.Size(172, 96);
            this._sidebarCard.TabIndex = 5;
            // 
            // _lblSidebarTag
            // 
            this._lblSidebarTag.AutoSize = true;
            this._lblSidebarTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblSidebarTag.Location = new System.Drawing.Point(14, 71);
            this._lblSidebarTag.Name = "_lblSidebarTag";
            this._lblSidebarTag.Size = new System.Drawing.Size(38, 13);
            this._lblSidebarTag.TabIndex = 0;
            this._lblSidebarTag.Text = "@user";
            // 
            // _lblSidebarNombre
            // 
            this._lblSidebarNombre.AutoSize = true;
            this._lblSidebarNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this._lblSidebarNombre.ForeColor = System.Drawing.Color.White;
            this._lblSidebarNombre.Location = new System.Drawing.Point(14, 52);
            this._lblSidebarNombre.Name = "_lblSidebarNombre";
            this._lblSidebarNombre.Size = new System.Drawing.Size(41, 21);
            this._lblSidebarNombre.TabIndex = 1;
            this._lblSidebarNombre.Text = "user";
            // 
            // _lblSidebarAvatar
            // 
            this._lblSidebarAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._lblSidebarAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this._lblSidebarAvatar.ForeColor = System.Drawing.Color.White;
            this._lblSidebarAvatar.Location = new System.Drawing.Point(14, 12);
            this._lblSidebarAvatar.Name = "_lblSidebarAvatar";
            this._lblSidebarAvatar.Size = new System.Drawing.Size(36, 36);
            this._lblSidebarAvatar.TabIndex = 2;
            this._lblSidebarAvatar.Text = "U";
            this._lblSidebarAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1166, 659);
            this.Controls.Add(this._layoutRoot);
            this.Controls.Add(this._topBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1014, 612);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this._topBar.ResumeLayout(false);
            this._topBar.PerformLayout();
            this._layoutRoot.ResumeLayout(false);
            this._centerColumn.ResumeLayout(false);
            this._composerPanel.ResumeLayout(false);
            this._buttonHost.ResumeLayout(false);
            this._editorHost.ResumeLayout(false);
            this._editorHost.PerformLayout();
            this._headerPanel.ResumeLayout(false);
            this._headerPanel.PerformLayout();
            this._rightColumn.ResumeLayout(false);
            this._racesCard.ResumeLayout(false);
            this._racesCard.PerformLayout();
            this._leftColumn.ResumeLayout(false);
            this._leftColumn.PerformLayout();
            this._sidebarCard.ResumeLayout(false);
            this._sidebarCard.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel _topBar;
        private System.Windows.Forms.Label _lblTopUsuario;
        private System.Windows.Forms.Label _lblTopAvatar;
        private System.Windows.Forms.Label _lblLogo;
        private System.Windows.Forms.Panel _layoutRoot;
        private System.Windows.Forms.Panel _centerColumn;
        private System.Windows.Forms.FlowLayoutPanel _feedContainer;
        private System.Windows.Forms.Panel _composerPanel;
        private System.Windows.Forms.Panel _buttonHost;
        private System.Windows.Forms.Button _btnPublicar;
        private System.Windows.Forms.Panel _dividerComposer;
        private System.Windows.Forms.Panel _editorHost;
        private System.Windows.Forms.RichTextBox _txtNuevaPublicacion;
        private System.Windows.Forms.Label _lblPlaceholderPublicacion;
        private System.Windows.Forms.Label _lblComposerAvatar;
        private System.Windows.Forms.Panel _headerPanel;
        private System.Windows.Forms.Label _lblMuro;
        private System.Windows.Forms.Panel _rightColumn;
        private System.Windows.Forms.Panel _racesCard;
        private System.Windows.Forms.Panel _raceDivider3;
        private System.Windows.Forms.Label _lblRaceDate3;
        private System.Windows.Forms.Label _lblRaceName3;
        private System.Windows.Forms.Label _lblRaceCode3;
        private System.Windows.Forms.Panel _raceDivider2;
        private System.Windows.Forms.Label _lblRaceDate2;
        private System.Windows.Forms.Label _lblRaceName2;
        private System.Windows.Forms.Label _lblRaceCode2;
        private System.Windows.Forms.Panel _raceDivider1;
        private System.Windows.Forms.Label _lblRaceDate1;
        private System.Windows.Forms.Label _lblRaceName1;
        private System.Windows.Forms.Label _lblRaceCode1;
        private System.Windows.Forms.Panel _raceHeaderAccent;
        private System.Windows.Forms.Label _lblRacesTitle;
        private System.Windows.Forms.Panel _leftColumn;
        private System.Windows.Forms.Button _btnCerrarSesion;
        private System.Windows.Forms.Button _btnPerfil;
        private System.Windows.Forms.Button _btnMuro;
        private System.Windows.Forms.Panel _navAccent;
        private System.Windows.Forms.Label _lblNav;
        private System.Windows.Forms.Panel _sidebarCard;
        private System.Windows.Forms.Label _lblSidebarTag;
        private System.Windows.Forms.Label _lblSidebarNombre;
        private System.Windows.Forms.Label _lblSidebarAvatar;
    }
}
