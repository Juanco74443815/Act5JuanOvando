using Tienda.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Dal
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "SELECT * FROM Producto";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "INSERT INTO Producto (NombreProducto, PrecioUnitario) VALUES ('" + producto.NombreProducto + "', " + producto.PrecioUnitario.ToString() + ")";
            Conexion.Ejecutar(consulta);
        }

        public Producto ObtenerProductoId(int id)
        {
            string consulta = "SELECT * FROM Producto WHERE IdProducto = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Producto producto = new Producto();
            if (tabla.Rows.Count > 0)
            {
                producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["IdProducto"]);
                producto.NombreProducto = tabla.Rows[0]["NombreProducto"].ToString();
                producto.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PrecioUnitario"]);
            }
            return producto;
        }

        public void EditarProductoDal(Producto producto)
        {
            string consulta = "UPDATE Producto SET NombreProducto = '" + producto.NombreProducto + "', PrecioUnitario = " + producto.PrecioUnitario.ToString() + " WHERE IdProducto = " + producto.IdProducto;
            Conexion.Ejecutar(consulta);
        }

        public void EliminarProductoDal(int id)
        {
            string consulta = "DELETE FROM Producto WHERE IdProducto = " + id;
            Conexion.Ejecutar(consulta);
        }

    }
}
