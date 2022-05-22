using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Localmarket_App
{
    public class Usuario
    {
        private string username;
        private string fullname;
        private string surnames;
        private string password;
        private int telephone;
        private string email;
        private string address;
        private int cp;
        private Image profilePicture;
        private string type;
        private string DNI;

        public Usuario(string username, string fullname, string surnames, string password, int telephone, string email,
            string address, int cp, Image profilePicture, string type,string dni = null)
        {
            this.username = username;
            this.fullname = fullname;
            this.surnames = surnames;
            this.password = password;
            this.telephone = telephone;
            this.email = email;
            this.address = address;
            this.cp = cp;
            this.profilePicture = profilePicture;
            this.type = type;
            this.DNI = dni;
        }

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username { get { return username; } }
        public Image Imagen { get { return profilePicture; } }
        public string Email { get { return email; } }
        public string Password { get { return password; } }

        public static void InsertarUsuario(Usuario usu)
        {
            string consulta = string.Format("INSERT INTO Usuario (username, fullname, surnames, password, telephone, email, profilepicture, address, cp, type, dni) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", usu.Username, usu.fullname, usu.surnames, usu.password, usu.telephone, usu.email, ImageToBase64(usu.profilePicture, usu.profilePicture.RawFormat), 
                usu.address, usu.cp, usu.type, usu.DNI);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro realizado correctamente");
        }

        public static Usuario ModificarUsuario(Usuario usuario, string mail, string usu, string pasword, Image image)
        {
            string consulta = string.Format("UPDATE Usuario SET username='{0}', email='{1}', password='{2}', profilepicture='{3}' WHERE username='{4}';",
                usu,mail,pasword,ImageToBase64(image, ImageFormat.Bmp),usuario.username);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            comando.ExecuteNonQuery();

            usuario.email = mail;
            usuario.username = usu;
            usuario.password = pasword;
            usuario.profilePicture = image;

            Usuario usuario1 = ComprobarUsuario(usuario);
            return usuario1;
        }

        public static Usuario ComprobarUsuario(Usuario usu)
        {
            string consulta = string.Format("SELECT * FROM Usuario WHERE username = '{0}' AND password = '{1}'", usu.username, usu.password);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                Image img;
                reader.Read();
                
                if (!reader.IsDBNull(6))
                {
                    string data = reader.GetString(6);
                    img = Base64ToImage(data);
                }
                else
                {
                    img = Localmarket_App.Properties.Resources.Perfil_Usuario;
                }
                Usuario usuario = new Usuario(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetInt32(4),reader.GetString(5),
                    reader.GetString(7),reader.GetInt32(8),img,reader.GetString(9),reader.GetString(10));
                reader.Close();
                return usuario;
            }
            else
            {
                return null;
            }
        }

        public static Usuario ComprobarUsuarioSeg(string usu)
        {
            string consulta = string.Format("SELECT * FROM Usuario WHERE username = '{0}'", usu);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                Image img;
                reader.Read();
                if (!reader.IsDBNull(6))
                {
                    string data = reader.GetString(6);
                    img = Base64ToImage(data);
                }
                else
                {
                    img = Localmarket_App.Properties.Resources.Perfil_Usuario;
                }
                Usuario usuario = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5),
                    reader.GetString(7), reader.GetInt32(8), img, reader.GetString(9), reader.GetString(10));
                reader.Close();
                return usuario;
            }
            else
            {
                reader.Close();
                return null;
            }
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
