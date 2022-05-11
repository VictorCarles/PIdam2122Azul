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
            picAtras.Visible = false;
        }

        private void btnEmpresario_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
            picAtras.Visible = true;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            grpBoxDatosNegocio.Visible = false;
            lblDatosEmpresario.Visible = false;
            picAtras.Visible = true;
        }

        public void picAjustes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAjustes frmAj = new FrmAjustes();
            frmAj.ShowDialog();
            this.Close();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin();
            frmLog.ShowDialog();
            this.Close();
        }
    }
}
