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
        public FrmRegistroUsuario(bool modoNoche)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
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
            FrmLogin frmLog = new FrmLogin(modoNoche);
            frmLog.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ComprobarDatos())
            {
                usuarioGlobal = new Usuario(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtContraseña.Text, 
                    Convert.ToInt32(txtTelefono.Text), txtCorreo.Text, txtDireccion.Text, Convert.ToInt32(mskCP.Text), 
                    picAñadeFoto.Image, "client", null, null, -1);

                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    Usuario.InsertarUsuario(usuarioGlobal);
                    ConexionBD.CerrarConexion();
                }

                this.Hide();
                FrmLogin frmLogin = new FrmLogin(modoNoche);
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
    }
}
