using Tienda.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dal
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetallesVentaDal()
        {
            string consulta = "SELECT        DetalleVenta.IDDetalleVenta AS ID, Producto.NombreProducto, DetalleVenta.Cantidad, DetalleVenta.PrecioUnitario, DetalleVenta.TotalDetalle\r\nFROM            DetalleVenta INNER JOIN\r\n                         Producto ON DetalleVenta.IDProducto = Producto.IDProducto";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "INSERT INTO DetalleVenta (IdVenta, IdProducto, Cantidad, PrecioUnitario, TotalDetalle) VALUES (" + detalleVenta.IdVenta.ToString() + ", " + detalleVenta.IdProducto.ToString() + ", " + detalleVenta.Cantidad.ToString() + ", " + detalleVenta.PrecioUnitario.ToString() + ", " + detalleVenta.TotalDetalle.ToString() + ")";
            Conexion.Ejecutar(consulta);
        }

        public DetalleVenta ObtenerDetalleVentaId(int id)
        {
            string consulta = "SELECT * FROM DetalleVenta WHERE IdDetalleVenta = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            DetalleVenta detalleVenta = new DetalleVenta();
            if (tabla.Rows.Count > 0)
            {
                detalleVenta.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["IdDetalleVenta"]);
                detalleVenta.IdVenta = Convert.ToInt32(tabla.Rows[0]["IdVenta"]);
                detalleVenta.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                detalleVenta.Cantidad = Convert.ToInt32(tabla.Rows[0]["Cantidad"]);
                detalleVenta.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PrecioUnitario"]);
                detalleVenta.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["TotalDetalle"]);
            }
            return detalleVenta;
        }

        public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "UPDATE DetalleVenta SET IdVenta = " + detalleVenta.IdVenta.ToString() + ", IdProducto = " + detalleVenta.IdProducto.ToString() + ", Cantidad = " + detalleVenta.Cantidad.ToString() + ", PrecioUnitario = " + detalleVenta.PrecioUnitario.ToString() + ", TotalDetalle = " + detalleVenta.TotalDetalle.ToString() + " WHERE IdDetalleVenta = " + detalleVenta.IdDetalleVenta.ToString();
            Conexion.Ejecutar(consulta);
        }

        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "DELETE FROM DetalleVenta WHERE IdDetalleVenta = " + id;
            Conexion.Ejecutar(consulta);
        }

    }
}
