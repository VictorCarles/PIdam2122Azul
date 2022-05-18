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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Empresa emp) : this()
        {
            picComercio1.Image = emp.ProfilePicture;
            lblNomComercio.Text = emp.Name;
            lblDescComercio.Text = emp.Description;
            lblValoracion.Text += emp.AvgScore;
        }
    }
}
