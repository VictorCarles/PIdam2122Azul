using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Localmarket_App
{
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
