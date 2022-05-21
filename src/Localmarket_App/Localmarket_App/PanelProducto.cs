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
    public partial class PanelProducto : UserControl
    {
        private bool modoNoche;
        private Producto producto;
        public PanelProducto()
        {
            InitializeComponent();
        }

        public PanelProducto(bool modoNoche, Producto producto) : this()
        {
            this.modoNoche = modoNoche;
            this.producto = producto;
        }

        private void PanelProducto_Load(object sender, EventArgs e)
        {
            lblProducto.Text = producto.Nombre;
            lblPrecio.Text = producto.Price.ToString() + "€";
            lblDescripcion.Text = producto.Descripcion;
            picProducto.Image = producto.Image;
        }
    }
}
