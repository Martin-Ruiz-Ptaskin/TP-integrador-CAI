using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.WebService.Utils;
using System.Net.Http;
using Newtonsoft.Json;
using Datos.modelos;

namespace Persistencia
{
    public class VentaPersistencia
    {
        //private Guid idUsuario = new Guid("0cdbc5a5-69d9-4ab8-8cb3-9932ce33f54a");

        
        public bool agregarVenta(VentaItemRequest venta)
        {
            var jsonRequest = JsonConvert.SerializeObject(venta);

            HttpResponseMessage response = WebHelper.Post("/api/Venta/AgregarVenta", jsonRequest);
            Console.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
        
    }
}
