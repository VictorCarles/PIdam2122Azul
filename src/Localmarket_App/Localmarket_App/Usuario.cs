using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Localmarket_App
{
    internal class Usuario
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

        // Could be null
        private string CIF;
        private string DNI;
        private int pinCode;

        public Usuario(string username, string fullname, string surnames, string password, int telephone, string email,
            string address, int cp, string type, Image profilePicture)
        {
            this.username = username;
            this.fullname = fullname;
            this.surnames = surnames;
            this.password = password;
            this.telephone = telephone;
            this.email = email;
            this.address = address;
            this.cp = cp;
            this.type = type;
            this.profilePicture = profilePicture;
        }

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void RegistrarUsuario()
        {

            string query = String.Format("INSERT INTO Usuario (username, fullname, surnames, password, telephone, email, profilepicture, address, cp, type) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", username, fullname, surnames, password, telephone, email, profilePicture, address, cp, type);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Usuario registrado con exito");
        }

        public bool BuscarUsuario()
        {
            string query = String.Format("SELECT username, password FROM Usuario WHERE username = '{0}'",username);
            MySqlCommand comando = new MySqlCommand(query, ConexionBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (reader.GetString(1) == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
