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
    public partial class FrmPaginaComercio : Form
    {
        public FrmPaginaComercio()
        {
            InitializeComponent();
        }

        private void lblUbicacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://g.page/FloridaUniversitaria?share");
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void picEstrella1_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.white_star;
            picEstrella3.Image = Resources.white_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;

        }

        private void picEstrella2_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.white_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
        }

        private void picEstrella3_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.yellow_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
        }

        private void picEstrella4_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.yellow_star;
            picEstrella4.Image = Resources.yellow_star;
            picEstrella5.Image = Resources.white_star;
        }

        private void picEstrella5_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.yellow_star;
            picEstrella4.Image = Resources.yellow_star;
            picEstrella5.Image = Resources.yellow_star;
        }

        private void btnEnviarComentario_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.white_star;
            picEstrella2.Image = Resources.white_star;
            picEstrella3.Image = Resources.white_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
            txtComentario.Text = "";
        }

        private void picFavoritos_Click(object sender, EventArgs e)
        {
            picCorazon.Visible = true;
            picFavoritos.Visible = false;
        }
        private void picCorazon_Click(object sender, EventArgs e)
        {
            picCorazon.Visible = false;
            picFavoritos.Visible = true;
        }

        private void picAjustes_Click(object sender, EventArgs e)
        {
            FrmAjustes frmAjustes = new FrmAjustes();
            frmAjustes.ShowDialog();
        }
    }
}
