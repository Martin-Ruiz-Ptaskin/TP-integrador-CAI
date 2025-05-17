using Datos;
using Datos.modelos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class personaNegocio
    {
        PersonaPersistencia personaPersistencia = new PersonaPersistencia();
        OperacionesNegocio operacionesNegocio = new OperacionesNegocio();


        public void modificarPersona(Persona persona)
        {
            
               operacionesNegocio.AgregarOperacionModificacion(persona);         
               //personaPersistencia.modificarPersona(persona);


            
        }
        public void modificarPersonaPersitencia(Persona persona,String registroAeliminar)
        {

            try
            {
                // Intentar ejecutar la primera función
                personaPersistencia.modificarPersona(persona);

                // Si la primera función se ejecuta correctamente, ejecutar la segunda
                operacionesNegocio.AprobarEstadoAutorizacion(registroAeliminar);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: registrar el error o tomar acciones necesarias
                Console.WriteLine($"Error al modificar la persona o eliminar la operación: {ex.Message}");
                throw; // Opcional: relanzar la excepción si necesitas manejarla en un nivel superior
            }

        }

        public List<Persona> obtenerPersonas()
        {
            List<Persona> personas = personaPersistencia.obtenerPersonas();
            return personas;
        }
        public Boolean AgregarOperacionModificacion(Persona persona)
        {
            OperacionesNegocio operacionesNegocio = new OperacionesNegocio();
            return operacionesNegocio.AgregarOperacionModificacion(persona);
        }
    }
}
