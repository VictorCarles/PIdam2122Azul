
namespace Localmarket_App
{
    partial class FrmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroUsuario));
            this.pnlRegistroComo = new System.Windows.Forms.Panel();
            this.picAjustes = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblRepContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtRepContraseña = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblDatosEmpresario = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.mskCP = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.openFileDialogElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.pnlAjustes = new System.Windows.Forms.Panel();
            this.lblModoNoche = new System.Windows.Forms.Label();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.picNocheOn = new System.Windows.Forms.PictureBox();
            this.picNocheOff = new System.Windows.Forms.PictureBox();
            this.picIdioma = new System.Windows.Forms.PictureBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picAñadeFoto = new System.Windows.Forms.PictureBox();
            this.pnlRegistroComo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlAjustes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAñadeFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroComo
            // 
            this.pnlRegistroComo.BackColor = System.Drawing.Color.Orange;
            this.pnlRegistroComo.Controls.Add(this.picAjustes);
            this.pnlRegistroComo.Controls.Add(this.picLogo);
            this.pnlRegistroComo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegistroComo.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistroComo.Name = "pnlRegistroComo";
            this.pnlRegistroComo.Size = new System.Drawing.Size(1332, 100);
            this.pnlRegistroComo.TabIndex = 0;
            this.pnlRegistroComo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistroComo_Paint);
            // 
            // picAjustes
            // 
            this.picAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAjustes.Image = global::Localmarket_App.Properties.Resources.icono_ajustes;
            this.picAjustes.Location = new System.Drawing.Point(1250, 19);
            this.picAjustes.Name = "picAjustes";
            this.picAjustes.Size = new System.Drawing.Size(57, 57);
            this.picAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAjustes.TabIndex = 2;
            this.picAjustes.TabStop = false;
            this.picAjustes.Click += new System.EventHandler(this.picAjustes_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(31, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(75, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblRepContraseña
            // 
            this.lblRepContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRepContraseña.AutoSize = true;
            this.lblRepContraseña.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepContraseña.Location = new System.Drawing.Point(314, 435);
            this.lblRepContraseña.Name = "lblRepContraseña";
            this.lblRepContraseña.Size = new System.Drawing.Size(175, 23);
            this.lblRepContraseña.TabIndex = 2;
            this.lblRepContraseña.Text = "Repetir Contraseña:";
            this.lblRepContraseña.Click += new System.EventHandler(this.lblRepContraseña_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(406, 240);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 23);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(397, 289);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(92, 23);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.Click += new System.EventHandler(this.lblApellidos_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(379, 395);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(110, 23);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(318, 342);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(171, 23);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo electrónico:";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // txtRepContraseña
            // 
            this.txtRepContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRepContraseña.Location = new System.Drawing.Point(495, 436);
            this.txtRepContraseña.Name = "txtRepContraseña";
            this.txtRepContraseña.Size = new System.Drawing.Size(205, 22);
            this.txtRepContraseña.TabIndex = 11;
            this.txtRepContraseña.TextChanged += new System.EventHandler(this.txtRepContraseña_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(495, 241);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.Location = new System.Drawing.Point(495, 289);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 22);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.Location = new System.Drawing.Point(495, 342);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(205, 22);
            this.txtCorreo.TabIndex = 14;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Location = new System.Drawing.Point(495, 396);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(205, 22);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblDatosEmpresario
            // 
            this.lblDatosEmpresario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatosEmpresario.AutoSize = true;
            this.lblDatosEmpresario.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEmpresario.Location = new System.Drawing.Point(379, 178);
            this.lblDatosEmpresario.Name = "lblDatosEmpresario";
            this.lblDatosEmpresario.Size = new System.Drawing.Size(186, 23);
            this.lblDatosEmpresario.TabIndex = 21;
            this.lblDatosEmpresario.Text = "DATOS DE CLIENTE:";
            this.lblDatosEmpresario.Click += new System.EventHandler(this.lblDatosEmpresario_Click);
            // 
            // lblCP
            // 
            this.lblCP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(358, 479);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(131, 23);
            this.lblCP.TabIndex = 22;
            this.lblCP.Text = "Código Postal:";
            this.lblCP.Click += new System.EventHandler(this.lblCP_Click);
            // 
            // mskCP
            // 
            this.mskCP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskCP.Location = new System.Drawing.Point(495, 479);
            this.mskCP.Mask = "00000";
            this.mskCP.Name = "mskCP";
            this.mskCP.Size = new System.Drawing.Size(39, 22);
            this.mskCP.TabIndex = 24;
            this.mskCP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCP_MaskInputRejected);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDireccion.Location = new System.Drawing.Point(495, 519);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 22);
            this.txtDireccion.TabIndex = 26;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(395, 518);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(94, 23);
            this.lblDireccion.TabIndex = 25;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(495, 204);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 22);
            this.txtUsuario.TabIndex = 41;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(406, 204);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 23);
            this.lblUsuario.TabIndex = 42;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(495, 599);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(190, 43);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // openFileDialogElegirImagen
            // 
            this.openFileDialogElegirImagen.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...\"";
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
            this.pnlAjustes.Location = new System.Drawing.Point(1151, 106);
            this.pnlAjustes.Name = "pnlAjustes";
            this.pnlAjustes.Size = new System.Drawing.Size(174, 176);
            this.pnlAjustes.TabIndex = 47;
            this.pnlAjustes.Visible = false;
            this.pnlAjustes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblModoNoche
            // 
            this.lblModoNoche.AutoSize = true;
            this.lblModoNoche.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoNoche.Location = new System.Drawing.Point(7, 113);
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
            "Inglés"});
            this.cmbIdioma.Location = new System.Drawing.Point(57, 54);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(96, 26);
            this.cmbIdioma.TabIndex = 19;
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = global::Localmarket_App.Properties.Resources.flechaatras;
            this.picAtras.Location = new System.Drawing.Point(58, 134);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(49, 50);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 45;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // picAñadeFoto
            // 
            this.picAñadeFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAñadeFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAñadeFoto.Image = ((System.Drawing.Image)(resources.GetObject("picAñadeFoto.Image")));
            this.picAñadeFoto.Location = new System.Drawing.Point(154, 188);
            this.picAñadeFoto.Name = "picAñadeFoto";
            this.picAñadeFoto.Size = new System.Drawing.Size(156, 151);
            this.picAñadeFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAñadeFoto.TabIndex = 1;
            this.picAñadeFoto.TabStop = false;
            this.picAñadeFoto.Click += new System.EventHandler(this.picAñadeFoto_Click);
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.pnlAjustes);
            this.Controls.Add(this.picAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.mskCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblDatosEmpresario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRepContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRepContraseña);
            this.Controls.Add(this.picAñadeFoto);
            this.Controls.Add(this.pnlRegistroComo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.pnlRegistroComo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlAjustes.ResumeLayout(false);
            this.pnlAjustes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAñadeFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistroComo;
        private System.Windows.Forms.PictureBox picAjustes;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picAñadeFoto;
        private System.Windows.Forms.Label lblRepContraseña;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtRepContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblDatosEmpresario;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.MaskedTextBox mskCP;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.OpenFileDialog openFileDialogElegirImagen;
        private System.Windows.Forms.Panel pnlAjustes;
        private System.Windows.Forms.Label lblModoNoche;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.PictureBox picNocheOn;
        private System.Windows.Forms.PictureBox picNocheOff;
        private System.Windows.Forms.PictureBox picIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
    }
}