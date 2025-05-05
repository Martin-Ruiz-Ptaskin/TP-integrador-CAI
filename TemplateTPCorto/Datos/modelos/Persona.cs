using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Persona
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Constructor vacío
        public Persona() { }

        // Constructor para inicializar desde una línea CSV
        public Persona(string registro)
        {
            try
            {
                string[] datos = registro.Split(';');
                if (datos.Length != 5)
                {
                    throw new FormatException("El registro no tiene el formato esperado.");
                }
                Console.WriteLine(registro);
                Legajo = datos[0];
                Nombre = datos[1];
                Apellido = datos[2];
                Dni = datos[3];
                FechaIngreso = DateTime.ParseExact(datos[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar el registro: {registro}. Detalles: {ex.Message}");
                throw; // Opcional: relanzar la excepción si necesitas manejarla en otro nivel.
            }
        }

        // Método para convertir los datos de la persona a una línea CSV
        public string ToCsvString()
        {
            return $"{Legajo};{Nombre};{Apellido};{Dni};{FechaIngreso:dd/MM/yyyy}";
        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }


    }
}
