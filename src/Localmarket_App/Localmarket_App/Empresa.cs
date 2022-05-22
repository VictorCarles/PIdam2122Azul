using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Localmarket_App
{
    public class Empresa
    {
        private string CIF;
        private string name;
        private string category;
        private string email;
        private int phone;
        private double avgScore;
        private Image profilePicture;
        private string address;
        private int cp;
        private string description;
        private string usuario;

        public Empresa(string cif, string name, string category, string email, 
            int phone, double avgscore ,Image image, string address, int cp, string description, string username)
        {
            this.CIF = cif;
            this.name = name;
            this.category = category;
            this.email = email;
            this.phone = phone;
            this.avgScore = avgscore;
            this.profilePicture = image;
            this.address = address;
            this.cp = cp;
            this.description = description;
            this.usuario = username;
        }
        public string CIFP { get { return CIF; } }
        public string Name { get { return name; } }
        public Image ProfilePicture { get { return profilePicture; } }
        public string Description { get { return description; } }
        public double AvgScore { get { return avgScore; } }
        public string Address { get { return address; } }

        public static void InsertarEmpresa(Empresa empresa)
        {
            string consulta = string.Format("INSERT INTO Empresa (cif, emp_name, category, email, telephone, avgscore, ppicture, address, cp, description, usuario_username)" + 
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                empresa.CIF, empresa.name, empresa.category, empresa.email, empresa.phone, empresa.avgScore,
                ImageToBase64(empresa.profilePicture, empresa.profilePicture.RawFormat), empresa.address, empresa.cp, empresa.description, empresa.usuario);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro de la Empresa realizado correctamente");
        }

        internal static bool TieneEmpresa(Usuario usuario)
        {
            string consulta = string.Format("SELECT usuario_username FROM Empresa WHERE usuario_username='{0}'",usuario.Username);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public static List<Empresa> BusquedaComercios(string text)
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
                    if (!reader.IsDBNull(6))
                    {
                        string data = reader.GetString(6);
                        img = Base64ToImage(data);
                    }
                    else
                    {
                        img = Localmarket_App.Properties.Resources.Grupo_5;
                    }

                    Empresa emp = new Empresa(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetInt32(4), reader.GetDouble(5), img, reader.GetString(7), reader.GetInt32(8), reader.GetString(9),
                        reader.GetString(10));
                    empresas.Add(emp);
                }
                reader.Close();
                return empresas;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public static List<Empresa> BusquedaComerciosCategoria(string text)
        {
            string consulta = string.Format("SELECT * FROM Empresa WHERE category LIKE ('%{0}%'); ", text);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                List<Empresa> empresas = new List<Empresa>();
                while (reader.Read())
                {
                    Image img;
                    if (!reader.IsDBNull(6))
                    {
                        string data = reader.GetString(6);
                        img = Base64ToImage(data);
                    }
                    else
                    {
                        img = Localmarket_App.Properties.Resources.Grupo_5;
                    }

                    Empresa emp = new Empresa(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetInt32(4), reader.GetDouble(5), img, reader.GetString(7), reader.GetInt32(8), reader.GetString(9),
                        reader.GetString(10));
                    empresas.Add(emp);
                }
                reader.Close();
                return empresas;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public static Empresa ConseguirEmpresa(Usuario usu)
        {
            string consulta = string.Format("SELECT * FROM Empresa WHERE Usuario_Username='{0}'; ", usu.Username);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                Image img;
                if (!reader.IsDBNull(6))
                {
                    string data = reader.GetString(6);
                    img = Base64ToImage(data);
                }
                else
                {
                    img = Localmarket_App.Properties.Resources.Grupo_5;
                }

                Empresa emp = new Empresa(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                   reader.GetInt32(4), reader.GetDouble(5), img, reader.GetString(7), reader.GetInt32(8), reader.GetString(9),
                   reader.GetString(10));
                reader.Close();
                return emp;
            }
            else
            {
                return null;
            }
        }

        public static Empresa ModificarEmpresa(Empresa empresa, string nombre, string desc, Image logo, Usuario usuario)
        {
            string consulta = string.Format("UPDATE Empresa SET emp_name='{0}', description='{1}', pPicture='{2}' WHERE cif='{3}';",
                nombre, desc, ImageToBase64(logo, ImageFormat.Bmp), empresa.CIF);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();

            empresa.name = nombre;
            empresa.description = desc;
            empresa.profilePicture = logo;
            return empresa;
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