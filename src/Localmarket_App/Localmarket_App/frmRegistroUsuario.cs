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

        private void btnEmpresario_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            grpBoxDatosNegocio.Visible = false;
            lblDatosEmpresario.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAjustes ajustes = new FrmAjustes();
            ajustes.ShowDialog();
        }
    }
}
