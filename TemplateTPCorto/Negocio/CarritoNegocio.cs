using Datos.Ventas;
using Persistencia;
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
            if(cantidad > 0)
            {
                if (cantidad < productoSeleccionado.Stock)
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
    }
}
