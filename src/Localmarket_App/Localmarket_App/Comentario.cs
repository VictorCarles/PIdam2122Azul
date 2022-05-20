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
    public class Comentario
    {
        private int idComentario;
        private string text;
        private int score;
        private string cifEmp;
        private string Usuario_Username;
        private int idRespuesta_Comentario;
        private int usefulPoints;
        private DateTime publication_date;

        public Comentario(int idComentario, string text, int score, string cifEmp, string usuario_Username, 
            int usefulPoints, DateTime publication_date, int idRespuesta_Comentario = 0)
        {
            this.idComentario = idComentario;
            this.text = text;
            this.score = score;
            this.cifEmp = cifEmp;
            Usuario_Username = usuario_Username;
            this.idRespuesta_Comentario = idRespuesta_Comentario;
            this.usefulPoints = usefulPoints;
            this.publication_date = publication_date;
        }
        public string Text { get { return text; } }
        public int Score { get { return score; } }
        public string Usuario { get { return Usuario_Username; } }
        internal static List<Comentario> BusquedaComentarios(Empresa emp)
        {
            string consulta = string.Format("SELECT * FROM Comentario WHERE cifEmp = '{0}'; ", emp.CIFP);
            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                List<Comentario> comentarios = new List<Comentario>();
                while (reader.Read())
                {

                    Comentario com = new Comentario(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), 
                        reader.GetString(3), reader.GetString(4), reader.GetInt32(6), reader.GetDateTime(7));
                    comentarios.Add(com);
                }
                reader.Close();
                return comentarios;
            }
            else
            {
                return null;
            }
        }

        public static void InsertarComentario(Comentario com)
        {
            string consulta = string.Format("INSERT INTO Comentario VALUES (DEFAULT,'{0}','{1}','{2}','{3}',NULL,'{4}',CURDATE())", com.text, com.score, 
                com.cifEmp, com.Usuario_Username,com.usefulPoints);

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
