using Tienda.Bss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTienda.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaListarVista : Form
    {
        public DetalleVentaListarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetallesVentaBss();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista fr = new DetalleVentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesVentaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVista fr = new DetalleVentaEditarVista(idDetalleVentaSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetallesVentaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idDetalleVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este detalle de venta?", "Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(idDetalleVentaSeleccionado);
                dataGridView1.DataSource = bss.ListarDetallesVentaBss();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaEditarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaInsertarVista.IdVentaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
