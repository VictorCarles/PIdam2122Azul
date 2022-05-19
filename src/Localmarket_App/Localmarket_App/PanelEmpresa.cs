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
            calculaValoracion(emp.AvgScore);
        }

        private void lblNomComercio_Click(object sender, EventArgs e)
        {
            FrmPrincipal.ActiveForm.Close();
            FrmPrincipal.ActiveForm.Hide();
            FrmPaginaComercio frmPaginaComercio = new FrmPaginaComercio(modoNoche, empresa, usuario);
            frmPaginaComercio.ShowDialog();
            
        }

        private void calculaValoracion(double puntuacion)
        {
            if (puntuacion < 1.5)
            {
                picValoracion.Image = Resources._1estr;
            }
            else if (puntuacion < 2)
            {
                picValoracion.Image = Resources._1_5estr;
            }
            else if (puntuacion < 2.5)
            {
                picValoracion.Image = Resources._2estr;
            }
            else if (puntuacion < 3)
            {
                picValoracion.Image = Resources._2_5estr;
            }
            else if (puntuacion < 3.5)
            {
                picValoracion.Image = Resources._3estr;
            }
            else if (puntuacion < 4)
            {
                picValoracion.Image = Resources._3_5estr;
            }
            else if (puntuacion < 4.5)
            {
                picValoracion.Image = Resources._4estr;
            }
            else if (puntuacion < 5)
            {
                picValoracion.Image = Resources._4_5estr;
            }
            else
            {
                picValoracion.Image = Resources._5estr;
            }
        }
    }
}
