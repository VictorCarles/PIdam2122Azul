using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localmarket_App
{
    public class Producto
    {
        private int idProducto;
        private string category;
        private double price;
        private string prod_name;
        private string description;
        private Image image;
        private bool avaiable;
        private string cifEmp;

        public Producto(int idProducto, string category, double price, string prod_name, string description, Image image, bool avaiable, string cifEmp)
        {
            this.idProducto = idProducto;
            this.category = category;
            this.price = price;
            this.prod_name = prod_name;
            this.description = description;
            this.image = image;
            this.avaiable = avaiable;
            this.cifEmp = cifEmp;
        }
    }
}
