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
    public partial class FrmRegistroEmpresa : Form
    {

        private bool modoNoche;
        public FrmRegistroEmpresa(bool modoNoche)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmPrin = new FrmPrincipal(modoNoche, null);
            frmPrin.ShowDialog();
            this.Close();
        }

        private void picAñadeFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogElegirImagen.ShowDialog() == DialogResult.OK)
            {
                picAñadeFoto.Image = new Bitmap(openFileDialogElegirImagen.FileName);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {

            }
        }

        private bool ComprobarDatos()
        {
            bool correcto = true;
            errorProv.Clear();

            if (txtNombreNeg.Text == "")
            {
                errorProv.SetError(txtNombreNeg, "Introduce el nombre de tu negocio");
                correcto = false;
            }

            if (txtCIFNeg.Text == "")
            {
                errorProv.SetError(txtCIFNeg, "Introduce el CIF de tu negocio");
                correcto = false;
            }

            if (mskCPNeg.Text == "")
            {
                errorProv.SetError(mskCPNeg, "Introduce el codigo postal de tu negocio");
                correcto = false;
            }

            if (txtDireccionNeg.Text == "")
            {
                errorProv.SetError(txtDireccionNeg, "Introduce la direccion de tu negocio");
                correcto = false;
            }

            if (txtTlfNeg.Text == "")
            {
                errorProv.SetError(txtTlfNeg, "Introduce el telefono de tu negocio");
                correcto = false;
            }

            if (cmbCategoria.Text == "")
            {
                errorProv.SetError(cmbCategoria, "Introduce la categoria de tu negocio");
                correcto = false;
            }

            return correcto;
        }

        private void picAjustes_Click(object sender, EventArgs e)
        {
            if (pnlAjustes.Visible == false)
            {
                pnlAjustes.Visible = true;
            }
            else if (pnlAjustes.Visible == true)
            {
                pnlAjustes.Visible = false;
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

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            pnlNaranja.BackColor = Color.Black;
            picAjustes.Image = Resources.ajustesicono;
            picAtras.Image = Resources.flechaatrasblanca;
            this.BackColor = Color.DimGray;

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
            picAjustes.Image = Resources.icono_ajustes;
            picAtras.Image = Resources.flechaatras;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Black;
            }
        }

        private void FrmRegistroEmpresa_Load(object sender, EventArgs e)
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
    }
}
