
namespace Localmarket_App
{
    partial class FrmRegistroEmpresa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEmpresa));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pnlNaranja = new System.Windows.Forms.Panel();
            this.picAjustes = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picAñadeFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialogElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.pnlAjustes = new System.Windows.Forms.Panel();
            this.lblModoNoche = new System.Windows.Forms.Label();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.picNocheOn = new System.Windows.Forms.PictureBox();
            this.picNocheOff = new System.Windows.Forms.PictureBox();
            this.picIdioma = new System.Windows.Forms.PictureBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblDatosNegocio = new System.Windows.Forms.Label();
            this.lblDireccionNeg = new System.Windows.Forms.Label();
            this.lblTlfNeg = new System.Windows.Forms.Label();
            this.mskCPNeg = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreNeg = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCIFNeg = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtTlfNeg = new System.Windows.Forms.TextBox();
            this.txtDireccionNeg = new System.Windows.Forms.TextBox();
            this.txtNombreNeg = new System.Windows.Forms.TextBox();
            this.txtCIFNeg = new System.Windows.Forms.TextBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCp = new System.Windows.Forms.Label();
            this.pnlNaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAñadeFoto)).BeginInit();
            this.pnlAjustes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(381, 428);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(142, 35);
            this.btnRegistrar.TabIndex = 66;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pnlNaranja
            // 
            this.pnlNaranja.BackColor = System.Drawing.Color.Orange;
            this.pnlNaranja.Controls.Add(this.picAjustes);
            this.pnlNaranja.Controls.Add(this.picLogo);
            this.pnlNaranja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNaranja.Location = new System.Drawing.Point(0, 0);
            this.pnlNaranja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNaranja.Name = "pnlNaranja";
            this.pnlNaranja.Size = new System.Drawing.Size(999, 81);
            this.pnlNaranja.TabIndex = 46;
            // 
            // picAjustes
            // 
            this.picAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAjustes.Image = global::Localmarket_App.Properties.Resources.icono_ajustes;
            this.picAjustes.Location = new System.Drawing.Point(938, 15);
            this.picAjustes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAjustes.Name = "picAjustes";
            this.picAjustes.Size = new System.Drawing.Size(43, 46);
            this.picAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAjustes.TabIndex = 2;
            this.picAjustes.TabStop = false;
            this.picAjustes.Click += new System.EventHandler(this.picAjustes_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(23, 10);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(56, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = global::Localmarket_App.Properties.Resources.flechaatras;
            this.picAtras.Location = new System.Drawing.Point(9, 122);
            this.picAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(37, 41);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 67;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // picAñadeFoto
            // 
            this.picAñadeFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAñadeFoto.Image = ((System.Drawing.Image)(resources.GetObject("picAñadeFoto.Image")));
            this.picAñadeFoto.Location = new System.Drawing.Point(81, 166);
            this.picAñadeFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAñadeFoto.Name = "picAñadeFoto";
            this.picAñadeFoto.Size = new System.Drawing.Size(117, 123);
            this.picAñadeFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAñadeFoto.TabIndex = 47;
            this.picAñadeFoto.TabStop = false;
            this.picAñadeFoto.Click += new System.EventHandler(this.picAñadeFoto_Click);
            // 
            // openFileDialogElegirImagen
            // 
            this.openFileDialogElegirImagen.FileName = "openFileDialog1";
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
            this.pnlAjustes.Location = new System.Drawing.Point(863, 84);
            this.pnlAjustes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAjustes.Name = "pnlAjustes";
            this.pnlAjustes.Size = new System.Drawing.Size(131, 143);
            this.pnlAjustes.TabIndex = 68;
            this.pnlAjustes.Visible = false;
            // 
            // lblModoNoche
            // 
            this.lblModoNoche.AutoSize = true;
            this.lblModoNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoNoche.Location = new System.Drawing.Point(-2, 92);
            this.lblModoNoche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModoNoche.Name = "lblModoNoche";
            this.lblModoNoche.Size = new System.Drawing.Size(98, 17);
            this.lblModoNoche.TabIndex = 23;
            this.lblModoNoche.Text = "Modo Noche";
            // 
            // lblAjustes
            // 
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustes.Location = new System.Drawing.Point(38, 10);
            this.lblAjustes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(61, 17);
            this.lblAjustes.TabIndex = 12;
            this.lblAjustes.Text = "Ajustes";
            // 
            // picNocheOn
            // 
            this.picNocheOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNocheOn.Image = global::Localmarket_App.Properties.Resources.on;
            this.picNocheOn.Location = new System.Drawing.Point(93, 81);
            this.picNocheOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picNocheOn.Name = "picNocheOn";
            this.picNocheOn.Size = new System.Drawing.Size(34, 37);
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
            this.picNocheOff.Location = new System.Drawing.Point(93, 76);
            this.picNocheOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picNocheOff.Name = "picNocheOff";
            this.picNocheOff.Size = new System.Drawing.Size(34, 46);
            this.picNocheOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNocheOff.TabIndex = 21;
            this.picNocheOff.TabStop = false;
            this.picNocheOff.Click += new System.EventHandler(this.picNocheOff_Click);
            // 
            // picIdioma
            // 
            this.picIdioma.Image = global::Localmarket_App.Properties.Resources.idioma;
            this.picIdioma.Location = new System.Drawing.Point(5, 39);
            this.picIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picIdioma.Name = "picIdioma";
            this.picIdioma.Size = new System.Drawing.Size(30, 32);
            this.picIdioma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIdioma.TabIndex = 20;
            this.picIdioma.TabStop = false;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Inglés"});
            this.cmbIdioma.Location = new System.Drawing.Point(43, 44);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(73, 23);
            this.cmbIdioma.TabIndex = 19;
            // 
            // lblDatosNegocio
            // 
            this.lblDatosNegocio.AutoSize = true;
            this.lblDatosNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNegocio.Location = new System.Drawing.Point(334, 166);
            this.lblDatosNegocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosNegocio.Name = "lblDatosNegocio";
            this.lblDatosNegocio.Size = new System.Drawing.Size(189, 18);
            this.lblDatosNegocio.TabIndex = 78;
            this.lblDatosNegocio.Text = "DATOS DEL NEGOCIO:";
            // 
            // lblDireccionNeg
            // 
            this.lblDireccionNeg.AutoSize = true;
            this.lblDireccionNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionNeg.Location = new System.Drawing.Point(330, 312);
            this.lblDireccionNeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionNeg.Name = "lblDireccionNeg";
            this.lblDireccionNeg.Size = new System.Drawing.Size(75, 18);
            this.lblDireccionNeg.TabIndex = 69;
            this.lblDireccionNeg.Text = "Dirección:";
            // 
            // lblTlfNeg
            // 
            this.lblTlfNeg.AutoSize = true;
            this.lblTlfNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlfNeg.Location = new System.Drawing.Point(334, 345);
            this.lblTlfNeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTlfNeg.Name = "lblTlfNeg";
            this.lblTlfNeg.Size = new System.Drawing.Size(70, 18);
            this.lblTlfNeg.TabIndex = 70;
            this.lblTlfNeg.Text = "Teléfono:";
            // 
            // mskCPNeg
            // 
            this.mskCPNeg.Location = new System.Drawing.Point(406, 270);
            this.mskCPNeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCPNeg.Mask = "00000";
            this.mskCPNeg.Name = "mskCPNeg";
            this.mskCPNeg.Size = new System.Drawing.Size(30, 20);
            this.mskCPNeg.TabIndex = 81;
            // 
            // lblNombreNeg
            // 
            this.lblNombreNeg.AutoSize = true;
            this.lblNombreNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNeg.Location = new System.Drawing.Point(339, 188);
            this.lblNombreNeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNeg.Name = "lblNombreNeg";
            this.lblNombreNeg.Size = new System.Drawing.Size(66, 18);
            this.lblNombreNeg.TabIndex = 71;
            this.lblNombreNeg.Text = "Nombre:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(406, 379);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(154, 21);
            this.cmbCategoria.TabIndex = 80;
            // 
            // lblCIFNeg
            // 
            this.lblCIFNeg.AutoSize = true;
            this.lblCIFNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIFNeg.Location = new System.Drawing.Point(368, 227);
            this.lblCIFNeg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCIFNeg.Name = "lblCIFNeg";
            this.lblCIFNeg.Size = new System.Drawing.Size(35, 18);
            this.lblCIFNeg.TabIndex = 72;
            this.lblCIFNeg.Text = "CIF:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(328, 379);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 79;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtTlfNeg
            // 
            this.txtTlfNeg.Location = new System.Drawing.Point(405, 345);
            this.txtTlfNeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTlfNeg.Name = "txtTlfNeg";
            this.txtTlfNeg.Size = new System.Drawing.Size(155, 20);
            this.txtTlfNeg.TabIndex = 74;
            // 
            // txtDireccionNeg
            // 
            this.txtDireccionNeg.Location = new System.Drawing.Point(405, 313);
            this.txtDireccionNeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccionNeg.Name = "txtDireccionNeg";
            this.txtDireccionNeg.Size = new System.Drawing.Size(155, 20);
            this.txtDireccionNeg.TabIndex = 77;
            // 
            // txtNombreNeg
            // 
            this.txtNombreNeg.Location = new System.Drawing.Point(406, 187);
            this.txtNombreNeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNeg.Name = "txtNombreNeg";
            this.txtNombreNeg.Size = new System.Drawing.Size(155, 20);
            this.txtNombreNeg.TabIndex = 75;
            // 
            // txtCIFNeg
            // 
            this.txtCIFNeg.Location = new System.Drawing.Point(406, 227);
            this.txtCIFNeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCIFNeg.Name = "txtCIFNeg";
            this.txtCIFNeg.Size = new System.Drawing.Size(155, 20);
            this.txtCIFNeg.TabIndex = 76;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.Location = new System.Drawing.Point(296, 272);
            this.lblCp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(106, 18);
            this.lblCp.TabIndex = 82;
            this.lblCp.Text = "Codigo Postal:";
            // 
            // FrmRegistroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblDatosNegocio);
            this.Controls.Add(this.lblDireccionNeg);
            this.Controls.Add(this.lblTlfNeg);
            this.Controls.Add(this.mskCPNeg);
            this.Controls.Add(this.lblNombreNeg);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCIFNeg);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtTlfNeg);
            this.Controls.Add(this.txtDireccionNeg);
            this.Controls.Add(this.txtNombreNeg);
            this.Controls.Add(this.txtCIFNeg);
            this.Controls.Add(this.pnlAjustes);
            this.Controls.Add(this.picAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picAñadeFoto);
            this.Controls.Add(this.pnlNaranja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmRegistroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Empresa";
            this.Load += new System.EventHandler(this.FrmRegistroEmpresa_Load);
            this.pnlNaranja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAñadeFoto)).EndInit();
            this.pnlAjustes.ResumeLayout(false);
            this.pnlAjustes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox picAñadeFoto;
        private System.Windows.Forms.Panel pnlNaranja;
        private System.Windows.Forms.PictureBox picAjustes;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialogElegirImagen;
        private System.Windows.Forms.Panel pnlAjustes;
        private System.Windows.Forms.Label lblModoNoche;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.PictureBox picNocheOn;
        private System.Windows.Forms.PictureBox picNocheOff;
        private System.Windows.Forms.PictureBox picIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblDatosNegocio;
        private System.Windows.Forms.Label lblDireccionNeg;
        private System.Windows.Forms.Label lblTlfNeg;
        private System.Windows.Forms.MaskedTextBox mskCPNeg;
        private System.Windows.Forms.Label lblNombreNeg;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCIFNeg;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtTlfNeg;
        private System.Windows.Forms.TextBox txtDireccionNeg;
        private System.Windows.Forms.TextBox txtNombreNeg;
        private System.Windows.Forms.TextBox txtCIFNeg;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Label lblCp;
    }
}