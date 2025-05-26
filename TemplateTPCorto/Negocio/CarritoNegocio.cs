using Datos.Ventas;
using Persistencia;
using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CarritoNegocio
    {
        private CarritoPersistencia carritoPersistencia = new CarritoPersistencia();
        public Boolean AgregarProductoCarrito(Producto productoSeleccionado, int cantidad)
        {
            if (cantidad > 0)
            {
                int cantidadEnCarrito = carritoPersistencia.ObtenerCantidadProductoEnCarrito(productoSeleccionado.Id);

                if ((cantidadEnCarrito + cantidad) <= productoSeleccionado.Stock)
                {
                    return carritoPersistencia.AgregarProductoCarrito(productoSeleccionado, cantidad);
                }
            }
            return false;
        }

        public List<ProductoEnCarrito> obtenerProductosDelCarrito()
        {
            return carritoPersistencia.obtenerProductosDelCarrito();
        }

        public Boolean QuitarProductoCarrito(ProductoEnCarrito productoSeleccionado)
        {
            return carritoPersistencia.QuitarProductoCarrito(productoSeleccionado);
        }
        public void limpiarCarrito()
        {
            carritoPersistencia.limpiarCarrito();
        }
        public int calcularSubTotal()
        {
           return carritoPersistencia.calcularSubTotal();
        }
        public double calcularTotal()
        {
            double total = 0;
            int subtotal = calcularSubTotal();
            if (subtotal > 1000000)
            {
                total = subtotal * 0.85;

            }
            else
            {
                total = subtotal;
            }
            return total;
        }
    }

}