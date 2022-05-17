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
    public partial class FrmRegistroUsuario : Form
    {
        private bool modoNoche;
        public FrmRegistroUsuario(bool modoNoche)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
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

        public void picAjustes_Click(object sender, EventArgs e)
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

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin(modoNoche);
            frmLog.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin(modoNoche);
            frmLog.ShowDialog();
            this.Close();
        }

        private void picAñadeFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogElegirImagen.ShowDialog() == DialogResult.OK)
            {
                picAñadeFoto.Image = new Bitmap(openFileDialogElegirImagen.FileName);
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
    }
}
