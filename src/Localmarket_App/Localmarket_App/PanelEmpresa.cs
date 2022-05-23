﻿using Localmarket_App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Localmarket_App
{
    public partial class PanelEmpresa : UserControl
    {
        Empresa empresa;
        private bool modoNoche;
        Usuario usuario;
        private string idioma;

        public PanelEmpresa()
        {
            InitializeComponent();
        }

        public PanelEmpresa(bool noche, Empresa emp, Usuario usu, string idioma) : this()
        {
            this.idioma = idioma;
            empresa = emp;
            usuario = usu;
            modoNoche = noche;
            picComercio1.Image = new Bitmap(emp.ProfilePicture);
            lblNomComercio.Text = emp.Name;
            lblDescComercio.Text = emp.Description;
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                calculaValoracion();
                ConexionBD.CerrarConexion();
            }
        }

        private void lblNomComercio_Click(object sender, EventArgs e)
        {
            FrmPrincipal.ActiveForm.Hide();
            FrmPaginaComercio frmPaginaComercio = new FrmPaginaComercio(modoNoche, empresa, usuario, idioma);
            frmPaginaComercio.ShowDialog();
            if (FrmPrincipal.ActiveForm != null)
            {
                FrmPrincipal.ActiveForm.Close();
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

        private void PanelEmpresa_Load(object sender, EventArgs e)
        {
            if (modoNoche)
            {
                lblNomComercio.ForeColor = Color.White;
                lblDescComercio.ForeColor = Color.White;
                lblValoracion.ForeColor = Color.White;
            }
        }
    }
}