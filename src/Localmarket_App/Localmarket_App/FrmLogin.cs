using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localmarket_App
{
    public partial class FrmLogin : Form
    {
        private bool modoNoche;
        private Usuario usuarioGlobal;
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
            cmbIdioma.Text = "Español";

        }

        private void btnIniciarSesion2_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                usuarioGlobal = new Usuario(txtUsuario.Text,txtContraseña.Text);
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    usuarioGlobal = Usuario.ComprobarUsuario(usuarioGlobal);
                    ConexionBD.CerrarConexion();
                }

                if (usuarioGlobal != null)
                {
                    this.Hide();
                    FrmPrincipal frmPrincipal = new FrmPrincipal(modoNoche,usuarioGlobal);
                    frmPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario/contraseña incorrectos");
                }
            }
        }

        private bool ComprobarDatos()
        {
            bool correcto = true;
            errorProv.Clear();

            if (txtUsuario.Text == "")
            {
                errorProv.SetError(txtUsuario, "Introduce tu usuario");
                correcto = false;
            }

            if (txtContraseña.Text == "")
            {
                errorProv.SetError(txtContraseña, "Introduce tu contraseña");
                correcto = false;
            }

            return correcto;
        }

        private void AplicarIdioma()
        {
            if (cmbIdioma.Text == "English")
            {
                btnRegistrarse.Text = MultiIdiomas.FrmLoginIng.btnRegister;
                btnIniciarSesion.Text = MultiIdiomas.FrmLoginIng.btnLogin;
                btnIniciarSesion2.Text = MultiIdiomas.FrmLoginIng.btnLogin2;
                lblUsuario.Text = MultiIdiomas.FrmLoginIng.lblUser;
                lblDatosUsuario.Text = MultiIdiomas.FrmLoginIng.lblUserData;
                lblContraseña.Text = MultiIdiomas.FrmLoginIng.lblPswrd;
                lblOlvidarContraseña.Text = MultiIdiomas.FrmLoginIng.lblForgotMyPswrd;
                chkRecuerdame.Text = MultiIdiomas.FrmLoginIng.chkRememberMe;
            }
            else if (cmbIdioma.Text == "Español")
            {
                btnRegistrarse.Text = MultiIdiomas.FrmLoginEsp.btnRegistro;
                btnIniciarSesion.Text = MultiIdiomas.FrmLoginEsp.btnInicioSesion;
                btnIniciarSesion2.Text = MultiIdiomas.FrmLoginEsp.btnInicioSesion2;
                lblUsuario.Text = MultiIdiomas.FrmLoginEsp.lblUsuario;
                lblDatosUsuario.Text = MultiIdiomas.FrmLoginEsp.lblDatosUsuario;
                lblContraseña.Text = MultiIdiomas.FrmLoginEsp.lblContraseña;
                lblOlvidarContraseña.Text = MultiIdiomas.FrmLoginEsp.lblOlvidarContraseña;
                chkRecuerdame.Text = MultiIdiomas.FrmLoginEsp.chkRecuerdame;
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarIdioma();
        }
    }   
}
