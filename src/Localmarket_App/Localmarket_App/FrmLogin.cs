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
        private bool modoNoche;
        public FrmLogin(bool modoNoche)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            picNombre.Visible = false;
            pnlDatosUsuario.Visible = true;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistroUsuario frmReg = new FrmRegistroUsuario(modoNoche);
            frmReg.ShowDialog();
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pnlDatosUsuario.BackColor = Color.FromArgb(200, 238, 240, 161);
            pnlDatosUsuario.Visible = false;
        }

        private void btnIniciarSesion2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Text, txtContraseña.Text);
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                if (usuario.BuscarUsuario())
                {
                    this.Hide();
                    FrmPrincipal frmPrin = new FrmPrincipal(modoNoche);
                    frmPrin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña Incorrectos");
                }
                ConexionBD.CerrarConexion();
            }
        }
    }   
}
