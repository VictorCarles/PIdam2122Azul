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
        public FrmPrincipal(bool modoNoche, Usuario usuario)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
            this.usuario = usuario;
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

            MessageBox.Show(String.Format("El usuario actual es {0}",usuario.Username));
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
            lblAlimentacion.Text = "-Alimentacion";
            lblTituloCategoria.Text = "Comercios en categoría de Alimentación";
        }

        private void lblNomComercio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPaginaComercio frmPagCom = new FrmPaginaComercio(modoNoche);
            frmPagCom.ShowDialog();
            this.Close();
        }

        private void lblModa_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            lblModa.Text = "-Moda";
            lblTituloCategoria.Text = "Comercios en categoría de Moda";
        }

        private void lblOcio_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            lblOcio.Text = "-Ocio";
            lblTituloCategoria.Text = "Comercios en categoría de Ocio";
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            lblTituloCategoria.Text = "Resultados de la búsqueda '" + txtBusqueda.Text+ "':";
        }

        private void limpiarPagina()
        {
            lblNoticias.Visible = false;
            pnlNoticia.Visible = false;
            pnlLateral.Visible = false;
            pnlComercio.Visible = true;
            picCarusel.Visible = false;
            lblTituloCategoria.Visible = true;
            lblAlimentacion.Text = "Alimentacion";
            lblModa.Text = "Moda";
            lblOcio.Text = "Ocio";
        }

        private void lblListaFav_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            lblTituloCategoria.Text = "Lista de favoritos:";
        }

        private void lblRecientes_Click(object sender, EventArgs e)
        {
            limpiarPagina();
            lblTituloCategoria.Text = "Vistos recientemente:";
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
            FrmLogin frmLog = new FrmLogin(modoNoche);
            frmLog.ShowDialog();
            this.Close();
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
            this.Hide();
            FrmRegistroEmpresa frmRegEmp = new FrmRegistroEmpresa(modoNoche);
            frmRegEmp.ShowDialog();
            this.Close();
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
            FrmPerfilUsuario frmPerfUsu = new FrmPerfilUsuario(modoNoche);
            frmPerfUsu.Show();
        }

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            pnlComercio.BackColor = Color.Black;
            pnlNoticia.BackColor = Color.Black;
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
            pnlComercio.BackColor = Color.White;
            pnlNoticia.BackColor = Color.White;
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
    }
}
