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
            pnlLateral.Visible = false;
            lblAlimentacion.Text = "-Alimentacion";
            picCarusel.Visible = false;
            lblTituloCategoria.Visible = true;
            lblTituloCategoria.Text = "Comercios en categoría de Alimentación";
            pnlComercio.Visible = true;
        }

        private void lblNomComercio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPaginaComercio frmPagCom = new FrmPaginaComercio();
            frmPagCom.ShowDialog();
            this.Close();
        }
    }
}
