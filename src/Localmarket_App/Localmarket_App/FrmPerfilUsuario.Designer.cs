
namespace Localmarket_App
{
    partial class FrmPerfilUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilUsuario));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlNaranja = new System.Windows.Forms.Panel();
            this.picAjustes = new System.Windows.Forms.PictureBox();
            this.pboxTienda = new System.Windows.Forms.PictureBox();
            this.pnlAjustes = new System.Windows.Forms.Panel();
            this.lblModoNoche = new System.Windows.Forms.Label();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.picNocheOn = new System.Windows.Forms.PictureBox();
            this.picNocheOff = new System.Windows.Forms.PictureBox();
            this.picIdioma = new System.Windows.Forms.PictureBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.openFileDialogPerfil = new System.Windows.Forms.OpenFileDialog();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRepContraseña = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtRepContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.picEditarMail = new System.Windows.Forms.PictureBox();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.picEditarUsuario = new System.Windows.Forms.PictureBox();
            this.picEditarContraseña = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnEditarNegocio = new System.Windows.Forms.Button();
            this.pnlNaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTienda)).BeginInit();
            this.pnlAjustes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditarMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditarContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(446, 316);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(124, 34);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario:";
            // 
            // pnlNaranja
            // 
            this.pnlNaranja.BackColor = System.Drawing.Color.Orange;
            this.pnlNaranja.Controls.Add(this.picAjustes);
            this.pnlNaranja.Controls.Add(this.pboxTienda);
            this.pnlNaranja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNaranja.Location = new System.Drawing.Point(0, 0);
            this.pnlNaranja.Name = "pnlNaranja";
            this.pnlNaranja.Size = new System.Drawing.Size(1332, 100);
            this.pnlNaranja.TabIndex = 14;
            // 
            // picAjustes
            // 
            this.picAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAjustes.Image = global::Localmarket_App.Properties.Resources.icono_ajustes;
            this.picAjustes.Location = new System.Drawing.Point(1263, 23);
            this.picAjustes.Name = "picAjustes";
            this.picAjustes.Size = new System.Drawing.Size(57, 57);
            this.picAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAjustes.TabIndex = 25;
            this.picAjustes.TabStop = false;
            this.picAjustes.Click += new System.EventHandler(this.picAjustes_Click);
            // 
            // pboxTienda
            // 
            this.pboxTienda.Image = ((System.Drawing.Image)(resources.GetObject("pboxTienda.Image")));
            this.pboxTienda.InitialImage = null;
            this.pboxTienda.Location = new System.Drawing.Point(31, 12);
            this.pboxTienda.Name = "pboxTienda";
            this.pboxTienda.Size = new System.Drawing.Size(75, 68);
            this.pboxTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTienda.TabIndex = 0;
            this.pboxTienda.TabStop = false;
            // 
            // pnlAjustes
            // 
            this.pnlAjustes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAjustes.BackColor = System.Drawing.Color.Aqua;
            this.pnlAjustes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAjustes.Controls.Add(this.lblModoNoche);
            this.pnlAjustes.Controls.Add(this.lblAjustes);
            this.pnlAjustes.Controls.Add(this.picNocheOn);
            this.pnlAjustes.Controls.Add(this.picNocheOff);
            this.pnlAjustes.Controls.Add(this.picIdioma);
            this.pnlAjustes.Controls.Add(this.cmbIdioma);
            this.pnlAjustes.Location = new System.Drawing.Point(1148, 106);
            this.pnlAjustes.Name = "pnlAjustes";
            this.pnlAjustes.Size = new System.Drawing.Size(174, 176);
            this.pnlAjustes.TabIndex = 48;
            this.pnlAjustes.Visible = false;
            // 
            // lblModoNoche
            // 
            this.lblModoNoche.AutoSize = true;
            this.lblModoNoche.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoNoche.Location = new System.Drawing.Point(0, 113);
            this.lblModoNoche.Name = "lblModoNoche";
            this.lblModoNoche.Size = new System.Drawing.Size(110, 20);
            this.lblModoNoche.TabIndex = 23;
            this.lblModoNoche.Text = "Modo Noche";
            // 
            // lblAjustes
            // 
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustes.Location = new System.Drawing.Point(51, 12);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(66, 20);
            this.lblAjustes.TabIndex = 12;
            this.lblAjustes.Text = "Ajustes";
            // 
            // picNocheOn
            // 
            this.picNocheOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNocheOn.Image = global::Localmarket_App.Properties.Resources.on;
            this.picNocheOn.Location = new System.Drawing.Point(124, 100);
            this.picNocheOn.Name = "picNocheOn";
            this.picNocheOn.Size = new System.Drawing.Size(45, 45);
            this.picNocheOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNocheOn.TabIndex = 22;
            this.picNocheOn.TabStop = false;
            this.picNocheOn.Visible = false;
            this.picNocheOn.Click += new System.EventHandler(this.picNocheOn_Click);
            // 
            // picNocheOff
            // 
            this.picNocheOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNocheOff.Image = global::Localmarket_App.Properties.Resources.off;
            this.picNocheOff.Location = new System.Drawing.Point(124, 94);
            this.picNocheOff.Name = "picNocheOff";
            this.picNocheOff.Size = new System.Drawing.Size(45, 56);
            this.picNocheOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNocheOff.TabIndex = 21;
            this.picNocheOff.TabStop = false;
            this.picNocheOff.Click += new System.EventHandler(this.picNocheOff_Click);
            // 
            // picIdioma
            // 
            this.picIdioma.Image = global::Localmarket_App.Properties.Resources.idioma;
            this.picIdioma.Location = new System.Drawing.Point(7, 48);
            this.picIdioma.Name = "picIdioma";
            this.picIdioma.Size = new System.Drawing.Size(40, 40);
            this.picIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIdioma.TabIndex = 20;
            this.picIdioma.TabStop = false;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(57, 54);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(96, 26);
            this.cmbIdioma.TabIndex = 19;
            // 
            // openFileDialogPerfil
            // 
            this.openFileDialogPerfil.FileName = "openFileDialogPerfil";
            this.openFileDialogPerfil.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...\"";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(400, 375);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(170, 34);
            this.lblContraseña.TabIndex = 49;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(464, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 34);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblRepContraseña
            // 
            this.lblRepContraseña.AutoSize = true;
            this.lblRepContraseña.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepContraseña.Location = new System.Drawing.Point(289, 445);
            this.lblRepContraseña.Name = "lblRepContraseña";
            this.lblRepContraseña.Size = new System.Drawing.Size(274, 34);
            this.lblRepContraseña.TabIndex = 51;
            this.lblRepContraseña.Text = "Repetir Contraseña:";
            this.lblRepContraseña.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(576, 262);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(206, 28);
            this.txtMail.TabIndex = 52;
            this.txtMail.Text = "ejemplo@gmail.com";
            this.txtMail.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(576, 323);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(206, 28);
            this.txtUsuario.TabIndex = 53;
            this.txtUsuario.Text = "usuario1";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtRepContraseña
            // 
            this.txtRepContraseña.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepContraseña.Location = new System.Drawing.Point(576, 451);
            this.txtRepContraseña.Name = "txtRepContraseña";
            this.txtRepContraseña.PasswordChar = '*';
            this.txtRepContraseña.Size = new System.Drawing.Size(206, 28);
            this.txtRepContraseña.TabIndex = 54;
            this.txtRepContraseña.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(576, 382);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ReadOnly = true;
            this.txtContraseña.Size = new System.Drawing.Size(206, 28);
            this.txtContraseña.TabIndex = 55;
            this.txtContraseña.Text = "contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // picEditarMail
            // 
            this.picEditarMail.Image = global::Localmarket_App.Properties.Resources.editar;
            this.picEditarMail.Location = new System.Drawing.Point(426, 258);
            this.picEditarMail.Name = "picEditarMail";
            this.picEditarMail.Size = new System.Drawing.Size(32, 32);
            this.picEditarMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEditarMail.TabIndex = 56;
            this.picEditarMail.TabStop = false;
            this.picEditarMail.Click += new System.EventHandler(this.picEditarMail_Click);
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = global::Localmarket_App.Properties.Resources.flechaatras;
            this.picAtras.Location = new System.Drawing.Point(31, 147);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(64, 64);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 24;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // picPerfil
            // 
            this.picPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPerfil.Image = global::Localmarket_App.Properties.Resources.Perfil_Usuario;
            this.picPerfil.Location = new System.Drawing.Point(129, 173);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(158, 147);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 13;
            this.picPerfil.TabStop = false;
            this.picPerfil.Click += new System.EventHandler(this.picPerfil_Click);
            // 
            // picEditarUsuario
            // 
            this.picEditarUsuario.Image = global::Localmarket_App.Properties.Resources.editar;
            this.picEditarUsuario.Location = new System.Drawing.Point(406, 316);
            this.picEditarUsuario.Name = "picEditarUsuario";
            this.picEditarUsuario.Size = new System.Drawing.Size(32, 32);
            this.picEditarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEditarUsuario.TabIndex = 57;
            this.picEditarUsuario.TabStop = false;
            this.picEditarUsuario.Click += new System.EventHandler(this.picEditarUsuario_Click);
            // 
            // picEditarContraseña
            // 
            this.picEditarContraseña.Image = global::Localmarket_App.Properties.Resources.editar;
            this.picEditarContraseña.Location = new System.Drawing.Point(362, 375);
            this.picEditarContraseña.Name = "picEditarContraseña";
            this.picEditarContraseña.Size = new System.Drawing.Size(32, 32);
            this.picEditarContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEditarContraseña.TabIndex = 58;
            this.picEditarContraseña.TabStop = false;
            this.picEditarContraseña.Click += new System.EventHandler(this.picEditarContraseña_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(515, 535);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(300, 63);
            this.btnGuardarCambios.TabIndex = 59;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnEditarNegocio
            // 
            this.btnEditarNegocio.BackColor = System.Drawing.Color.Aqua;
            this.btnEditarNegocio.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarNegocio.Location = new System.Drawing.Point(987, 535);
            this.btnEditarNegocio.Name = "btnEditarNegocio";
            this.btnEditarNegocio.Size = new System.Drawing.Size(236, 57);
            this.btnEditarNegocio.TabIndex = 60;
            this.btnEditarNegocio.Text = "Editar Negocio";
            this.btnEditarNegocio.UseVisualStyleBackColor = false;
            this.btnEditarNegocio.Visible = false;
            this.btnEditarNegocio.Click += new System.EventHandler(this.btnEditarNegocio_Click);
            // 
            // FrmPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.btnEditarNegocio);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.picEditarContraseña);
            this.Controls.Add(this.picEditarUsuario);
            this.Controls.Add(this.picEditarMail);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtRepContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblRepContraseña);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.pnlAjustes);
            this.Controls.Add(this.picAtras);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.pnlNaranja);
            this.Name = "FrmPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil Usuario";
            this.Load += new System.EventHandler(this.FrmPerfilUsuario_Load);
            this.pnlNaranja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTienda)).EndInit();
            this.pnlAjustes.ResumeLayout(false);
            this.pnlAjustes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditarMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditarContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Panel pnlNaranja;
        private System.Windows.Forms.PictureBox pboxTienda;
        private System.Windows.Forms.PictureBox picAjustes;
        private System.Windows.Forms.Panel pnlAjustes;
        private System.Windows.Forms.Label lblModoNoche;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.PictureBox picNocheOn;
        private System.Windows.Forms.PictureBox picNocheOff;
        private System.Windows.Forms.PictureBox picIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.OpenFileDialog openFileDialogPerfil;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRepContraseña;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtRepContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox picEditarMail;
        private System.Windows.Forms.PictureBox picEditarUsuario;
        private System.Windows.Forms.PictureBox picEditarContraseña;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnEditarNegocio;
    }
}