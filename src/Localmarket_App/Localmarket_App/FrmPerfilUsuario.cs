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
    public partial class FrmPerfilUsuario : Form
    {
        private bool modoNoche;
        private Usuario usuario;
        public FrmPerfilUsuario(bool modoNoche, Usuario usu)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
            this.usuario = usu;
        }

        private void picPerfil_Click(object sender, EventArgs e)
        {
            if (openFileDialogPerfil.ShowDialog() == DialogResult.OK)
            {
                picPerfil.Image = new Bitmap(openFileDialogPerfil.FileName);
            }
        }

        private void picEditarMail_Click(object sender, EventArgs e)
        {
            txtMail.ReadOnly = false;
        }

        private void picEditarUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = false;
        }

        private void picEditarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.ReadOnly = false;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            btnGuardarCambios.Visible = true;
        }

        private void picNocheOff_Click(object sender, EventArgs e)
        {
            modoNocheOn();
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            modoNocheOff();
        }

        private void picAjustes_Click(object sender, EventArgs e)
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                Usuario.ModificarUsuario(usuario,txtMail.Text,txtUsuario.Text,txtContraseña.Text,picPerfil.Image);
                ConexionBD.CerrarConexion();
            }
            MessageBox.Show("Datos modificados con exito");
            Hide();
            FrmPrincipal frmPrin = new FrmPrincipal(modoNoche,usuario);
            frmPrin.ShowDialog();
            Close();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipal frmPrin = new FrmPrincipal(modoNoche,usuario);
            frmPrin.ShowDialog();
            Close();
        }

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            pnlNaranja.BackColor = Color.Black;
            picAjustes.Image = Resources.ajustesicono;
            picAtras.Image = Resources.flechaatrasblanca;
            btnGuardarCambios.ForeColor = Color.White;
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
            btnGuardarCambios.ForeColor = Color.Black;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Black;
            }
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {
            if (modoNoche)
            {
                modoNocheOn();
            }
            else
            {
                modoNocheOff();
            }

            picPerfil.Image = new Bitmap(usuario.Imagen);
            txtMail.Text = usuario.Email;
            txtContraseña.Text = usuario.Password;
            txtUsuario.Text = usuario.Username;
            cmbIdioma.Text = "Español";

        }

        private void btnElegirLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialogPerfil.ShowDialog() == DialogResult.OK)
            {
                picPerfil.Image = new Bitmap(openFileDialogPerfil.FileName);
            }
        }

        private void AplicarIdioma()
        {
            if (cmbIdioma.Text == "English")
            {
                lblAjustes.Text = MultiIdiomas.FrmPerfilUsuarioIng.Settings;
                lblEmail.Text = MultiIdiomas.FrmPerfilUsuarioIng.email;
                lblContraseña.Text = MultiIdiomas.FrmPerfilUsuarioIng.Password;
                lblModoNoche.Text = MultiIdiomas.FrmPerfilUsuarioIng.DarkMode;
                lblUsuario.Text = MultiIdiomas.FrmPerfilUsuarioIng.User;
                btnGuardarCambios.Text = MultiIdiomas.FrmPerfilUsuarioIng.SaveChanges;
                this.Text = MultiIdiomas.FrmPerfilUsuarioIng.Userprofile;
            }
            else if (cmbIdioma.Text == "Español")
            {
                lblAjustes.Text = MultiIdiomas.FrmPerfilUsuarioEsp.Ajustes;
                lblEmail.Text = MultiIdiomas.FrmPerfilUsuarioEsp.email;
                lblContraseña.Text = MultiIdiomas.FrmPerfilUsuarioEsp.Contraseña;
                lblModoNoche.Text = MultiIdiomas.FrmPerfilUsuarioEsp.Modonoche;
                lblUsuario.Text = MultiIdiomas.FrmPerfilUsuarioEsp.Usuario;
                btnGuardarCambios.Text = MultiIdiomas.FrmPerfilUsuarioEsp.GuardarCambios;
                this.Text = MultiIdiomas.FrmPerfilUsuarioEsp.PerfilUsuario;
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarIdioma();
        }
    }
}
