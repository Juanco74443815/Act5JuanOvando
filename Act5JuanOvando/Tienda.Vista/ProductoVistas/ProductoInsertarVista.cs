using SistemaTienda.Bss;
using SistemaTienda.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Vista.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.NombreProducto = textBox1.Text;
            producto.PrecioUnitario = Convert.ToDecimal(textBox1.Text);

            bss.InsertarProductoBss(producto);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
