namespace F1HUB
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this._layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellidos = new System.Windows.Forms.Label();
            this._lblUsuario = new System.Windows.Forms.Label();
            this._lblEmail = new System.Windows.Forms.Label();
            this._lblFecha = new System.Windows.Forms.Label();
            this._lblGenero = new System.Windows.Forms.Label();
            this._lblPassword = new System.Windows.Forms.Label();
            this._lblConfirmPassword = new System.Windows.Forms.Label();
            this._spacerLabel = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellidos = new System.Windows.Forms.TextBox();
            this._txtNombreUsuario = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtFecha = new System.Windows.Forms.TextBox();
            this._cmbGenero = new System.Windows.Forms.ComboBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._txtConfirmPassword = new System.Windows.Forms.TextBox();
            this._btnCrear = new System.Windows.Forms.Button();
            this._layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _layoutPanel
            // 
            this._layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this._layoutPanel.ColumnCount = 2;
            this._layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this._layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this._layoutPanel.Controls.Add(this._lblNombre, 0, 0);
            this._layoutPanel.Controls.Add(this._lblApellidos, 0, 1);
            this._layoutPanel.Controls.Add(this._lblUsuario, 0, 2);
            this._layoutPanel.Controls.Add(this._lblEmail, 0, 3);
            this._layoutPanel.Controls.Add(this._lblFecha, 0, 4);
            this._layoutPanel.Controls.Add(this._lblGenero, 0, 5);
            this._layoutPanel.Controls.Add(this._lblPassword, 0, 6);
            this._layoutPanel.Controls.Add(this._lblConfirmPassword, 0, 7);
            this._layoutPanel.Controls.Add(this._spacerLabel, 0, 8);
            this._layoutPanel.Controls.Add(this._txtNombre, 1, 0);
            this._layoutPanel.Controls.Add(this._txtApellidos, 1, 1);
            this._layoutPanel.Controls.Add(this._txtNombreUsuario, 1, 2);
            this._layoutPanel.Controls.Add(this._txtEmail, 1, 3);
            this._layoutPanel.Controls.Add(this._txtFecha, 1, 4);
            this._layoutPanel.Controls.Add(this._cmbGenero, 1, 5);
            this._layoutPanel.Controls.Add(this._txtPassword, 1, 6);
            this._layoutPanel.Controls.Add(this._txtConfirmPassword, 1, 7);
            this._layoutPanel.Controls.Add(this._btnCrear, 1, 8);
            this._layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._layoutPanel.Location = new System.Drawing.Point(0, 0);
            this._layoutPanel.Name = "_layoutPanel";
            this._layoutPanel.Padding = new System.Windows.Forms.Padding(17);
            this._layoutPanel.RowCount = 9;
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this._layoutPanel.Size = new System.Drawing.Size(432, 417);
            this._layoutPanel.TabIndex = 0;
            // 
            // _lblNombre
            // 
            this._lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblNombre.ForeColor = System.Drawing.Color.White;
            this._lblNombre.Location = new System.Drawing.Point(20, 17);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(145, 36);
            this._lblNombre.TabIndex = 0;
            this._lblNombre.Text = "Nombre";
            this._lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblApellidos
            // 
            this._lblApellidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblApellidos.ForeColor = System.Drawing.Color.White;
            this._lblApellidos.Location = new System.Drawing.Point(20, 53);
            this._lblApellidos.Name = "_lblApellidos";
            this._lblApellidos.Size = new System.Drawing.Size(145, 36);
            this._lblApellidos.TabIndex = 1;
            this._lblApellidos.Text = "Apellidos";
            this._lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblUsuario
            // 
            this._lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblUsuario.ForeColor = System.Drawing.Color.White;
            this._lblUsuario.Location = new System.Drawing.Point(20, 89);
            this._lblUsuario.Name = "_lblUsuario";
            this._lblUsuario.Size = new System.Drawing.Size(145, 36);
            this._lblUsuario.TabIndex = 2;
            this._lblUsuario.Text = "Usuario";
            this._lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblEmail
            // 
            this._lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblEmail.ForeColor = System.Drawing.Color.White;
            this._lblEmail.Location = new System.Drawing.Point(20, 125);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(145, 36);
            this._lblEmail.TabIndex = 3;
            this._lblEmail.Text = "Email";
            this._lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblFecha
            // 
            this._lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblFecha.ForeColor = System.Drawing.Color.White;
            this._lblFecha.Location = new System.Drawing.Point(20, 161);
            this._lblFecha.Name = "_lblFecha";
            this._lblFecha.Size = new System.Drawing.Size(145, 36);
            this._lblFecha.TabIndex = 4;
            this._lblFecha.Text = "Fecha Nacimiento";
            this._lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblGenero
            // 
            this._lblGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblGenero.ForeColor = System.Drawing.Color.White;
            this._lblGenero.Location = new System.Drawing.Point(20, 197);
            this._lblGenero.Name = "_lblGenero";
            this._lblGenero.Size = new System.Drawing.Size(145, 36);
            this._lblGenero.TabIndex = 5;
            this._lblGenero.Text = "Genero";
            this._lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblPassword
            // 
            this._lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblPassword.ForeColor = System.Drawing.Color.White;
            this._lblPassword.Location = new System.Drawing.Point(20, 233);
            this._lblPassword.Name = "_lblPassword";
            this._lblPassword.Size = new System.Drawing.Size(145, 36);
            this._lblPassword.TabIndex = 6;
            this._lblPassword.Text = "Contrasena";
            this._lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _lblConfirmPassword
            // 
            this._lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this._lblConfirmPassword.Location = new System.Drawing.Point(20, 269);
            this._lblConfirmPassword.Name = "_lblConfirmPassword";
            this._lblConfirmPassword.Size = new System.Drawing.Size(145, 36);
            this._lblConfirmPassword.TabIndex = 7;
            this._lblConfirmPassword.Text = "Confirmar";
            this._lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _spacerLabel
            // 
            this._spacerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._spacerLabel.Location = new System.Drawing.Point(20, 305);
            this._spacerLabel.Name = "_spacerLabel";
            this._spacerLabel.Size = new System.Drawing.Size(145, 95);
            this._spacerLabel.TabIndex = 8;
            // 
            // _txtNombre
            // 
            this._txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtNombre.Location = new System.Drawing.Point(171, 20);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(241, 20);
            this._txtNombre.TabIndex = 9;
            // 
            // _txtApellidos
            // 
            this._txtApellidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtApellidos.Location = new System.Drawing.Point(171, 56);
            this._txtApellidos.Name = "_txtApellidos";
            this._txtApellidos.Size = new System.Drawing.Size(241, 20);
            this._txtApellidos.TabIndex = 10;
            // 
            // _txtNombreUsuario
            // 
            this._txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtNombreUsuario.Location = new System.Drawing.Point(171, 92);
            this._txtNombreUsuario.Name = "_txtNombreUsuario";
            this._txtNombreUsuario.Size = new System.Drawing.Size(241, 20);
            this._txtNombreUsuario.TabIndex = 11;
            // 
            // _txtEmail
            // 
            this._txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtEmail.Location = new System.Drawing.Point(171, 128);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(241, 20);
            this._txtEmail.TabIndex = 12;
            // 
            // _txtFecha
            // 
            this._txtFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtFecha.Location = new System.Drawing.Point(171, 164);
            this._txtFecha.Name = "_txtFecha";
            this._txtFecha.Size = new System.Drawing.Size(241, 20);
            this._txtFecha.TabIndex = 13;
            // 
            // _cmbGenero
            // 
            this._cmbGenero.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbGenero.FormattingEnabled = true;
            this._cmbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro",
            "No especificado"});
            this._cmbGenero.Location = new System.Drawing.Point(171, 200);
            this._cmbGenero.Name = "_cmbGenero";
            this._cmbGenero.Size = new System.Drawing.Size(241, 21);
            this._cmbGenero.TabIndex = 14;
            // 
            // _txtPassword
            // 
            this._txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtPassword.Location = new System.Drawing.Point(171, 236);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(241, 20);
            this._txtPassword.TabIndex = 15;
            this._txtPassword.UseSystemPasswordChar = true;
            // 
            // _txtConfirmPassword
            // 
            this._txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtConfirmPassword.Location = new System.Drawing.Point(171, 272);
            this._txtConfirmPassword.Name = "_txtConfirmPassword";
            this._txtConfirmPassword.Size = new System.Drawing.Size(241, 20);
            this._txtConfirmPassword.TabIndex = 16;
            this._txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // _btnCrear
            // 
            this._btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnCrear.BackColor = System.Drawing.Color.Red;
            this._btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCrear.ForeColor = System.Drawing.Color.White;
            this._btnCrear.Location = new System.Drawing.Point(171, 339);
            this._btnCrear.Name = "_btnCrear";
            this._btnCrear.Size = new System.Drawing.Size(120, 26);
            this._btnCrear.TabIndex = 17;
            this._btnCrear.Text = "Crear cuenta";
            this._btnCrear.UseVisualStyleBackColor = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(432, 417);
            this.Controls.Add(this._layoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro - F1HUB";
            this._layoutPanel.ResumeLayout(false);
            this._layoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel _layoutPanel;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellidos;
        private System.Windows.Forms.Label _lblUsuario;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.Label _lblFecha;
        private System.Windows.Forms.Label _lblGenero;
        private System.Windows.Forms.Label _lblPassword;
        private System.Windows.Forms.Label _lblConfirmPassword;
        private System.Windows.Forms.Label _spacerLabel;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellidos;
        private System.Windows.Forms.TextBox _txtNombreUsuario;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.TextBox _txtFecha;
        private System.Windows.Forms.ComboBox _cmbGenero;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.TextBox _txtConfirmPassword;
        private System.Windows.Forms.Button _btnCrear;
    }
}
