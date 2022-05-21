﻿using Localmarket_App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Localmarket_App
{
    public partial class FrmPaginaComercio : Form
    {
        private bool modoNoche;
        Empresa empresa;
        Usuario usuario;
        private string idioma;
        int score = 1;
        public FrmPaginaComercio(bool modoNoche, Empresa emp, Usuario usu, string idioma)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;
            empresa = emp;
            usuario = usu;
            this.idioma = idioma;
        }

        private void FrmPaginaComercio_Load(object sender, EventArgs e)
        {
            if (modoNoche)
            {
                modoNocheOn();
            }
            else
            {
                modoNocheOff();
            }

            picEstrella1.Image = Resources.yellow_star;
            lblNombreComercio.Text = empresa.Name;
            picLogoComercio.Image = empresa.ProfilePicture;
            lblDescComercio.Text = empresa.Description;
            picFotoPerfil.Image = usuario.Imagen;
            picPerfil.Image = usuario.Imagen;
            picPerfilUsuario.Image = usuario.Imagen;
            lblUsuario.Text = usuario.Username;
            cmbIdioma.Text = idioma;


            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                if (Empresa.TieneEmpresa(usuario))
                {
                    lblCrearEmpresa.Text = "Editar Empresa";
                }
                CargarComentarios(Comentario.BusquedaComentarios(empresa));
                CargarProductos(Producto.BusquedaProductos(empresa));
                calculaValoracion();
                ConexionBD.CerrarConexion();
            }

        }

        private void CargarComentarios(List<Comentario> comentarios)
        {
            if (comentarios != null)
            {
                int x = 0;
                int y = 0;
                for (int i = 0; i < comentarios.Count; i++)
                {
                    var control = new PanelComentario(modoNoche, comentarios[i], Usuario.ComprobarUsuarioSeg(comentarios[i].Usuario));
                    control.Location = new Point(x, y);
                    panel1.Controls.Add(control);
                    y += control.Height;
                }

            }

        }

        private void CargarProductos(List<Producto> productos)
        {
            if (productos != null)
            {
                int x = 0;
                int y = 0;
                for (int i = 0; i < productos.Count; i++)
                {
                    var control = new PanelProducto(modoNoche, productos[i]);
                    control.Location = new Point(x, y);
                    pnlProductos.Controls.Add(control);
                    y += control.Height;
                }

            }

        }

        private void lblUbicacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlNaranja.Focus();
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + empresa.Address);
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipal frmPrincipal = new FrmPrincipal(modoNoche, usuario);
            frmPrincipal.ShowDialog();
            Close();
        }

        private void picFavoritos_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            picCorazon.Visible = true;
            picFavoritos.Visible = false;
        }
        private void picCorazon_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            picCorazon.Visible = false;
            picFavoritos.Visible = true;
        }

        private void picAjustes_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            pnlPerfil.Visible = false;
            if (pnlAjustes.Visible == false)
            {
                pnlAjustes.Visible = true;
            }
            else if (pnlAjustes.Visible == true)
            {
                pnlAjustes.Visible = false;
            }


        }
        private void picPerfil_Click_1(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            pnlAjustes.Visible = false;
            if (pnlPerfil.Visible == false)
            {
                pnlPerfil.Visible = true;
            }
            else if (pnlPerfil.Visible == true)
            {
                pnlPerfil.Visible = false;
            }
        }

        private void lblCrearEmpresa_Click(object sender, EventArgs e)
        {
            if (lblCrearEmpresa.Text == "Editar Empresa")
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    empresa = Empresa.ConseguirEmpresa(usuario);
                    ConexionBD.CerrarConexion();
                }
                this.Hide();
                FrmEditarNegocio frmEditarNegocio = new FrmEditarNegocio(modoNoche, usuario, empresa, idioma);
                frmEditarNegocio.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                FrmRegistroEmpresa frmRegEmp = new FrmRegistroEmpresa(modoNoche, usuario);
                frmRegEmp.ShowDialog();
                this.Close();
            }
        }

        private void picNocheOff_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            modoNocheOn();
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            pnlNaranja.Focus();
            modoNocheOff();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLog = new FrmLogin(modoNoche, idioma);
            frmLog.ShowDialog();
            Close();
        }

        private void picEstrella1_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.white_star;
            picEstrella3.Image = Resources.white_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
            score = 1;

        }

        private void picEstrella2_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.white_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
            score = 2;
        }

        private void picEstrella3_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.yellow_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
            score = 3;
        }

        private void picEstrella4_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.yellow_star;
            picEstrella4.Image = Resources.yellow_star;
            picEstrella5.Image = Resources.white_star;
            score = 4;
        }

        private void picEstrella5_Click(object sender, EventArgs e)
        {
            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.yellow_star;
            picEstrella3.Image = Resources.yellow_star;
            picEstrella4.Image = Resources.yellow_star;
            picEstrella5.Image = Resources.yellow_star;
            score = 5;
        }

        private void btnEnviarComentario_Click(object sender, EventArgs e)
        {
            Comentario comentario = new Comentario(0, txtComentario.Text, score, empresa.CIFP, usuario.Username, 0, DateTime.Now);
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                Comentario.InsertarComentario(comentario);
                ConexionBD.CerrarConexion();
            }

            picEstrella1.Image = Resources.yellow_star;
            picEstrella2.Image = Resources.white_star;
            picEstrella3.Image = Resources.white_star;
            picEstrella4.Image = Resources.white_star;
            picEstrella5.Image = Resources.white_star;
            txtComentario.Text = "";
            score = 1;
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                CargarComentarios(Comentario.BusquedaComentarios(empresa));
                ConexionBD.CerrarConexion();
            }
            MessageBox.Show("Comentario publicado correctamente");
        }

        private void lblPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfilUsuario frmPerfUsu = new FrmPerfilUsuario(modoNoche, usuario, idioma);
            frmPerfUsu.ShowDialog();
            this.Close();
        }

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            tabReseñasyProductos.BackColor = Color.Black;
            tabReseñas.BackColor = Color.Black;
            tabReseñas.ForeColor = Color.White;
            tabProductos.BackColor = Color.Black;
            tabProductos.ForeColor = Color.White;
            pnlComentario.BackColor = Color.Black;
            pnlNaranja.BackColor = Color.Black;
            pnlAjustes.BackColor = Color.DarkCyan;
            pnlPerfil.BackColor = Color.SeaGreen;
            btnEnviarComentario.ForeColor = Color.Black;
            btnEnviarComentario.BackColor = Color.DarkCyan;
            picAjustes.Image = Resources.ajustesicono;
            picAtras.Image = Resources.flechaatrasblanca;
            BackColor = Color.DimGray;

            foreach (Panel p in Controls.OfType<Panel>())
                foreach (Label l in p.Controls.OfType<Label>())
                {
                    l.ForeColor = Color.White;
                }
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
            tabReseñasyProductos.BackColor = Color.White;
            tabReseñas.BackColor = Color.White;
            tabReseñas.ForeColor = Color.Black;
            tabProductos.BackColor = Color.White;
            tabProductos.ForeColor = Color.Black;
            pnlComentario.BackColor = Color.White;
            pnlNaranja.BackColor = Color.Orange;
            pnlAjustes.BackColor = Color.Aqua;
            pnlPerfil.BackColor = Color.PaleGreen;
            btnEnviarComentario.ForeColor = Color.Black;
            btnEnviarComentario.BackColor = Color.Aqua;
            picAjustes.Image = Resources.icono_ajustes;
            picAtras.Image = Resources.flechaatras;
            BackColor = Color.FromKnownColor(KnownColor.Control);

            foreach (Panel p in Controls.OfType<Panel>())
                foreach (Label l in p.Controls.OfType<Label>())
                {
                    l.ForeColor = Color.Black;
                }
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Black;
            }
        }

        private void calculaValoracion()
        {
            List<Comentario> comentarios = Comentario.BusquedaComentarios(empresa);
            double puntuacion = 1;
            if (comentarios != null)
            {

                foreach (var item in comentarios)
                {
                    puntuacion += item.Score;
                }

                puntuacion /= comentarios.Count;
            }

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

        private void AplicarIdioma()
        {
            if (cmbIdioma.Text == "English")
            {
                idioma = "English";
                lblAjustes.Text = MultiIdiomas.FrmPaginaComercioIng.ajustes;
                lblModoNoche.Text = MultiIdiomas.FrmPaginaComercioIng.ModoNoche;
                lblPerfil.Text = MultiIdiomas.FrmPaginaComercioIng.PerfilUsuario;
                lblCrearEmpresa.Text = MultiIdiomas.FrmPaginaComercioIng.CrearEmpresa;
                lblCerrarSesion.Text = MultiIdiomas.FrmPaginaComercioIng.CerrarSesion;
                lblUbicacion.Text = MultiIdiomas.FrmPaginaComercioIng.VerUbi;
                tabProductos.Text = MultiIdiomas.FrmPaginaComercioIng.ProductosServicios;
                tabReseñas.Text = MultiIdiomas.FrmPaginaComercioIng.Reseñas;
                lblValoracion.Text = MultiIdiomas.FrmPaginaComercioIng.Valoracion;
                this.Text = MultiIdiomas.FrmPaginaComercioIng.PaginaComercio;
            }
            else if (cmbIdioma.Text == "Español")
            {
                idioma = "Español";
                lblAjustes.Text = MultiIdiomas.FrmPaginaComercioEsp.ajustes;
                lblModoNoche.Text = MultiIdiomas.FrmPaginaComercioEsp.ModoNoche;
                lblPerfil.Text = MultiIdiomas.FrmPaginaComercioEsp.PerfilUsuario;
                lblCrearEmpresa.Text = MultiIdiomas.FrmPaginaComercioEsp.CrearEmpresa;
                lblCerrarSesion.Text = MultiIdiomas.FrmPaginaComercioEsp.CerrarSesion;
                lblUbicacion.Text = MultiIdiomas.FrmPaginaComercioEsp.VerUbi;
                tabProductos.Text = MultiIdiomas.FrmPaginaComercioEsp.ProductosServicios;
                tabReseñas.Text = MultiIdiomas.FrmPaginaComercioEsp.Reseñas;
                lblValoracion.Text = MultiIdiomas.FrmPaginaComercioEsp.Valoracion;
                this.Text = MultiIdiomas.FrmPaginaComercioEsp.PaginaComercio;
            }
        }

        private void cmbIdioma_TextChanged(object sender, EventArgs e)
        {
            AplicarIdioma();
        }


    }
}
