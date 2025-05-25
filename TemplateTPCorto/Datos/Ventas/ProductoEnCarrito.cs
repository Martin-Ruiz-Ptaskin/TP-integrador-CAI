using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Ventas
{
    public class ProductoEnCarrito
    {
            string _id;
            string _nombre;
            int _precio;
            int _cantidad;

            public string Id { get => _id; set => _id = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public int Precio { get => _precio; set => _precio = value; }
            public int Cantidad { get => _cantidad; set => _cantidad = value; }

            public ProductoEnCarrito(string producto)
            {
                try
                {
                    string[] datos = producto.Split(';');
                    Id = datos[0];
                    Nombre = datos[1];
                    Precio = Convert.ToInt32(datos[2]);
                    Cantidad = Convert.ToInt32(datos[3]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al procesar el registro: {producto}. Detalles: {ex.Message}");
                    throw;
                }
            }

            public string DisplayInfo
            {
                get
                {
                    return $"{Nombre} - ${Precio} - Stock: {Cantidad}";
                }
            }
    }
}
