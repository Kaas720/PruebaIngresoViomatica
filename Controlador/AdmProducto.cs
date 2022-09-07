using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Controlador
{
    public class AdmProducto
    {
        public string BuscarProducto(ComboBox cbProducto)
        {
            Producto producto = new Producto();
            List<string> listaProducto = producto.buscarProducto();
            if (listaProducto != null)
            {
                if (listaProducto.Count != 0)
                {
                    foreach (string lista in listaProducto)
                    {
                        cbProducto.Items.Add(lista);
                    }
                    return "Si";
                }
                else
                {
                    return "No hay elemntos";
                }

            }
            else
            {
                return "Existe un problema al momento de conectarse a la BD intente mas tarde";
            }
        }

        public void llenarDatagrid(DataGridView facturaDataGrid, string nombre, int cantidad, Label textIva, Label textSubTotal, Label textTotal, double subTotalFinal)
        {
            int numerofila = facturaDataGrid.Rows.Count;
            Producto producto = new Producto();
            int valorUnitario = producto.buscarProductoNombre(nombre);
            if(valorUnitario == 0)
            {
                MessageBox.Show("Hubo algun problema al buscar el producto intente mas tarde");
            }
            else
            {
                int contador=0;
                Boolean validador = true;
                foreach (DataGridViewRow row in facturaDataGrid.Rows)
                {
                    
                    if (row.Cells[1].Value.ToString().Equals(nombre))
                    {
                        MessageBox.Show(row.Cells[1].Value.ToString()+ valorUnitario);
                        int cantidadNueva = Convert.ToInt32(row.Cells[3].Value) + cantidad;
                        facturaDataGrid.Rows[contador].Cells[3].Value = cantidadNueva;
                        facturaDataGrid.Rows[contador].Cells[4].Value = cantidadNueva * valorUnitario;
                        validador = false;
                    }
                    contador++;
                }
                if (validador)
                {
                    facturaDataGrid.Rows.Add(1);
                    facturaDataGrid.Rows[numerofila].Cells[0].Value = numerofila + 1;
                    facturaDataGrid.Rows[numerofila].Cells[1].Value = nombre;
                    facturaDataGrid.Rows[numerofila].Cells[2].Value = valorUnitario;
                    facturaDataGrid.Rows[numerofila].Cells[3].Value = cantidad;
                    facturaDataGrid.Rows[numerofila].Cells[4].Value = cantidad * valorUnitario;
                    facturaDataGrid.Rows[numerofila].Cells[5].Value = "Eliminar..";
                }
            }
        }
    }
}
