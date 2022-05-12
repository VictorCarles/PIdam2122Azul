
namespace Localmarket_App
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlNaranja = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlListaFav = new System.Windows.Forms.Panel();
            this.lblListaFav = new System.Windows.Forms.Label();
            this.pnlRecientes = new System.Windows.Forms.Panel();
            this.lblRecientes = new System.Windows.Forms.Label();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.pnlCategoriaDesplegable = new System.Windows.Forms.Panel();
            this.lblOcio = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.imgListCarusel = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picCarusel = new System.Windows.Forms.PictureBox();
            this.picFavoritos = new System.Windows.Forms.PictureBox();
            this.picRecientes = new System.Windows.Forms.PictureBox();
            this.picSideMenu = new System.Windows.Forms.PictureBox();
            this.picAjustes = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNaranja.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlListaFav.SuspendLayout();
            this.pnlRecientes.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            this.pnlCategoriaDesplegable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarusel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNaranja
            // 
            this.pnlNaranja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNaranja.BackColor = System.Drawing.Color.Orange;
            this.pnlNaranja.Controls.Add(this.picBuscar);
            this.pnlNaranja.Controls.Add(this.txtBusqueda);
            this.pnlNaranja.Controls.Add(this.picSideMenu);
            this.pnlNaranja.Controls.Add(this.picAjustes);
            this.pnlNaranja.Controls.Add(this.picPerfil);
            this.pnlNaranja.Controls.Add(this.picLogo);
            this.pnlNaranja.Location = new System.Drawing.Point(0, 0);
            this.pnlNaranja.Name = "pnlNaranja";
            this.pnlNaranja.Size = new System.Drawing.Size(1332, 100);
            this.pnlNaranja.TabIndex = 1;
            // 
            // pnlLateral
            // 
            this.pnlLateral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLateral.AutoScroll = true;
            this.pnlLateral.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlLateral.Controls.Add(this.flowLayoutPanel1);
            this.pnlLateral.Location = new System.Drawing.Point(0, 100);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(233, 603);
            this.pnlLateral.TabIndex = 2;
            this.pnlLateral.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlListaFav);
            this.flowLayoutPanel1.Controls.Add(this.pnlRecientes);
            this.flowLayoutPanel1.Controls.Add(this.pnlCategorias);
            this.flowLayoutPanel1.Controls.Add(this.pnlCategoriaDesplegable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 571);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pnlListaFav
            // 
            this.pnlListaFav.Controls.Add(this.picFavoritos);
            this.pnlListaFav.Controls.Add(this.lblListaFav);
            this.pnlListaFav.Location = new System.Drawing.Point(3, 3);
            this.pnlListaFav.Name = "pnlListaFav";
            this.pnlListaFav.Size = new System.Drawing.Size(221, 44);
            this.pnlListaFav.TabIndex = 4;
            // 
            // lblListaFav
            // 
            this.lblListaFav.AutoSize = true;
            this.lblListaFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaFav.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaFav.Location = new System.Drawing.Point(30, 7);
            this.lblListaFav.Name = "lblListaFav";
            this.lblListaFav.Size = new System.Drawing.Size(179, 29);
            this.lblListaFav.TabIndex = 3;
            this.lblListaFav.Text = "Lista Favoritos";
            // 
            // pnlRecientes
            // 
            this.pnlRecientes.Controls.Add(this.picRecientes);
            this.pnlRecientes.Controls.Add(this.lblRecientes);
            this.pnlRecientes.Location = new System.Drawing.Point(3, 53);
            this.pnlRecientes.Name = "pnlRecientes";
            this.pnlRecientes.Size = new System.Drawing.Size(209, 44);
            this.pnlRecientes.TabIndex = 5;
            // 
            // lblRecientes
            // 
            this.lblRecientes.AutoSize = true;
            this.lblRecientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecientes.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecientes.Location = new System.Drawing.Point(30, 7);
            this.lblRecientes.Name = "lblRecientes";
            this.lblRecientes.Size = new System.Drawing.Size(123, 29);
            this.lblRecientes.TabIndex = 4;
            this.lblRecientes.Text = "Recientes";
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.lblCategorias);
            this.pnlCategorias.Location = new System.Drawing.Point(3, 103);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(209, 44);
            this.pnlCategorias.TabIndex = 5;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategorias.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(30, 6);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(180, 29);
            this.lblCategorias.TabIndex = 4;
            this.lblCategorias.Text = "Categorias    +";
            this.lblCategorias.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlCategoriaDesplegable
            // 
            this.pnlCategoriaDesplegable.Controls.Add(this.lblOcio);
            this.pnlCategoriaDesplegable.Controls.Add(this.lblModa);
            this.pnlCategoriaDesplegable.Controls.Add(this.lblAlimentacion);
            this.pnlCategoriaDesplegable.Location = new System.Drawing.Point(3, 153);
            this.pnlCategoriaDesplegable.Name = "pnlCategoriaDesplegable";
            this.pnlCategoriaDesplegable.Size = new System.Drawing.Size(209, 183);
            this.pnlCategoriaDesplegable.TabIndex = 4;
            this.pnlCategoriaDesplegable.Visible = false;
            // 
            // lblOcio
            // 
            this.lblOcio.AutoSize = true;
            this.lblOcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOcio.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcio.Location = new System.Drawing.Point(38, 95);
            this.lblOcio.Name = "lblOcio";
            this.lblOcio.Size = new System.Drawing.Size(62, 29);
            this.lblOcio.TabIndex = 7;
            this.lblOcio.Text = "Ocio";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModa.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.Location = new System.Drawing.Point(38, 53);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(73, 29);
            this.lblModa.TabIndex = 6;
            this.lblModa.Text = "Moda";
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlimentacion.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacion.Location = new System.Drawing.Point(38, 14);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(153, 29);
            this.lblAlimentacion.TabIndex = 5;
            this.lblAlimentacion.Text = "Alimentación";
            // 
            // imgListCarusel
            // 
            this.imgListCarusel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCarusel.ImageStream")));
            this.imgListCarusel.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCarusel.Images.SetKeyName(0, "panadero.jpg");
            this.imgListCarusel.Images.SetKeyName(1, "barbershop.jpg");
            this.imgListCarusel.Images.SetKeyName(2, "tiendaropa.jpg");
            this.imgListCarusel.Images.SetKeyName(3, "fruteria.jpg");
            this.imgListCarusel.Images.SetKeyName(4, "cafeteria.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // picCarusel
            // 
            this.picCarusel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picCarusel.BackColor = System.Drawing.Color.Transparent;
            this.picCarusel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCarusel.Location = new System.Drawing.Point(397, 130);
            this.picCarusel.Name = "picCarusel";
            this.picCarusel.Size = new System.Drawing.Size(529, 316);
            this.picCarusel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarusel.TabIndex = 4;
            this.picCarusel.TabStop = false;
            // 
            // picFavoritos
            // 
            this.picFavoritos.Image = global::Localmarket_App.Properties.Resources.corazon;
            this.picFavoritos.Location = new System.Drawing.Point(-6, 1);
            this.picFavoritos.Name = "picFavoritos";
            this.picFavoritos.Size = new System.Drawing.Size(42, 42);
            this.picFavoritos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFavoritos.TabIndex = 3;
            this.picFavoritos.TabStop = false;
            // 
            // picRecientes
            // 
            this.picRecientes.Image = global::Localmarket_App.Properties.Resources.recientes;
            this.picRecientes.Location = new System.Drawing.Point(1, 5);
            this.picRecientes.Name = "picRecientes";
            this.picRecientes.Size = new System.Drawing.Size(32, 32);
            this.picRecientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecientes.TabIndex = 3;
            this.picRecientes.TabStop = false;
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
            this.picSideMenu.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.picCarusel);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlNaranja);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.pnlNaranja.ResumeLayout(false);
            this.pnlNaranja.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlListaFav.ResumeLayout(false);
            this.pnlListaFav.PerformLayout();
            this.pnlRecientes.ResumeLayout(false);
            this.pnlRecientes.PerformLayout();
            this.pnlCategorias.ResumeLayout(false);
            this.pnlCategorias.PerformLayout();
            this.pnlCategoriaDesplegable.ResumeLayout(false);
            this.pnlCategoriaDesplegable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarusel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNaranja;
        private System.Windows.Forms.PictureBox picAjustes;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlListaFav;
        private System.Windows.Forms.Panel pnlCategoriaDesplegable;
        private System.Windows.Forms.Panel pnlRecientes;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.PictureBox picSideMenu;
        private System.Windows.Forms.Label lblListaFav;
        private System.Windows.Forms.Label lblRecientes;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblOcio;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.PictureBox picRecientes;
        private System.Windows.Forms.PictureBox picFavoritos;
        private System.Windows.Forms.ImageList imgListCarusel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picCarusel;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox picBuscar;
    }
}