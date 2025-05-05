using System;
using Datos;
using Persistencia.DataBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersonaPersistencia
    {
        private DataBaseUtils dataBaseUtils = new DataBaseUtils();
        public void modificarPersona(Persona persona)
        {
            try
            {
                dataBaseUtils.ModificarRegistro("persona.csv", persona.Legajo, persona.ToCsvString());
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al modificar la persona: {ex.Message}");
            }
            // Aquí puedes implementar la lógica para modificar la persona en la base de datos
            // Por ejemplo, llamar a un método de persistencia para actualizar los datos en el archivo CSV
            // o en la base de datos según tu implementación.
        }
    
public List<Persona> obtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            List<String> listado = dataBaseUtils.BuscarRegistro("persona.csv");

            if (listado != null && listado.Count > 0) // Verificar si el listado no es nulo ni vacío
            {
                listado.RemoveAt(0); // Remover el primer elemento de la lista

                foreach (String registro in listado)
                {
                    try
                    {
                        Persona persona = new Persona(registro);
                        personas.Add(persona);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        Console.WriteLine($"Error al obtener las personas: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontraron registros en el archivo persona.csv.");
            }

            return personas;
        }
    }
}
