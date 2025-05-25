using Datos;
using Datos.Ventas;
using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class CarritoPersistencia
    {
        private DataBaseUtils dataBaseUtils = new DataBaseUtils();
        public Boolean AgregarProductoCarrito(Producto productoSeleccionado, int cantidad)
        {
            try
            {
                return dataBaseUtils.AgregarProductoCarrito(productoSeleccionado, cantidad);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el método Agregar Producto al Carrito : {ex.Message}");
            }
            return false;
        }
        public List<ProductoEnCarrito> obtenerProductosDelCarrito()
        {
            List<ProductoEnCarrito> productos = new List<ProductoEnCarrito>();
            List<string> registros = dataBaseUtils.BuscarRegistro("carrito.csv");

            if (registros != null && registros.Count > 0)
            {
                registros.RemoveAt(0);

                foreach (string linea in registros)
                {
                    try
                    {
                        ProductoEnCarrito productoAgregar = new ProductoEnCarrito(linea);
                        productos.Add(productoAgregar);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al parsear operación: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontraron productos en el carrito.csv");
            }

            return productos;
        }
    }
}
