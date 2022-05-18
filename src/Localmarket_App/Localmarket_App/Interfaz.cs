using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localmarket_App
{
    static class Interfaz
    {
        internal static List<Empresa> BusquedaComercios(string text)
        {
            string consulta = string.Format("SELECT * FROM Empresa WHERE emp_name LIKE ('%{0}%'); ", text);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                List<Empresa> empresas = new List<Empresa>();
                while (reader.Read())
                {
                    Image img;
                    if (reader.GetString(6) != "nada")
                    {
                        string data = reader.GetString(6);
                        img = Base64ToImage(data);
                    }
                    else
                    {
                        img = null;
                    }
                    Empresa emp = new Empresa(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetInt32(4), reader.GetDouble(5), img, reader.GetString(7), reader.GetInt32(8), reader.GetString(9),
                        reader.GetString(10));
                    empresas.Add(emp);
                }
                return empresas;
            }
            else
            {
                return null;
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
