using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Localmarket_App.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void InsertarUsuarioTest()
        {
            string consulta = "INSERT INTO Usuario VALUES('aserenarme', 'Gotfried', 'Alexei', 'uwu22', 711107709, " +
                "'golovanalexei@eelraodo.com', NULL, 'C/Multiverso', 9619, 'basic', '60815304S');";

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBD.Conexion);
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                comando.ExecuteNonQuery();
                ConexionBD.CerrarConexion();
            }
            MessageBox.Show("Registro realizado correctamente");
        }
    }

    class ConexionBD
    {
        private static MySqlConnection instancia = null;

        private static readonly object padlock = new object();

        private ConexionBD() { }

        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection("Server=localmarket-db.cogascnxjvfa.us-east-1.rds.amazonaws.com;Database=localmarket_db;Uid=admin;Pwd=patata14;");
                    }
                    return instancia;
                }
            }
        }
        /// <summary>
        /// Abre la conexion a la base de datos
        /// </summary>
        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }
        /// <summary>
        /// Cierra la conexion a la base de datos
        /// </summary>
        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }

    }
}