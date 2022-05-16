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
    public partial class FrmPerfilUsuario : Form
    {
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPerfil.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void picEditarMail_Click(object sender, EventArgs e)
        {
            txtMail.ReadOnly = false;
        }

        private void picEditarUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = false;
        }

        private void picEditarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.ReadOnly = false;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblRepContraseña.Visible = true;
            txtRepContraseña.Visible = true;
            btnGuardarCambios.Visible = true;
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

        private void picAjustes_Click(object sender, EventArgs e)
        {
           
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
