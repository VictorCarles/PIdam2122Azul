
namespace Localmarket_App
{
    partial class FrmPaginaComercio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaginaComercio));
            this.pnlNaranja = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblNombreComercio = new System.Windows.Forms.Label();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picSideMenu = new System.Windows.Forms.PictureBox();
            this.picAjustes = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDescComercio = new System.Windows.Forms.Label();
            this.pnlNaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNaranja
            // 
            this.pnlNaranja.BackColor = System.Drawing.Color.Orange;
            this.pnlNaranja.Controls.Add(this.picBuscar);
            this.pnlNaranja.Controls.Add(this.txtBusqueda);
            this.pnlNaranja.Controls.Add(this.picSideMenu);
            this.pnlNaranja.Controls.Add(this.picAjustes);
            this.pnlNaranja.Controls.Add(this.picPerfil);
            this.pnlNaranja.Controls.Add(this.picLogo);
            this.pnlNaranja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNaranja.Location = new System.Drawing.Point(0, 0);
            this.pnlNaranja.Name = "pnlNaranja";
            this.pnlNaranja.Size = new System.Drawing.Size(1332, 100);
            this.pnlNaranja.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBusqueda.Location = new System.Drawing.Point(415, 48);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(473, 31);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.Tag = "";
            // 
            // lblNombreComercio
            // 
            this.lblNombreComercio.AutoSize = true;
            this.lblNombreComercio.Font = new System.Drawing.Font("Leelawadee", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComercio.Location = new System.Drawing.Point(510, 230);
            this.lblNombreComercio.Name = "lblNombreComercio";
            this.lblNombreComercio.Size = new System.Drawing.Size(341, 34);
            this.lblNombreComercio.TabIndex = 4;
            this.lblNombreComercio.Text = "NOMBRE DEL COMERCIO";
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracion.Location = new System.Drawing.Point(919, 244);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(93, 20);
            this.lblValoracion.TabIndex = 5;
            this.lblValoracion.Text = "Valoración:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(695, 280);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(119, 20);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.TabStop = true;
            this.lblUbicacion.Text = "Ver Ubicación";
            this.lblUbicacion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUbicacion_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Localmarket_App.Properties.Resources.pinchomapa;
            this.pictureBox2.Location = new System.Drawing.Point(818, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(276, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 119);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBuscar.Image = global::Localmarket_App.Properties.Resources.lupa;
            this.picBuscar.Location = new System.Drawing.Point(894, 49);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(41, 31);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 5;
            this.picBuscar.TabStop = false;
            // 
            // picSideMenu
            // 
            this.picSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSideMenu.Image = global::Localmarket_App.Properties.Resources.menuboton;
            this.picSideMenu.Location = new System.Drawing.Point(136, 19);
            this.picSideMenu.Name = "picSideMenu";
            this.picSideMenu.Size = new System.Drawing.Size(64, 64);
            this.picSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSideMenu.TabIndex = 3;
            this.picSideMenu.TabStop = false;
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
            // 
            // picPerfil
            // 
            this.picPerfil.Image = global::Localmarket_App.Properties.Resources.Perfil_Usuario;
            this.picPerfil.Location = new System.Drawing.Point(1144, 15);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(69, 64);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 1;
            this.picPerfil.TabStop = false;
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
            // lblDescComercio
            // 
            this.lblDescComercio.AutoSize = true;
            this.lblDescComercio.Location = new System.Drawing.Point(412, 517);
            this.lblDescComercio.Name = "lblDescComercio";
            this.lblDescComercio.Size = new System.Drawing.Size(554, 34);
            this.lblDescComercio.TabIndex = 8;
            this.lblDescComercio.Text = "Descripcion Descripcion Descripcion Descripcion DescripcionDescripcion Descripcio" +
    "n \r\nDescripcion Descripcion Descripcion Descripcion Descripcion Descripcion Desc" +
    "ripcion \r\n";
            // 
            // FrmPaginaComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.lblDescComercio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblValoracion);
            this.Controls.Add(this.lblNombreComercio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlNaranja);
            this.Name = "FrmPaginaComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaginaComercio";
            this.pnlNaranja.ResumeLayout(false);
            this.pnlNaranja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNaranja;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox picSideMenu;
        private System.Windows.Forms.PictureBox picAjustes;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreComercio;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.LinkLabel lblUbicacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescComercio;
    }
}