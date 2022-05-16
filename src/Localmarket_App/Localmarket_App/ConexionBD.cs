using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Aev7
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
                        instancia = new MySqlConnection("Server=localhost;Database=aev7;Uid=root;Pwd=;");
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
