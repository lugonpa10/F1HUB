namespace F1HUB
{
    partial class FormPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfil));
            this._topBar = new System.Windows.Forms.Panel();
            this._lblTopUsuario = new System.Windows.Forms.Label();
            this._lblTopAvatar = new System.Windows.Forms.Label();
            this._lblLogo = new System.Windows.Forms.Label();
            this._layoutRoot = new System.Windows.Forms.Panel();
            this._contentColumn = new System.Windows.Forms.Panel();
            this._postsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._formBlock = new System.Windows.Forms.Panel();
            this._saveBar = new System.Windows.Forms.Panel();
            this._btnGuardar = new System.Windows.Forms.Button();
            this._dividerBottom = new System.Windows.Forms.Panel();
            this._cmbGenero = new System.Windows.Forms.ComboBox();
            this._dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtApellidos = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblGenero = new System.Windows.Forms.Label();
            this._lblFechaNacimiento = new System.Windows.Forms.Label();
            this._lblEmail = new System.Windows.Forms.Label();
            this._lblApellidos = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._profileHeader = new System.Windows.Forms.Panel();
            this._lblProfileTag = new System.Windows.Forms.Label();
            this._lblProfileNombre = new System.Windows.Forms.Label();
            this._lblProfileAvatar = new System.Windows.Forms.Label();
            this._headerPanel = new System.Windows.Forms.Panel();
            this._lblMiPerfil = new System.Windows.Forms.Label();
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
            this._contentColumn.SuspendLayout();
            this._formBlock.SuspendLayout();
            this._saveBar.SuspendLayout();
            this._profileHeader.SuspendLayout();
            this._headerPanel.SuspendLayout();
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
            this._topBar.Size = new System.Drawing.Size(960, 43);
            this._topBar.TabIndex = 0;
            // 
            // _lblTopUsuario
            // 
            this._lblTopUsuario.AutoSize = true;
            this._lblTopUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this._lblTopUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblTopUsuario.Location = new System.Drawing.Point(909, 13);
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
            this._lblTopAvatar.Location = new System.Drawing.Point(874, 9);
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
            this._layoutRoot.Controls.Add(this._contentColumn);
            this._layoutRoot.Controls.Add(this._leftColumn);
            this._layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this._layoutRoot.Location = new System.Drawing.Point(0, 43);
            this._layoutRoot.Name = "_layoutRoot";
            this._layoutRoot.Size = new System.Drawing.Size(960, 616);
            this._layoutRoot.TabIndex = 1;
            // 
            // _contentColumn
            // 
            this._contentColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._contentColumn.Controls.Add(this._postsContainer);
            this._contentColumn.Controls.Add(this._formBlock);
            this._contentColumn.Controls.Add(this._headerPanel);
            this._contentColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentColumn.Location = new System.Drawing.Point(257, 0);
            this._contentColumn.Name = "_contentColumn";
            this._contentColumn.Size = new System.Drawing.Size(703, 616);
            this._contentColumn.TabIndex = 1;
            // 
            // _postsContainer
            // 
            this._postsContainer.AutoScroll = true;
            this._postsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._postsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._postsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._postsContainer.Location = new System.Drawing.Point(0, 354);
            this._postsContainer.Name = "_postsContainer";
            this._postsContainer.Size = new System.Drawing.Size(703, 262);
            this._postsContainer.TabIndex = 2;
            this._postsContainer.WrapContents = false;
            // 
            // _formBlock
            // 
            this._formBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this._formBlock.Controls.Add(this._saveBar);
            this._formBlock.Controls.Add(this._dividerBottom);
            this._formBlock.Controls.Add(this._cmbGenero);
            this._formBlock.Controls.Add(this._dtpFechaNacimiento);
            this._formBlock.Controls.Add(this._txtEmail);
            this._formBlock.Controls.Add(this._txtApellidos);
            this._formBlock.Controls.Add(this._txtNombre);
            this._formBlock.Controls.Add(this._lblGenero);
            this._formBlock.Controls.Add(this._lblFechaNacimiento);
            this._formBlock.Controls.Add(this._lblEmail);
            this._formBlock.Controls.Add(this._lblApellidos);
            this._formBlock.Controls.Add(this._lblNombre);
            this._formBlock.Controls.Add(this._profileHeader);
            this._formBlock.Dock = System.Windows.Forms.DockStyle.Top;
            this._formBlock.Location = new System.Drawing.Point(0, 42);
            this._formBlock.Name = "_formBlock";
            this._formBlock.Size = new System.Drawing.Size(703, 312);
            this._formBlock.TabIndex = 1;
            // 
            // _saveBar
            // 
            this._saveBar.Controls.Add(this._btnGuardar);
            this._saveBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._saveBar.Location = new System.Drawing.Point(0, 263);
            this._saveBar.Name = "_saveBar";
            this._saveBar.Size = new System.Drawing.Size(703, 49);
            this._saveBar.TabIndex = 12;
            // 
            // _btnGuardar
            // 
            this._btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._btnGuardar.FlatAppearance.BorderSize = 0;
            this._btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnGuardar.ForeColor = System.Drawing.Color.White;
            this._btnGuardar.Location = new System.Drawing.Point(547, 10);
            this._btnGuardar.Name = "_btnGuardar";
            this._btnGuardar.Size = new System.Drawing.Size(139, 26);
            this._btnGuardar.TabIndex = 0;
            this._btnGuardar.Text = "GUARDAR CAMBIOS";
            this._btnGuardar.UseVisualStyleBackColor = false;
            // 
            // _dividerBottom
            // 
            this._dividerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this._dividerBottom.Location = new System.Drawing.Point(17, 243);
            this._dividerBottom.Name = "_dividerBottom";
            this._dividerBottom.Size = new System.Drawing.Size(669, 1);
            this._dividerBottom.TabIndex = 11;
            // 
            // _cmbGenero
            // 
            this._cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this._cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmbGenero.ForeColor = System.Drawing.Color.White;
            this._cmbGenero.FormattingEnabled = true;
            this._cmbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro",
            "No especificado"});
            this._cmbGenero.Location = new System.Drawing.Point(360, 185);
            this._cmbGenero.Name = "_cmbGenero";
            this._cmbGenero.Size = new System.Drawing.Size(206, 21);
            this._cmbGenero.TabIndex = 13;
            // 
            // _dtpFechaNacimiento
            // 
            this._dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this._dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpFechaNacimiento.Location = new System.Drawing.Point(17, 185);
            this._dtpFechaNacimiento.Name = "_dtpFechaNacimiento";
            this._dtpFechaNacimiento.Size = new System.Drawing.Size(206, 20);
            this._dtpFechaNacimiento.TabIndex = 14;
            // 
            // _txtEmail
            // 
            this._txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this._txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtEmail.ForeColor = System.Drawing.Color.White;
            this._txtEmail.Location = new System.Drawing.Point(17, 133);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(549, 20);
            this._txtEmail.TabIndex = 15;
            // 
            // _txtApellidos
            // 
            this._txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this._txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtApellidos.ForeColor = System.Drawing.Color.White;
            this._txtApellidos.Location = new System.Drawing.Point(360, 81);
            this._txtApellidos.Name = "_txtApellidos";
            this._txtApellidos.Size = new System.Drawing.Size(206, 20);
            this._txtApellidos.TabIndex = 16;
            // 
            // _txtNombre
            // 
            this._txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this._txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._txtNombre.ForeColor = System.Drawing.Color.White;
            this._txtNombre.Location = new System.Drawing.Point(17, 81);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(206, 20);
            this._txtNombre.TabIndex = 17;
            // 
            // _lblGenero
            // 
            this._lblGenero.AutoSize = true;
            this._lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblGenero.Location = new System.Drawing.Point(360, 168);
            this._lblGenero.Name = "_lblGenero";
            this._lblGenero.Size = new System.Drawing.Size(53, 13);
            this._lblGenero.TabIndex = 18;
            this._lblGenero.Text = "GENERO";
            // 
            // _lblFechaNacimiento
            // 
            this._lblFechaNacimiento.AutoSize = true;
            this._lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblFechaNacimiento.Location = new System.Drawing.Point(17, 168);
            this._lblFechaNacimiento.Name = "_lblFechaNacimiento";
            this._lblFechaNacimiento.Size = new System.Drawing.Size(130, 13);
            this._lblFechaNacimiento.TabIndex = 19;
            this._lblFechaNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblEmail.Location = new System.Drawing.Point(17, 116);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(39, 13);
            this._lblEmail.TabIndex = 20;
            this._lblEmail.Text = "EMAIL";
            // 
            // _lblApellidos
            // 
            this._lblApellidos.AutoSize = true;
            this._lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblApellidos.Location = new System.Drawing.Point(360, 64);
            this._lblApellidos.Name = "_lblApellidos";
            this._lblApellidos.Size = new System.Drawing.Size(66, 13);
            this._lblApellidos.TabIndex = 21;
            this._lblApellidos.Text = "APELLIDOS";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblNombre.Location = new System.Drawing.Point(17, 64);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(54, 13);
            this._lblNombre.TabIndex = 22;
            this._lblNombre.Text = "NOMBRE";
            // 
            // _profileHeader
            // 
            this._profileHeader.Controls.Add(this._lblProfileTag);
            this._profileHeader.Controls.Add(this._lblProfileNombre);
            this._profileHeader.Controls.Add(this._lblProfileAvatar);
            this._profileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this._profileHeader.Location = new System.Drawing.Point(0, 0);
            this._profileHeader.Name = "_profileHeader";
            this._profileHeader.Size = new System.Drawing.Size(703, 49);
            this._profileHeader.TabIndex = 0;
            // 
            // _lblProfileTag
            // 
            this._lblProfileTag.AutoSize = true;
            this._lblProfileTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblProfileTag.Location = new System.Drawing.Point(58, 21);
            this._lblProfileTag.Name = "_lblProfileTag";
            this._lblProfileTag.Size = new System.Drawing.Size(38, 13);
            this._lblProfileTag.TabIndex = 0;
            this._lblProfileTag.Text = "@user";
            // 
            // _lblProfileNombre
            // 
            this._lblProfileNombre.AutoSize = true;
            this._lblProfileNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this._lblProfileNombre.ForeColor = System.Drawing.Color.White;
            this._lblProfileNombre.Location = new System.Drawing.Point(58, 2);
            this._lblProfileNombre.Name = "_lblProfileNombre";
            this._lblProfileNombre.Size = new System.Drawing.Size(71, 21);
            this._lblProfileNombre.TabIndex = 1;
            this._lblProfileNombre.Text = "Nombre";
            // 
            // _lblProfileAvatar
            // 
            this._lblProfileAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._lblProfileAvatar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this._lblProfileAvatar.ForeColor = System.Drawing.Color.White;
            this._lblProfileAvatar.Location = new System.Drawing.Point(17, 3);
            this._lblProfileAvatar.Name = "_lblProfileAvatar";
            this._lblProfileAvatar.Size = new System.Drawing.Size(29, 29);
            this._lblProfileAvatar.TabIndex = 2;
            this._lblProfileAvatar.Text = "U";
            this._lblProfileAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _headerPanel
            // 
            this._headerPanel.Controls.Add(this._lblMiPerfil);
            this._headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._headerPanel.Location = new System.Drawing.Point(0, 0);
            this._headerPanel.Name = "_headerPanel";
            this._headerPanel.Size = new System.Drawing.Size(703, 42);
            this._headerPanel.TabIndex = 0;
            // 
            // _lblMiPerfil
            // 
            this._lblMiPerfil.AutoSize = true;
            this._lblMiPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this._lblMiPerfil.ForeColor = System.Drawing.Color.White;
            this._lblMiPerfil.Location = new System.Drawing.Point(17, 9);
            this._lblMiPerfil.Name = "_lblMiPerfil";
            this._lblMiPerfil.Size = new System.Drawing.Size(111, 30);
            this._lblMiPerfil.TabIndex = 0;
            this._lblMiPerfil.Text = "MI PERFIL";
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
            this._leftColumn.Size = new System.Drawing.Size(257, 616);
            this._leftColumn.TabIndex = 0;
            // 
            // _btnCerrarSesion
            // 
            this._btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this._btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this._btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._btnCerrarSesion.Location = new System.Drawing.Point(99, 215);
            this._btnCerrarSesion.Name = "_btnCerrarSesion";
            this._btnCerrarSesion.Size = new System.Drawing.Size(146, 26);
            this._btnCerrarSesion.TabIndex = 0;
            this._btnCerrarSesion.Text = "Cerrar sesion";
            this._btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // _btnPerfil
            // 
            this._btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
            this._btnPerfil.FlatAppearance.BorderSize = 0;
            this._btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this._btnPerfil.Location = new System.Drawing.Point(99, 185);
            this._btnPerfil.Name = "_btnPerfil";
            this._btnPerfil.Size = new System.Drawing.Size(146, 26);
            this._btnPerfil.TabIndex = 1;
            this._btnPerfil.Text = "Perfil";
            this._btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPerfil.UseVisualStyleBackColor = false;
            // 
            // _btnMuro
            // 
            this._btnMuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this._btnMuro.FlatAppearance.BorderSize = 0;
            this._btnMuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._btnMuro.Location = new System.Drawing.Point(99, 156);
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
            this._navAccent.Location = new System.Drawing.Point(99, 136);
            this._navAccent.Name = "_navAccent";
            this._navAccent.Size = new System.Drawing.Size(2, 10);
            this._navAccent.TabIndex = 3;
            // 
            // _lblNav
            // 
            this._lblNav.AutoSize = true;
            this._lblNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this._lblNav.Location = new System.Drawing.Point(99, 135);
            this._lblNav.Name = "_lblNav";
            this._lblNav.Size = new System.Drawing.Size(77, 13);
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
            this._sidebarCard.Location = new System.Drawing.Point(99, 21);
            this._sidebarCard.Name = "_sidebarCard";
            this._sidebarCard.Size = new System.Drawing.Size(146, 96);
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
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(960, 659);
            this.Controls.Add(this._layoutRoot);
            this.Controls.Add(this._topBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(894, 612);
            this.Name = "FormPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this._topBar.ResumeLayout(false);
            this._topBar.PerformLayout();
            this._layoutRoot.ResumeLayout(false);
            this._contentColumn.ResumeLayout(false);
            this._formBlock.ResumeLayout(false);
            this._formBlock.PerformLayout();
            this._saveBar.ResumeLayout(false);
            this._profileHeader.ResumeLayout(false);
            this._profileHeader.PerformLayout();
            this._headerPanel.ResumeLayout(false);
            this._headerPanel.PerformLayout();
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
        private System.Windows.Forms.Panel _contentColumn;
        private System.Windows.Forms.FlowLayoutPanel _postsContainer;
        private System.Windows.Forms.Panel _formBlock;
        private System.Windows.Forms.Panel _saveBar;
        private System.Windows.Forms.Button _btnGuardar;
        private System.Windows.Forms.Panel _dividerBottom;
        private System.Windows.Forms.ComboBox _cmbGenero;
        private System.Windows.Forms.DateTimePicker _dtpFechaNacimiento;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.TextBox _txtApellidos;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblGenero;
        private System.Windows.Forms.Label _lblFechaNacimiento;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.Label _lblApellidos;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Panel _profileHeader;
        private System.Windows.Forms.Label _lblProfileTag;
        private System.Windows.Forms.Label _lblProfileNombre;
        private System.Windows.Forms.Label _lblProfileAvatar;
        private System.Windows.Forms.Panel _headerPanel;
        private System.Windows.Forms.Label _lblMiPerfil;
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
