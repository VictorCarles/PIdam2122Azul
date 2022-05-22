using Localmarket_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localmarket_App
{
    public partial class FrmPrincipal : Form
    {
        private bool modoNoche;
        private Usuario usuario;
        private Empresa empresa;
        private string idioma;
        public FrmPrincipal(bool modoNoche, Usuario usuario, Empresa empresa = null, string idioma = null)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
            this.usuario = usuario;
            this.empresa = empresa;
            this.idioma = idioma;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timerSlider.Enabled = true;
            if (modoNoche)
            {
                modoNocheOn();
            }
            else
            {
                modoNocheOff();
            }

            picPerfil.Image = usuario.Imagen;
            picPerfil2.Image = usuario.Imagen;
            lblUsuario.Text = usuario.Username;
            cmbIdioma.Text = idioma;
            AplicarIdioma();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnlLateral.Visible == true)
            {
                pnlLateral.Visible = false;
            }
            else
            {
                pnlLateral.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (pnlCategoriaDesplegable.Visible == true)
            {
                lblCategorias.Text = "Categorias    +";
                pnlCategoriaDesplegable.Visible = false;
            }
            else
            {
                lblCategorias.Text = "Categorias    -";
                pnlCategoriaDesplegable.Visible = true;
            }
        }

        public int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < 5)
            {
                picCarusel.Image = imgListCarusel.Images[i];
                i++;
            } else if (i == 5)
            {
                i = 0;
            }
        }

        private void lblAlimentacion_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            pnlComercio.Controls.Clear();
            if (cmbIdioma.Text == "English")
            {
                lblAlimentacion.Text = "-Nutrition";
                lblModa.Text = "Fashion";
                lblOcio.Text = "Leisure";
                lblTituloCategoria.Text = "Nutrition Businesses:";
            }
            else if (cmbIdioma.Text == "Español")
            {
                lblAlimentacion.Text = "-Alimentación";
                lblModa.Text = "Moda";
                lblOcio.Text = "Ocio";
                lblTituloCategoria.Text = "Comercios en categoría de Alimentación:";
            }

            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                List<Empresa> empresas = Empresa.BusquedaComerciosCategoria("Alimentacion");
                ConexionBD.CerrarConexion();

                if (empresas != null)
                {
                    int x = 0;
                    int y = 0;
                    for (int i = 0; i < empresas.Count; i++)
                    {
                        var control = new PanelEmpresa(modoNoche, empresas[i], usuario, idioma);
                        control.Location = new Point(x, y);
                        pnlComercio.Controls.Add(control);
                        y += control.Height;
                    }
                }
                else
                {
                    MessageBox.Show("Empresas NO encontradas");
                }
            }
        }

        private void lblModa_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            pnlComercio.Controls.Clear();
            if (cmbIdioma.Text == "English")
            {
                lblAlimentacion.Text = "Nutrition";
                lblModa.Text = "-Fashion";
                lblOcio.Text = "Leisure";
                lblTituloCategoria.Text = "Fashion Businesses:";
            }
            else if (cmbIdioma.Text == "Español")
            {
                lblAlimentacion.Text = "Alimentación";
                lblModa.Text = "-Moda";
                lblOcio.Text = "Ocio";
                lblTituloCategoria.Text = "Comercios en categoría de Moda:";
            }

            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                List<Empresa> empresas = Empresa.BusquedaComerciosCategoria("Moda");
                ConexionBD.CerrarConexion();

                if (empresas != null)
                {
                    int x = 0;
                    int y = 0;
                    for (int i = 0; i < empresas.Count; i++)
                    {
                        var control = new PanelEmpresa(modoNoche, empresas[i], usuario, idioma);
                        control.Location = new Point(x, y);
                        pnlComercio.Controls.Add(control);
                        y += control.Height;
                    }
                }
                else
                {
                    MessageBox.Show("Empresas NO encontradas");
                }
            }
        }

        private void lblOcio_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            pnlComercio.Controls.Clear();
            if (cmbIdioma.Text == "English")
            {
                lblAlimentacion.Text = "Nutrition";
                lblModa.Text = "Fashion";
                lblOcio.Text = "-Leisure";
                lblTituloCategoria.Text = "Leisure Businesses:";
            }
            else if (cmbIdioma.Text == "Español")
            {
                lblAlimentacion.Text = "Alimentación";
                lblModa.Text = "Moda";
                lblOcio.Text = "-Ocio";
                lblTituloCategoria.Text = "Comercios en categoría de Ocio:";
            }

            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                List<Empresa> empresas = Empresa.BusquedaComerciosCategoria("Ocio");
                ConexionBD.CerrarConexion();

                if (empresas != null)
                {
                    int x = 0;
                    int y = 0;
                    for (int i = 0; i < empresas.Count; i++)
                    {
                        var control = new PanelEmpresa(modoNoche, empresas[i], usuario, idioma);
                        control.Location = new Point(x, y);
                        pnlComercio.Controls.Add(control);
                        y += control.Height;
                    }
                }
                else
                {
                    MessageBox.Show("Empresas NO encontradas");
                }
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            pnlComercio.Controls.Clear();
            if (cmbIdioma.Text == "English")
            {
                lblTituloCategoria.Text = "Search results for '" + txtBusqueda.Text + "':";
            }
            else if (cmbIdioma.Text == "Español")
            {
                lblTituloCategoria.Text = "Resultados de la búsqueda '" + txtBusqueda.Text + "':";
            }
            
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                List<Empresa> empresas = Empresa.BusquedaComercios(txtBusqueda.Text);
                ConexionBD.CerrarConexion();

                if (empresas != null)
                {
                    int x = 0;
                    int y = 0;
                    for (int i = 0; i < empresas.Count; i++)
                    {
                        var control = new PanelEmpresa(modoNoche, empresas[i], usuario, idioma);
                        control.Location = new Point(x, y);
                        pnlComercio.Controls.Add(control);
                        y += control.Height;
                    }
                }
                else
                {
                    MessageBox.Show("Empresas NO encontradas");
                }
            }

        }

        private void limpiarPagina()
        {
            picLocalMarket.Visible = false;
            pnlLateral.Visible = false;
            pnlComercio.Visible = true;
            picCarusel.Visible = false;
            lblTituloCategoria.Visible = true;

            if (cmbIdioma.Text == "English")
            {
                lblAlimentacion.Text = "Nutrition";
                lblModa.Text = "Fashion";
                lblOcio.Text = "Leisure";
            } else if (cmbIdioma.Text == "Español")
            {
                lblAlimentacion.Text = "Alimentación";
                lblModa.Text = "Moda";
                lblOcio.Text = "Ocio";
            }
        }

        private void lblListaFav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible","Aviso");
            /*limpiarPagina();
            lblTituloCategoria.Text = "Lista de favoritos:";*/
        }

        private void lblRecientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidades no disponibles", "Aviso");
            /*limpiarPagina();
            lblTituloCategoria.Text = "Vistos recientemente:";*/
        }

        private void picAjustes_Click(object sender, EventArgs e)
        {
            pnlPerfil.Visible = false;
            if (pnlAjustes.Visible == false)
            {
                pnlAjustes.Visible = true;
            }
            else if (pnlAjustes.Visible == true)
            {
                pnlAjustes.Visible = false;
            }
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin(modoNoche, idioma);
            frmLog.ShowDialog();
            frmLog.Show();
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {
            pnlAjustes.Visible = false;
            if (pnlPerfil.Visible == false)
            {
                pnlPerfil.Visible = true;
            }else if (pnlPerfil.Visible == true)
            {
                pnlPerfil.Visible = false;
            }
        }

        private void lblCrearEmpresa_Click(object sender, EventArgs e)
        {
            if (lblCrearEmpresa.Text == "Editar empresa" || lblCrearEmpresa.Text == "Edit business")
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    empresa = Empresa.ConseguirEmpresa(usuario);
                    ConexionBD.CerrarConexion();
                }
                this.Hide();
                FrmEditarNegocio frmEditarNegocio = new FrmEditarNegocio(modoNoche,usuario,empresa, idioma);
                frmEditarNegocio.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                FrmRegistroEmpresa frmRegEmp = new FrmRegistroEmpresa(modoNoche, usuario);
                frmRegEmp.ShowDialog();
                this.Close();
            }
        }

        private void picNocheOff_Click(object sender, EventArgs e)
        {
            modoNocheOn();
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            modoNocheOff();
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfilUsuario frmPerfUsu = new FrmPerfilUsuario(modoNoche, usuario, idioma);
            frmPerfUsu.ShowDialog();
            this.Close();
        }

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            pnlNaranja.BackColor = Color.Black;
            pnlLateral.BackColor = Color.Black;
            txtBusqueda.BackColor = Color.DimGray;
            txtBusqueda.ForeColor = Color.White;
            pnlAjustes.BackColor = Color.DarkCyan;
            pnlPerfil.BackColor = Color.SeaGreen;
            lblAlimentacion.ForeColor = Color.White;
            lblOcio.ForeColor = Color.White;
            lblModa.ForeColor = Color.White;
            picAjustes.Image = Resources.ajustesicono;
            picSideMenu.Image = Resources.botonmenublanco;
            picRecientes.Image = Resources.recientesblanco;
            this.BackColor = Color.DimGray;



            foreach (Panel p in Controls.OfType<Panel>())
                foreach (Label l in p.Controls.OfType<Label>())
                {
                    l.ForeColor = Color.White;
                }

            
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.White;
            }
        }

        private void modoNocheOff()
        {
            picNocheOff.Visible = true;
            picNocheOn.Visible = false;
            modoNoche = false;
            pnlNaranja.BackColor = Color.Orange;
            pnlLateral.BackColor = Color.DarkOrange;
            txtBusqueda.BackColor = Color.White;
            txtBusqueda.ForeColor = Color.Black;
            pnlAjustes.BackColor = Color.Aqua;
            pnlPerfil.BackColor = Color.PaleGreen;
            lblAlimentacion.ForeColor = Color.Black;
            lblOcio.ForeColor = Color.Black;
            lblModa.ForeColor = Color.Black;
            picAjustes.Image = Resources.icono_ajustes;
            picSideMenu.Image = Resources.menuboton;
            picRecientes.Image = Resources.recientes;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);

            foreach (Panel p in Controls.OfType<Panel>())
                foreach (Label l in p.Controls.OfType<Label>())
                {
                    l.ForeColor = Color.Black;
                }
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Black;
            }
        }


        private void AplicarIdioma()
        {
            if (cmbIdioma.Text == "English")
            {
                idioma = "English";
                lblAjustes.Text = MultiIdiomas.FrmPrincipalIng.Settings;
                lblAlimentacion.Text = MultiIdiomas.FrmPrincipalIng.Nutrition;
                lblCategorias.Text = MultiIdiomas.FrmPrincipalIng.Categories;
                lblCerrarSesion.Text = MultiIdiomas.FrmPrincipalIng.Logout;
                lblCrearEmpresa.Text = MultiIdiomas.FrmPrincipalIng.CreateBusiness;
                lblListaFav.Text = MultiIdiomas.FrmPrincipalIng.FavList;
                lblModa.Text = MultiIdiomas.FrmPrincipalIng.Fashion;
                lblModoNoche.Text = MultiIdiomas.FrmPrincipalIng.DarkMode;
                lblOcio.Text = MultiIdiomas.FrmPrincipalIng.Leisure;
                lblPerfil.Text = MultiIdiomas.FrmPrincipalIng.UserProfile;
                lblRecientes.Text = MultiIdiomas.FrmPrincipalIng.Recent;
                this.Text = MultiIdiomas.FrmPrincipalIng.MainPage;

                lblTituloCategoria.Text = "Search results:";


                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (Empresa.TieneEmpresa(usuario))
                    {
                        lblCrearEmpresa.Text = "Edit business";
                    }
                    ConexionBD.CerrarConexion();
                }
            }
            else if (cmbIdioma.Text == "Español")
            {
                idioma = "Español";
                lblAjustes.Text = MultiIdiomas.FrmPrincipalEsp.ajustes;
                lblAlimentacion.Text = MultiIdiomas.FrmPrincipalEsp.Alimentacion;
                lblCategorias.Text = MultiIdiomas.FrmPrincipalEsp.Categorias;
                lblCerrarSesion.Text = MultiIdiomas.FrmPrincipalEsp.CerrarSesion;
                lblCrearEmpresa.Text = MultiIdiomas.FrmPrincipalEsp.CrearEmpresa;
                lblListaFav.Text = MultiIdiomas.FrmPrincipalEsp.FavList;
                lblModa.Text = MultiIdiomas.FrmPrincipalEsp.Moda;
                lblModoNoche.Text = MultiIdiomas.FrmPrincipalEsp.ModoNoche;
                lblOcio.Text = MultiIdiomas.FrmPrincipalEsp.Ocio;
                lblPerfil.Text = MultiIdiomas.FrmPrincipalEsp.PerfilUsuario;
                lblRecientes.Text = MultiIdiomas.FrmPrincipalEsp.recents;
                this.Text = MultiIdiomas.FrmPrincipalEsp.PaginaPrincipal;

                lblTituloCategoria.Text = "Resultados de búsqueda:";

                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    if (Empresa.TieneEmpresa(usuario))
                    {
                        lblCrearEmpresa.Text = "Editar empresa";
                    }
                    ConexionBD.CerrarConexion();
                }
            }
        }

        private void cmbIdioma_TextChanged(object sender, EventArgs e)
        {
            AplicarIdioma();
        }
    }
}
