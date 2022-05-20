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
    public partial class PanelComentario : UserControl
    {
        private bool modoNoche;
        private Comentario comentario;
        private Usuario usuario;

        public PanelComentario()
        {
            InitializeComponent();
        }

        public PanelComentario(bool modoNoche, Comentario comentario, Usuario usuario) : this()
        {
            this.modoNoche = modoNoche;
            this.comentario = comentario;
            this.usuario = usuario;
        }

        private void PanelComentario_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.Username;
            lblComentario.Text = comentario.Text;
            picFoto.Image = usuario.Imagen;
            switch (comentario.Score)
            {
                case 1:
                    picValoracion.Image = Localmarket_App.Properties.Resources._1estr;
                    break;
                case 2:
                    picValoracion.Image = Localmarket_App.Properties.Resources._2estr;
                    break;
                case 3:
                    picValoracion.Image = Localmarket_App.Properties.Resources._3estr;
                    break;
                case 4:
                    picValoracion.Image = Localmarket_App.Properties.Resources._4estr;
                    break;
                case 5:
                    picValoracion.Image = Localmarket_App.Properties.Resources._5estr;
                    break;
                default:
                    break;
            }
        }
    }
}
