using Tienda.Bss;
using Tienda.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaTienda.VISTA.ProductoVistas
{
    public partial class ProductoEditarVista : Form
    {
        int idx = 0;
        Producto producto = new Producto();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            producto = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = producto.NombreProducto;
            textBox2.Text = producto.PrecioUnitario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.NombreProducto = textBox1.Text;
            producto.PrecioUnitario = Convert.ToDecimal(textBox2.Text);

            bss.EditarProductoBss(producto);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
