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

namespace Tienda.Vista.VentaVistas
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta venta = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            venta = bss.ObtenerVentaIdBss(idx);
            dateTimePicker1.Value = venta.FechaVenta;
            textBox1.Text = venta.TotalVenta.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta.FechaVenta = dateTimePicker1.Value;
            venta.TotalVenta = Convert.ToDecimal(textBox1.Text);

            bss.EditarVentaBss(venta);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
