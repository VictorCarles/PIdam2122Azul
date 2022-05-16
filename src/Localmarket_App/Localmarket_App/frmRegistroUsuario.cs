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
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
         
        }

        public void picAjustes_Click(object sender, EventArgs e)
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

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin();
            frmLog.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin();
            frmLog.ShowDialog();
            this.Close();
        }

        private void picAñadeFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picAñadeFoto.Image = new Bitmap(openFileDialog1.FileName);
            }
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

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void mskCP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCP_Click(object sender, EventArgs e)
        {

        }

        private void lblDatosEmpresario_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRepContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblRepContraseña_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRegistroComo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
