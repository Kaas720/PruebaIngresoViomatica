using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private MySqlConnection sqlconnection = null;
        private static string conexion_DB_externa = "Server=localhost;Database=sistemafacturacion;Uid=root;Pwd=1234emelec";
        public MySqlConnection Connection { get => sqlconnection; set => sqlconnection = value; }
        public MySqlConnection conectar()
        {
            try
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = conexion_DB_externa;
                Connection.Open();
            }
            catch (MySqlException x)
            {
                return null;
            }
            return Connection;
        }
        public void cerrar()
        {
            try
            {
                Connection.Close();
            }
            catch (MySqlException x)
            {

                Console.WriteLine(x.Message);
            }
        }

    }
}
