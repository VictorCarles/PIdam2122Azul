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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel1.Visible = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistroUsuario frmReg = new FrmRegistroUsuario();
            frmReg.ShowDialog();
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 238, 240, 161);
            panel1.Visible = false;
        }
    }
}
