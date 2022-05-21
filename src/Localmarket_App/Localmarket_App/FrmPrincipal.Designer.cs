
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
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.picSideMenu = new System.Windows.Forms.PictureBox();
            this.picAjustes = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.picFavoritos = new System.Windows.Forms.PictureBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.picRecientes = new System.Windows.Forms.PictureBox();
            this.lblListaFav = new System.Windows.Forms.Label();
            this.lblRecientes = new System.Windows.Forms.Label();
            this.pnlCategoriaDesplegable = new System.Windows.Forms.Panel();
            this.lblOcio = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.imgListCarusel = new System.Windows.Forms.ImageList(this.components);
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.pnlComercio = new System.Windows.Forms.Panel();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.lblCrearEmpresa = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picPerfil2 = new System.Windows.Forms.PictureBox();
            this.pnlAjustes = new System.Windows.Forms.Panel();
            this.lblModoNoche = new System.Windows.Forms.Label();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.picNocheOn = new System.Windows.Forms.PictureBox();
            this.picNocheOff = new System.Windows.Forms.PictureBox();
            this.picIdioma = new System.Windows.Forms.PictureBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.picCarusel = new System.Windows.Forms.PictureBox();
            this.picLocalMarket = new System.Windows.Forms.PictureBox();
            this.pnlNaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecientes)).BeginInit();
            this.pnlCategoriaDesplegable.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil2)).BeginInit();
            this.pnlAjustes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarusel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocalMarket)).BeginInit();
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
            this.pnlNaranja.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNaranja.Name = "pnlNaranja";
            this.pnlNaranja.Size = new System.Drawing.Size(999, 66);
            this.pnlNaranja.TabIndex = 1;
            // 
            // picBuscar
            // 
            this.picBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBuscar.Image = global::Localmarket_App.Properties.Resources.lupa;
            this.picBuscar.Location = new System.Drawing.Point(670, 24);
            this.picBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(31, 26);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 5;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBusqueda.Location = new System.Drawing.Point(311, 24);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(355, 26);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.Tag = "";
            // 
            // picSideMenu
            // 
            this.picSideMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSideMenu.Image = global::Localmarket_App.Properties.Resources.menuboton;
            this.picSideMenu.Location = new System.Drawing.Point(102, 13);
            this.picSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.picSideMenu.Name = "picSideMenu";
            this.picSideMenu.Size = new System.Drawing.Size(47, 46);
            this.picSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSideMenu.TabIndex = 3;
            this.picSideMenu.TabStop = false;
            this.picSideMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picAjustes
            // 
            this.picAjustes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAjustes.Image = global::Localmarket_App.Properties.Resources.icono_ajustes;
            this.picAjustes.Location = new System.Drawing.Point(938, 10);
            this.picAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.picAjustes.Name = "picAjustes";
            this.picAjustes.Size = new System.Drawing.Size(43, 46);
            this.picAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAjustes.TabIndex = 2;
            this.picAjustes.TabStop = false;
            this.picAjustes.Click += new System.EventHandler(this.picAjustes_Click);
            // 
            // picPerfil
            // 
            this.picPerfil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPerfil.Image = global::Localmarket_App.Properties.Resources.Perfil_Usuario;
            this.picPerfil.Location = new System.Drawing.Point(857, 7);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(52, 52);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil.TabIndex = 1;
            this.picPerfil.TabStop = false;
            this.picPerfil.Click += new System.EventHandler(this.picPerfil_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(26, 6);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(56, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlLateral.Controls.Add(this.picFavoritos);
            this.pnlLateral.Controls.Add(this.lblCategorias);
            this.pnlLateral.Controls.Add(this.picRecientes);
            this.pnlLateral.Controls.Add(this.lblListaFav);
            this.pnlLateral.Controls.Add(this.lblRecientes);
            this.pnlLateral.Controls.Add(this.pnlCategoriaDesplegable);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 66);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(175, 505);
            this.pnlLateral.TabIndex = 2;
            this.pnlLateral.Visible = false;
            // 
            // picFavoritos
            // 
            this.picFavoritos.Image = global::Localmarket_App.Properties.Resources.corazon;
            this.picFavoritos.Location = new System.Drawing.Point(2, 10);
            this.picFavoritos.Margin = new System.Windows.Forms.Padding(2);
            this.picFavoritos.Name = "picFavoritos";
            this.picFavoritos.Size = new System.Drawing.Size(32, 34);
            this.picFavoritos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFavoritos.TabIndex = 3;
            this.picFavoritos.TabStop = false;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(28, 91);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(145, 24);
            this.lblCategorias.TabIndex = 4;
            this.lblCategorias.Text = "Categorias    +";
            this.lblCategorias.Click += new System.EventHandler(this.label3_Click);
            // 
            // picRecientes
            // 
            this.picRecientes.Image = global::Localmarket_App.Properties.Resources.recientes;
            this.picRecientes.Location = new System.Drawing.Point(9, 51);
            this.picRecientes.Margin = new System.Windows.Forms.Padding(2);
            this.picRecientes.Name = "picRecientes";
            this.picRecientes.Size = new System.Drawing.Size(24, 26);
            this.picRecientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecientes.TabIndex = 3;
            this.picRecientes.TabStop = false;
            // 
            // lblListaFav
            // 
            this.lblListaFav.AutoSize = true;
            this.lblListaFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListaFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaFav.Location = new System.Drawing.Point(34, 15);
            this.lblListaFav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaFav.Name = "lblListaFav";
            this.lblListaFav.Size = new System.Drawing.Size(143, 24);
            this.lblListaFav.TabIndex = 3;
            this.lblListaFav.Text = "Lista Favoritos";
            this.lblListaFav.Click += new System.EventHandler(this.lblListaFav_Click);
            // 
            // lblRecientes
            // 
            this.lblRecientes.AutoSize = true;
            this.lblRecientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecientes.Location = new System.Drawing.Point(34, 54);
            this.lblRecientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecientes.Name = "lblRecientes";
            this.lblRecientes.Size = new System.Drawing.Size(103, 24);
            this.lblRecientes.TabIndex = 4;
            this.lblRecientes.Text = "Recientes";
            this.lblRecientes.Click += new System.EventHandler(this.lblRecientes_Click);
            // 
            // pnlCategoriaDesplegable
            // 
            this.pnlCategoriaDesplegable.Controls.Add(this.lblOcio);
            this.pnlCategoriaDesplegable.Controls.Add(this.lblModa);
            this.pnlCategoriaDesplegable.Controls.Add(this.lblAlimentacion);
            this.pnlCategoriaDesplegable.Location = new System.Drawing.Point(6, 126);
            this.pnlCategoriaDesplegable.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCategoriaDesplegable.Name = "pnlCategoriaDesplegable";
            this.pnlCategoriaDesplegable.Size = new System.Drawing.Size(157, 149);
            this.pnlCategoriaDesplegable.TabIndex = 4;
            this.pnlCategoriaDesplegable.Visible = false;
            // 
            // lblOcio
            // 
            this.lblOcio.AutoSize = true;
            this.lblOcio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcio.Location = new System.Drawing.Point(28, 77);
            this.lblOcio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcio.Name = "lblOcio";
            this.lblOcio.Size = new System.Drawing.Size(50, 24);
            this.lblOcio.TabIndex = 7;
            this.lblOcio.Text = "Ocio";
            this.lblOcio.Click += new System.EventHandler(this.lblOcio_Click);
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.Location = new System.Drawing.Point(28, 43);
            this.lblModa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(58, 24);
            this.lblModa.TabIndex = 6;
            this.lblModa.Text = "Moda";
            this.lblModa.Click += new System.EventHandler(this.lblModa_Click);
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlimentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacion.Location = new System.Drawing.Point(28, 11);
            this.lblAlimentacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(119, 24);
            this.lblAlimentacion.TabIndex = 5;
            this.lblAlimentacion.Text = "Alimentación";
            this.lblAlimentacion.Click += new System.EventHandler(this.lblAlimentacion_Click);
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
            // timerSlider
            // 
            this.timerSlider.Interval = 2000;
            this.timerSlider.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(243, 98);
            this.lblTituloCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(198, 26);
            this.lblTituloCategoria.TabIndex = 5;
            this.lblTituloCategoria.Text = "lblTituloCategoria";
            this.lblTituloCategoria.Visible = false;
            // 
            // pnlComercio
            // 
            this.pnlComercio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlComercio.AutoScroll = true;
            this.pnlComercio.BackColor = System.Drawing.Color.Transparent;
            this.pnlComercio.Location = new System.Drawing.Point(227, 139);
            this.pnlComercio.Margin = new System.Windows.Forms.Padding(2);
            this.pnlComercio.Name = "pnlComercio";
            this.pnlComercio.Size = new System.Drawing.Size(559, 417);
            this.pnlComercio.TabIndex = 6;
            this.pnlComercio.Visible = false;
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPerfil.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerfil.Controls.Add(this.lblCerrarSesion);
            this.pnlPerfil.Controls.Add(this.lblCrearEmpresa);
            this.pnlPerfil.Controls.Add(this.lblPerfil);
            this.pnlPerfil.Controls.Add(this.lblUsuario);
            this.pnlPerfil.Controls.Add(this.picPerfil2);
            this.pnlPerfil.Location = new System.Drawing.Point(823, 70);
            this.pnlPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(133, 147);
            this.pnlPerfil.TabIndex = 8;
            this.pnlPerfil.Visible = false;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.Location = new System.Drawing.Point(4, 114);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(106, 17);
            this.lblCerrarSesion.TabIndex = 11;
            this.lblCerrarSesion.Text = "Cerrar sesión";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // lblCrearEmpresa
            // 
            this.lblCrearEmpresa.AutoSize = true;
            this.lblCrearEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCrearEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearEmpresa.Location = new System.Drawing.Point(4, 84);
            this.lblCrearEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearEmpresa.Name = "lblCrearEmpresa";
            this.lblCrearEmpresa.Size = new System.Drawing.Size(116, 17);
            this.lblCrearEmpresa.TabIndex = 10;
            this.lblCrearEmpresa.Text = "Crear Empresa";
            this.lblCrearEmpresa.Click += new System.EventHandler(this.lblCrearEmpresa_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(4, 54);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(130, 17);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil de Usuario";
            this.lblPerfil.Click += new System.EventHandler(this.lblPerfil_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(40, 13);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "usuario";
            // 
            // picPerfil2
            // 
            this.picPerfil2.Image = global::Localmarket_App.Properties.Resources.Perfil_Usuario;
            this.picPerfil2.Location = new System.Drawing.Point(2, 2);
            this.picPerfil2.Margin = new System.Windows.Forms.Padding(2);
            this.picPerfil2.Name = "picPerfil2";
            this.picPerfil2.Size = new System.Drawing.Size(33, 36);
            this.picPerfil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerfil2.TabIndex = 6;
            this.picPerfil2.TabStop = false;
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
            this.pnlAjustes.Location = new System.Drawing.Point(857, 70);
            this.pnlAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAjustes.Name = "pnlAjustes";
            this.pnlAjustes.Size = new System.Drawing.Size(133, 147);
            this.pnlAjustes.TabIndex = 12;
            this.pnlAjustes.Visible = false;
            // 
            // lblModoNoche
            // 
            this.lblModoNoche.AutoSize = true;
            this.lblModoNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoNoche.Location = new System.Drawing.Point(12, 92);
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
            this.picNocheOn.Location = new System.Drawing.Point(43, 111);
            this.picNocheOn.Margin = new System.Windows.Forms.Padding(2);
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
            this.picNocheOff.Location = new System.Drawing.Point(43, 106);
            this.picNocheOff.Margin = new System.Windows.Forms.Padding(2);
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
            this.picIdioma.Margin = new System.Windows.Forms.Padding(2);
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
            "English"});
            this.cmbIdioma.Location = new System.Drawing.Point(43, 44);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(73, 23);
            this.cmbIdioma.TabIndex = 19;
            this.cmbIdioma.TextChanged += new System.EventHandler(this.cmbIdioma_TextChanged);
            // 
            // picCarusel
            // 
            this.picCarusel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picCarusel.BackColor = System.Drawing.Color.Transparent;
            this.picCarusel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCarusel.Image = global::Localmarket_App.Properties.Resources.fruteria;
            this.picCarusel.Location = new System.Drawing.Point(302, 105);
            this.picCarusel.Margin = new System.Windows.Forms.Padding(2);
            this.picCarusel.Name = "picCarusel";
            this.picCarusel.Size = new System.Drawing.Size(398, 258);
            this.picCarusel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarusel.TabIndex = 4;
            this.picCarusel.TabStop = false;
            // 
            // picLocalMarket
            // 
            this.picLocalMarket.Image = global::Localmarket_App.Properties.Resources.Nombre_App;
            this.picLocalMarket.Location = new System.Drawing.Point(194, 396);
            this.picLocalMarket.Margin = new System.Windows.Forms.Padding(2);
            this.picLocalMarket.Name = "picLocalMarket";
            this.picLocalMarket.Size = new System.Drawing.Size(655, 150);
            this.picLocalMarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocalMarket.TabIndex = 13;
            this.picLocalMarket.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.picLocalMarket);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.picCarusel);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlAjustes);
            this.Controls.Add(this.pnlNaranja);
            this.Controls.Add(this.pnlComercio);
            this.Controls.Add(this.pnlPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlNaranja.ResumeLayout(false);
            this.pnlNaranja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecientes)).EndInit();
            this.pnlCategoriaDesplegable.ResumeLayout(false);
            this.pnlCategoriaDesplegable.PerformLayout();
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil2)).EndInit();
            this.pnlAjustes.ResumeLayout(false);
            this.pnlAjustes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNocheOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarusel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocalMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNaranja;
        private System.Windows.Forms.PictureBox picAjustes;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.PictureBox picSideMenu;
        private System.Windows.Forms.ImageList imgListCarusel;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.PictureBox picCarusel;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Panel pnlComercio;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblCrearEmpresa;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picPerfil2;
        private System.Windows.Forms.Panel pnlAjustes;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.PictureBox picIdioma;
        private System.Windows.Forms.PictureBox picNocheOff;
        private System.Windows.Forms.PictureBox picNocheOn;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.Label lblModoNoche;
        private System.Windows.Forms.PictureBox picFavoritos;
        private System.Windows.Forms.Label lblListaFav;
        private System.Windows.Forms.PictureBox picRecientes;
        private System.Windows.Forms.Label lblRecientes;
        private System.Windows.Forms.Panel pnlCategoriaDesplegable;
        private System.Windows.Forms.Label lblOcio;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.PictureBox picLocalMarket;
    }
}