using Tienda.Bss;
using Tienda.Vista.DetalleVentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.Vista.ProductoVista
{
    public partial class ProductoListarVista : Form
    {
        public ProductoListarVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductosBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoInsertarVista fr = new ProductoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoEditarVista fr = new ProductoEditarVista(idProductoSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProductoBss(idProductoSeleccionado);
                dataGridView1.DataSource = bss.ListarProductosBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
