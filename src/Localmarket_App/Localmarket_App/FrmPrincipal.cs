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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                label3.Text = "Categorias       +";
                panel3.Visible = false;
            }
            else
            {
                label3.Text = "Categorias       -";
                panel3.Visible = true;
            }
        }
    }
}
