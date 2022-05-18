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
    public partial class PanelEmpresa : UserControl
    {
        Empresa empresa;
        private bool modoNoche;
        Usuario usuario;
        public PanelEmpresa()
        {
            InitializeComponent();
        }

        public PanelEmpresa(bool noche, Empresa emp, Usuario usu) : this()
        {
            empresa = emp;
            usuario = usu;
            modoNoche = noche;
            picComercio1.Image = emp.ProfilePicture;
            lblNomComercio.Text = emp.Name;
            lblDescComercio.Text = emp.Description;
            lblValoracion.Text += emp.AvgScore;
        }

        private void lblNomComercio_Click(object sender, EventArgs e)
        {
            FrmPrincipal.ActiveForm.Close();
            FrmPrincipal.ActiveForm.Hide();
            FrmPaginaComercio frmPaginaComercio = new FrmPaginaComercio(modoNoche, empresa, usuario);
            frmPaginaComercio.ShowDialog();
            
        }
    }
}
