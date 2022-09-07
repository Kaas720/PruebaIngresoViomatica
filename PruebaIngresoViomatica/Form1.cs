using Controlador;

namespace PruebaIngresoViomatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdmProducto admProducto = new AdmProducto();
            string resultado = admProducto.BuscarProducto(cbProducto);
            if (resultado != "Si")
            {
                MessageBox.Show(resultado, "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                cbProducto.SelectedIndex = 0;
            }
            

        }
        private double subTotalFinal = 0;
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            AdmProducto admProducto = new AdmProducto();
            admProducto.llenarDatagrid(facturaDataGrid,cbProducto.Text, Convert.ToInt32(numericCantidad.Value), textIva, textSubTotal, textTotal, subTotalFinal);
            calcularValores();
            numericDescuento.Value = 0;
            textTotalDescuento.Text =   "0.00 $";
            numericDescuento.Enabled = true;
        }

        private void calcularValores()
        {
            int numerofila = facturaDataGrid.Rows.Count;
            double subTotal = 0;
            for (int i = 0; i < numerofila; i++)
            {
                subTotal = subTotal + Convert.ToDouble(facturaDataGrid.Rows[i].Cells[4].Value);
                textSubTotal.Text = subTotal.ToString("N2") + " $";
            }
            double iva = 0.12;
            iva = iva * subTotal;
            textIva.Text = iva.ToString("N2") + " $";
            double total = 0;
            total = iva + subTotal;
            textTotal.Text = total.ToString("N2") + " $";
            subTotalFinal = subTotal;
        }

        private void numericDescuento_ValueChanged(object sender, EventArgs e)
        {
            double totalConDescuento = subTotalFinal * Convert.ToDouble(numericDescuento.Value/100);
            MessageBox.Show(totalConDescuento.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            totalConDescuento = subTotalFinal - totalConDescuento;
            textTotalDescuento.Text = totalConDescuento.ToString("N2") + " $";
            double iva = 0.12;
            iva = iva * totalConDescuento;
            textIva.Text = iva.ToString("N2") + " $";
            double total = 0;
            total = iva + totalConDescuento;
            textTotal.Text = total.ToString("N2") + " $";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdmProducto admProducto = new AdmProducto();
        }
    }
}