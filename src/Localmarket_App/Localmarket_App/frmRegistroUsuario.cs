using Localmarket_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localmarket_App
{
    public partial class FrmRegistroUsuario : Form
    {
        private bool modoNoche;
        private Usuario usuarioGlobal;
        private string idioma;

        public FrmRegistroUsuario(bool modoNoche, string idioma)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
            this.idioma = idioma;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            if (modoNoche)
            {
                modoNocheOn();
            }
            else
            {
                modoNocheOff();
            }
            cmbIdioma.Text = idioma;
            AplicarIdioma();
        }

        public void picAjustes_Click(object sender, EventArgs e)
        {
            if (pnlAjustes.Visible == false)
            {
                pnlAjustes.Visible = true;
            }
            else if (pnlAjustes.Visible == true)
            {
                pnlAjustes.Visible = false;
            }
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLog = new FrmLogin(modoNoche, idioma);
            frmLog.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                usuarioGlobal = new Usuario(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtContraseña.Text, 
                    Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, txtDireccion.Text, Convert.ToInt32(mskCP.Text), 
                    picAñadeFoto.Image, "client", null);

                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    Usuario.InsertarUsuario(usuarioGlobal);
                    ConexionBD.CerrarConexion();
                }

                this.Hide();
                FrmLogin frmLogin = new FrmLogin(modoNoche, idioma);
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private bool ComprobarDatos()
        {
            bool correcto = true;
            errorProv.Clear();
            if (txtUsuario.Text == "")
            {
                errorProv.SetError(txtUsuario, "Introduce un nombre de usuario");
            }

            if (txtNombre.Text == "")
            {
                errorProv.SetError(txtNombre, "Introduce tu nombre");
                correcto = false;
            }

            if (txtApellido.Text == "")
            {
                errorProv.SetError(txtApellido, "Introduce tus apellidos");
                correcto = false;
            }

            if (txtCorreo.Text == "")
            {
                errorProv.SetError(txtCorreo, "Introduce tu email");
                correcto = false;
            }

            if (txtContraseña.Text == "")
            {
                errorProv.SetError(txtContraseña, "Introduce una contraseña");
                correcto = false;
            }

            if (txtRepContraseña.Text == "")
            {
                errorProv.SetError(txtContraseña, "Introduce tu contraseña otra vez");
                correcto = false;
            }

            if (mskCP.Text == "")
            {
                errorProv.SetError(mskCP, "Introduce tu codigo postal");
                correcto = false;
            }

            if (txtDireccion.Text == "")
            {
                errorProv.SetError(txtDireccion, "Introduce tu direccion");
                correcto = false;
            }

            if (txtTelefono.Text == "")
            {
                errorProv.SetError(txtTelefono, "Introduce un telefono de contacto");
                correcto = false;
            }

            if (txtRepContraseña.Text != txtContraseña.Text)
            {
                errorProv.SetError(txtRepContraseña, "Introduce la misma contraseña");
                correcto = false;
            }

            return correcto;
        }

        private void picAñadeFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogElegirImagen.ShowDialog() == DialogResult.OK)
            {
                picAñadeFoto.Image = new Bitmap(openFileDialogElegirImagen.FileName);
            }
        }

        private void picNocheOff_Click(object sender, EventArgs e)
        {
            modoNocheOn();
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            modoNocheOff();
        }

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            pnlNaranja.BackColor = Color.Black;
            picAjustes.Image = Resources.ajustesicono;
            picAtras.Image = Resources.flechaatrasblanca;
            this.BackColor = Color.DimGray;

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.White;
            }
        }

        private void modoNocheOff()
        {
            picNocheOff.Visible = true;
            picNocheOn.Visible = false;
            modoNoche = false;
            pnlNaranja.BackColor = Color.Orange;
            picAjustes.Image = Resources.icono_ajustes;
            picAtras.Image = Resources.flechaatras;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Black;
            }
        }

        private void AplicarIdioma()
        {
            if (cmbIdioma.Text == "English")
            {
                lblAjustes.Text = MultiIdiomas.FrmRegistroUsuarioIng.Settings;
                lblApellidos.Text = MultiIdiomas.FrmRegistroUsuarioIng.Surnames;
                lblContraseña.Text = MultiIdiomas.FrmRegistroUsuarioIng.pswrd;
                lblCorreo.Text = MultiIdiomas.FrmRegistroUsuarioIng.email;
                lblCP.Text = MultiIdiomas.FrmRegistroUsuarioIng.PostalCode;
                lblDatosEmpresario.Text = MultiIdiomas.FrmRegistroUsuarioIng.UserData;
                lblDireccion.Text = MultiIdiomas.FrmRegistroUsuarioIng.Addres;
                lblModoNoche.Text = MultiIdiomas.FrmRegistroUsuarioIng.DarkMode;
                lblNombre.Text = MultiIdiomas.FrmRegistroUsuarioIng.Name;
                lblRepContraseña.Text = MultiIdiomas.FrmRegistroUsuarioIng.repeatPassword;
                lblTelefono.Text = MultiIdiomas.FrmRegistroUsuarioIng.Phone;
                lblUsuario.Text = MultiIdiomas.FrmRegistroUsuarioIng.User;
                btnRegistrar.Text = MultiIdiomas.FrmRegistroUsuarioIng.Register;
                this.Text = MultiIdiomas.FrmRegistroUsuarioIng.UserRegister;
            }
            else if (cmbIdioma.Text == "Español")
            {
                lblAjustes.Text = MultiIdiomas.FrmRegistroUsuarioEsp.Settings;
                lblApellidos.Text = MultiIdiomas.FrmRegistroUsuarioEsp.Surnames;
                lblContraseña.Text = MultiIdiomas.FrmRegistroUsuarioEsp.pswrd;
                lblCorreo.Text = MultiIdiomas.FrmRegistroUsuarioEsp.email;
                lblCP.Text = MultiIdiomas.FrmRegistroUsuarioEsp.PostalCode;
                lblDatosEmpresario.Text = MultiIdiomas.FrmRegistroUsuarioEsp.UserData;
                lblDireccion.Text = MultiIdiomas.FrmRegistroUsuarioEsp.Addres;
                lblModoNoche.Text = MultiIdiomas.FrmRegistroUsuarioEsp.DarkMode;
                lblNombre.Text = MultiIdiomas.FrmRegistroUsuarioEsp.Name;
                lblRepContraseña.Text = MultiIdiomas.FrmRegistroUsuarioEsp.repeatPassword;
                lblTelefono.Text = MultiIdiomas.FrmRegistroUsuarioEsp.Phone;
                lblUsuario.Text = MultiIdiomas.FrmRegistroUsuarioEsp.User;
                btnRegistrar.Text = MultiIdiomas.FrmRegistroUsuarioEsp.Register;
                this.Text = MultiIdiomas.FrmRegistroUsuarioEsp.UserRegister;
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarIdioma();
        }
    }
}
