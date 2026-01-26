namespace F1HUB
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.lblUsuario = new MetroSet_UI.Controls.MetroSetLabel();
            this.Contraseña = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtUsuario = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnIniciarSesion = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUsuario.IsDerivedStyle = false;
            this.lblUsuario.Location = new System.Drawing.Point(161, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 23);
            this.lblUsuario.Style = MetroSet_UI.Enums.Style.Light;
            this.lblUsuario.StyleManager = null;
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario\r\n";
            this.lblUsuario.ThemeAuthor = "";
            this.lblUsuario.ThemeName = "";
            // 
            // Contraseña
            // 
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Contraseña.IsDerivedStyle = false;
            this.Contraseña.Location = new System.Drawing.Point(161, 121);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(100, 23);
            this.Contraseña.Style = MetroSet_UI.Enums.Style.Light;
            this.Contraseña.StyleManager = null;
            this.Contraseña.TabIndex = 1;
            this.Contraseña.Text = "Contraseña\r\n";
            this.Contraseña.ThemeAuthor = "Narwin";
            this.Contraseña.ThemeName = "MetroLite";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteCustomSource = null;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsuario.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsuario.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsuario.Image = null;
            this.txtUsuario.IsDerivedStyle = false;
            this.txtUsuario.Lines = null;
            this.txtUsuario.Location = new System.Drawing.Point(267, 73);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(135, 30);
            this.txtUsuario.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUsuario.StyleManager = null;
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.ThemeAuthor = "Narwin";
            this.txtUsuario.ThemeName = "MetroLite";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.WatermarkText = "";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource = null;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPassword.Image = null;
            this.txtPassword.IsDerivedStyle = false;
            this.txtPassword.Lines = null;
            this.txtPassword.Location = new System.Drawing.Point(267, 114);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(135, 30);
            this.txtPassword.Style = MetroSet_UI.Enums.Style.Light;
            this.txtPassword.StyleManager = null;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.ThemeAuthor = "Narwin";
            this.txtPassword.ThemeName = "MetroLite";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WatermarkText = "";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.DisabledBackColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.DisabledBorderColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIniciarSesion.HoverBorderColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.HoverColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.HoverTextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IsDerivedStyle = false;
            this.btnIniciarSesion.Location = new System.Drawing.Point(295, 263);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.NormalBorderColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.NormalColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.NormalTextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.PressBorderColor = System.Drawing.Color.Red;
            this.btnIniciarSesion.PressColor = System.Drawing.Color.LightGray;
            this.btnIniciarSesion.PressTextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Size = new System.Drawing.Size(75, 66);
            this.btnIniciarSesion.Style = MetroSet_UI.Enums.Style.Light;
            this.btnIniciarSesion.StyleManager = null;
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar";
            this.btnIniciarSesion.ThemeAuthor = "Narwin";
            this.btnIniciarSesion.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = false;
            this.metroSetControlBox1.Location = new System.Drawing.Point(534, 9);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 5;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(735, 414);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(735, 414);
            this.MinimumSize = new System.Drawing.Size(735, 414);
            this.Name = "FormInicioSesion";
            this.ResumeLayout(false);

        }


        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lblUsuario;
        private MetroSet_UI.Controls.MetroSetLabel Contraseña;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsuario;
        private MetroSet_UI.Controls.MetroSetTextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetButton btnIniciarSesion;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}

