using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.modelos
{
    public class VentaItemRequest
    {
        public String idCliente { get;  }
        public String idUsuario { get; set; }
        public String idProducto { get; set; }
        public int cantidad { get; set; }
        public VentaItemRequest(string idCliente,  String idProducto, int cantidad)
        {
            this.idCliente = idCliente.ToString();
            this.idUsuario = "784c07f2-2b26-4973-9235-4064e94832b5"; ;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
    }
}
