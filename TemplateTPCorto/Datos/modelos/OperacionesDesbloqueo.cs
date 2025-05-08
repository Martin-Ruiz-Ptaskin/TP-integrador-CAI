using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class OperacionesDesbloqueo
    {
        public string IdOperacion { get; set; }
        public string Legajo { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string IdPerfil { get; set; }
        public DateTime FechaAlta { get; set; }

        public DateTime FechaUltimoLogin { get; set; }

        public OperacionesDesbloqueo() { }

        public OperacionesDesbloqueo(string operacion)
        {
            try
            {
                string[] datos = operacion.Split(';');
                IdOperacion = datos[0];
                Legajo = datos[1];
                NombreUsuario = datos[2];
                Contrasena = datos[3];
                IdPerfil = datos[4];
                FechaAlta = DateTime.ParseExact(datos[5], "d/M/yyyy", CultureInfo.InvariantCulture);
                FechaUltimoLogin = DateTime.ParseExact(datos[6], "d/M/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar el registro: {operacion}. Detalles: {ex.Message}");
                throw;
            }
        }
    }
}
