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
        public FrmPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
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
            FrmPaginaComercio frmPagCom = new FrmPaginaComercio();
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
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
           

        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin();
            frmLog.ShowDialog();
            this.Close();
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
            FrmRegistroEmpresa frmRegEmp = new FrmRegistroEmpresa();
            frmRegEmp.ShowDialog();
            this.Close();
        }

        private void picNocheOff_Click(object sender, EventArgs e)
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            picNocheOff.Visible = true;
            picNocheOn.Visible = false;
        }
    }
}
