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
        public FrmRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal frmPrin = new FrmPrincipal();
            frmPrin.ShowDialog();
            this.Close();
        }

        private void picAñadeFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picAñadeFoto.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin();
            frmLog.ShowDialog();
            this.Close();
        }
    }
}
