﻿using Localmarket_App.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string Nombre { get { return prod_name; } }
        public string Descripcion { get { return description; } }
        public double Price { get { return price; } }
        public Image Image { get { return image; } }

        internal static List<Producto> BusquedaProductos(Empresa emp)
        {
            string consulta = string.Format("SELECT * FROM Producto WHERE cifEmp = '{0}'; ", emp.CIFP);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                List<Producto> productos = new List<Producto>();
                while (reader.Read())
                {
                    Image img;
                    if (reader.GetString(5) != "nada")
                    {
                        string data = reader.GetString(5);
                        img = Base64ToImage(data);
                    }
                    else
                    {
                        img = null;
                    }
                    Producto prod = new Producto(reader.GetInt32(0),reader.GetString(1),reader.GetDouble(2),reader.GetString(3), reader.GetString(4),
                        img,reader.GetBoolean(6),reader.GetString(7));
                    productos.Add(prod);
                }
                reader.Close();
                return productos;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public static void InsertarProducto(Producto prod)
        {
            string consulta = string.Format("INSERT INTO Producto VALUES (DEFAULT,'{0}','{1}','{2}','{3}','{4}','1','{5}');", prod.category, prod.price,
                prod.prod_name, prod.description, ImageToBase64(prod.image,prod.image.RawFormat),prod.cifEmp);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro realizado correctamente");
        }


        public static string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}