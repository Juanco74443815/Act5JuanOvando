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
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.FechaVenta = dateTimePicker1.Value;
            venta.TotalVenta = Convert.ToDecimal(textBox1.Text);

            bss.InsertarVentaBss(venta);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
