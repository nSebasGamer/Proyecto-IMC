using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC__Login_
{
    internal class conexion
    {
        private MySqlConnection Conexion;
        private string server = "localhost";
        private string database = "imc";
        private string user = "root";
        private string password = "";
        private string CadenaConexion;

        public conexion()
        {

            CadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id=" + user +
                "; Password=" + password;
        }

        public MySqlConnection GetConexion()
        {

            if (Conexion == null)
            {
                Conexion = new MySqlConnection(CadenaConexion);
            }
            return new MySqlConnection(CadenaConexion);




        }


    }
}
