
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.btnElegirLogo = new System.Windows.Forms.Button();
            this.openFileDialogLogoEmpresa = new System.Windows.Forms.OpenFileDialog();
            this.picPreviewLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxEditarNegocio = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewLogo)).BeginInit();
            this.groupBoxEditarNegocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(360, 314);
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
            this.openFileDialogPerfil.FileName = "openFileDialog1";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(314, 373);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(170, 34);
            this.lblContraseña.TabIndex = 49;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(378, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 34);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblRepContraseña
            // 
            this.lblRepContraseña.AutoSize = true;
            this.lblRepContraseña.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepContraseña.Location = new System.Drawing.Point(203, 443);
            this.lblRepContraseña.Name = "lblRepContraseña";
            this.lblRepContraseña.Size = new System.Drawing.Size(274, 34);
            this.lblRepContraseña.TabIndex = 51;
            this.lblRepContraseña.Text = "Repetir Contraseña:";
            this.lblRepContraseña.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(490, 260);
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
            this.txtUsuario.Location = new System.Drawing.Point(490, 321);
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
            this.txtRepContraseña.Location = new System.Drawing.Point(490, 449);
            this.txtRepContraseña.Name = "txtRepContraseña";
            this.txtRepContraseña.PasswordChar = '*';
            this.txtRepContraseña.Size = new System.Drawing.Size(206, 28);
            this.txtRepContraseña.TabIndex = 54;
            this.txtRepContraseña.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(490, 380);
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
            this.picEditarMail.Location = new System.Drawing.Point(340, 256);
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
            this.picEditarUsuario.Location = new System.Drawing.Point(320, 314);
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
            this.picEditarContraseña.Location = new System.Drawing.Point(276, 373);
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
            this.btnGuardarCambios.Location = new System.Drawing.Point(429, 533);
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
            this.btnEditarNegocio.Location = new System.Drawing.Point(825, 533);
            this.btnEditarNegocio.Name = "btnEditarNegocio";
            this.btnEditarNegocio.Size = new System.Drawing.Size(300, 63);
            this.btnEditarNegocio.TabIndex = 60;
            this.btnEditarNegocio.Text = "Editar Negocio";
            this.btnEditarNegocio.UseVisualStyleBackColor = false;
            this.btnEditarNegocio.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(189, 84);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(311, 84);
            this.txtDescripcion.TabIndex = 65;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(189, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 28);
            this.txtNombre.TabIndex = 64;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(43, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 34);
            this.lblNombre.TabIndex = 63;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(86, 186);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(88, 34);
            this.lblLogo.TabIndex = 62;
            this.lblLogo.Text = "Logo:";
            // 
            // lblDescripción
            // 
            this.lblDescripción.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(6, 85);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(177, 34);
            this.lblDescripción.TabIndex = 61;
            this.lblDescripción.Text = "Descripción:";
            // 
            // btnElegirLogo
            // 
            this.btnElegirLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElegirLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnElegirLogo.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirLogo.Location = new System.Drawing.Point(180, 186);
            this.btnElegirLogo.Name = "btnElegirLogo";
            this.btnElegirLogo.Size = new System.Drawing.Size(159, 38);
            this.btnElegirLogo.TabIndex = 66;
            this.btnElegirLogo.Text = "Elegir archivo";
            this.btnElegirLogo.UseVisualStyleBackColor = false;
            this.btnElegirLogo.Click += new System.EventHandler(this.btnElegirLogo_Click);
            // 
            // openFileDialogLogoEmpresa
            // 
            this.openFileDialogLogoEmpresa.FileName = "openFileDialog1";
            // 
            // picPreviewLogo
            // 
            this.picPreviewLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPreviewLogo.BackColor = System.Drawing.SystemColors.Window;
            this.picPreviewLogo.Location = new System.Drawing.Point(345, 182);
            this.picPreviewLogo.Name = "picPreviewLogo";
            this.picPreviewLogo.Size = new System.Drawing.Size(62, 50);
            this.picPreviewLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewLogo.TabIndex = 67;
            this.picPreviewLogo.TabStop = false;
            // 
            // groupBoxEditarNegocio
            // 
            this.groupBoxEditarNegocio.Controls.Add(this.picPreviewLogo);
            this.groupBoxEditarNegocio.Controls.Add(this.lblNombre);
            this.groupBoxEditarNegocio.Controls.Add(this.btnElegirLogo);
            this.groupBoxEditarNegocio.Controls.Add(this.lblDescripción);
            this.groupBoxEditarNegocio.Controls.Add(this.txtDescripcion);
            this.groupBoxEditarNegocio.Controls.Add(this.lblLogo);
            this.groupBoxEditarNegocio.Controls.Add(this.txtNombre);
            this.groupBoxEditarNegocio.Location = new System.Drawing.Point(717, 119);
            this.groupBoxEditarNegocio.Name = "groupBoxEditarNegocio";
            this.groupBoxEditarNegocio.Size = new System.Drawing.Size(539, 374);
            this.groupBoxEditarNegocio.TabIndex = 68;
            this.groupBoxEditarNegocio.TabStop = false;
            this.groupBoxEditarNegocio.Visible = false;
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
            this.Controls.Add(this.groupBoxEditarNegocio);
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
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewLogo)).EndInit();
            this.groupBoxEditarNegocio.ResumeLayout(false);
            this.groupBoxEditarNegocio.PerformLayout();
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Button btnElegirLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogoEmpresa;
        private System.Windows.Forms.PictureBox picPreviewLogo;
        private System.Windows.Forms.GroupBox groupBoxEditarNegocio;
    }
}