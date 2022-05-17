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
        private bool modoNoche;
        public FrmPaginaComercio(bool modoNoche)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
        }

        private void FrmPaginaComercio_Load(object sender, EventArgs e)
        {
            if (modoNoche)
            {
                modoNocheOn();
            }
            else
            {
                modoNocheOff();
            }
        }

        private void lblUbicacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlNaranja.Focus();
            System.Diagnostics.Process.Start("https://g.page/FloridaUniversitaria?share");
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal(modoNoche);
            frmPrincipal.ShowDialog();
            this.Close();
        }

        private void picFavoritos_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            picCorazon.Visible = true;
            picFavoritos.Visible = false;
        }
        private void picCorazon_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            picCorazon.Visible = false;
            picFavoritos.Visible = true;
        }

        private void picAjustes_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
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
        private void picPerfil_Click_1(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            pnlAjustes.Visible = false;
            if (pnlPerfil.Visible == false)
            {
                pnlPerfil.Visible = true;
            }
            else if (pnlPerfil.Visible == true)
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
            pnlNaranja.Focus();
            modoNocheOn();
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            modoNocheOff();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin(modoNoche);
            frmLog.ShowDialog();
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
            tabReseñasyProductos.BackColor = Color.Black;
            tabReseñas.BackColor = Color.Black;
            tabReseñas.ForeColor = Color.White;
            tabProductos.BackColor = Color.Black;
            tabProductos.ForeColor = Color.White;
            pnlComentario.BackColor = Color.Black;
            pnlNaranja.BackColor = Color.Black;
            pnlReseña.BackColor = Color.Black;
            lblEstrellitas.ForeColor = Color.White;
            lblDescripcion.ForeColor = Color.White;
            lblComentario.ForeColor = Color.White;
            lblProducto.ForeColor = Color.White;
            lblNomUsuario.ForeColor = Color.White;
            pnlAjustes.BackColor = Color.DarkCyan;
            pnlPerfil.BackColor = Color.SeaGreen;
            pnlProductos.ForeColor = Color.White;
            btnEnviarComentario.ForeColor = Color.Black;
            btnEnviarComentario.BackColor = Color.DarkCyan;
            picAjustes.Image = Resources.ajustesicono;
            picAtras.Image = Resources.flechaatrasblanca;
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
            tabReseñasyProductos.BackColor = Color.White;
            tabReseñas.BackColor = Color.White;
            tabReseñas.ForeColor = Color.Black;
            tabProductos.BackColor = Color.White;
            tabProductos.ForeColor = Color.Black;
            pnlComentario.BackColor = Color.White;
            pnlNaranja.BackColor = Color.Orange;
            pnlReseña.BackColor = Color.White;
            lblEstrellitas.ForeColor = Color.Black;
            lblDescripcion.ForeColor = Color.Black;
            lblComentario.ForeColor = Color.Black;
            lblProducto.ForeColor = Color.Black;
            lblNomUsuario.ForeColor = Color.Black;
            pnlAjustes.BackColor = Color.Aqua;
            pnlPerfil.BackColor = Color.PaleGreen;
            pnlProductos.ForeColor = Color.White;
            btnEnviarComentario.ForeColor = Color.Black;
            btnEnviarComentario.BackColor = Color.Aqua;
            picAjustes.Image = Resources.icono_ajustes;
            picAtras.Image = Resources.flechaatras;
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
