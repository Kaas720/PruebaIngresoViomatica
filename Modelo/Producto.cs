using Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private double precio;

        public Producto() { }
        public Producto(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }
        public List<string> buscarProducto() { 
            List<string> nombreProductoList = null;
            Conexion con = new Conexion();
            MySqlConnection conexion = con.conectar();
            if (conexion != null)
            {
                nombreProductoList = new List<string>();
                try
                {
                    MySqlCommand mySqlCommand = ConectarProcedimiento("buscarProducto", conexion);
                    MySqlDataReader lector = mySqlCommand.ExecuteReader();
                    while (lector.Read())
                    {
                        nombreProductoList.Add(lector["nombreProducto"].ToString());
                    }
                    con.cerrar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error intentolo mas tarde" + ex);

                }
                return nombreProductoList;
            }
            else
            {
                return nombreProductoList;
            }
        }

        public int buscarProductoNombre(string nombre)
        {
            Conexion con = new Conexion();
            MySqlConnection conexion = con.conectar();
            int valorUnitario=0;
            if (conexion != null)
            {
                
                try
                {
                    MySqlCommand mySqlCommand = ConectarProcedimiento("buscarProductoNombre", conexion);
                    mySqlCommand.Parameters.AddWithValue("@nombre", nombre);
                    MySqlDataReader lector = mySqlCommand.ExecuteReader();
                    while (lector.Read())
                    {
                        valorUnitario = (Convert.ToInt32(lector["valorUnitario"]));
                    }
                    con.cerrar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error intentolo mas tarde" + ex);
                }
            }
            return valorUnitario;
        }

        public MySqlCommand ConectarProcedimiento(string Procedimientos, MySqlConnection mySqlConnection)
        {
            MySqlCommand mySqlCommand;
            mySqlCommand = new MySqlCommand(Procedimientos, mySqlConnection);
            mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return mySqlCommand;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
