using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Autorizaciones
    {
        public string idOperacion { get; set; }
        public string tipoOperacion { get; set; }
        public string estado { get; set; }
        public string legajoSolicitante { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string legajoAutorizador { get; set; }
        public DateTime? fechaAutorizacion { get; set; }

        public Autorizaciones() { }

        public Autorizaciones(string operacion)
        {
            try
            {
                string[] datos = operacion.Split(';');
                idOperacion = datos[0];
                tipoOperacion = datos[1];
                estado = datos[2];
                legajoSolicitante = datos[3];
                fechaSolicitud = DateTime.ParseExact(datos[4], "d/M/yyyy", CultureInfo.InvariantCulture);
                legajoAutorizador = datos[5];
                if (datos[6] != " ")
                {
                    fechaAutorizacion = DateTime.ParseExact(datos[6], "d/M/yyyy", CultureInfo.InvariantCulture);
                }
                else
                {
                    fechaAutorizacion = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar el registro: {operacion}. Detalles: {ex.Message}");
                throw;
            }
        }
        public string DisplayInfo
        {
            get
            {
                return $"{idOperacion} - {tipoOperacion} - {estado} - Solicita: {legajoSolicitante}";
            }
        }
    }
}
