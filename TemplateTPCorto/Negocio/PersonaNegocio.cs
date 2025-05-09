using Datos;
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
            personaPersistencia.modificarPersona(persona);
            operacionesNegocio.AgregarOperacionModificacion(persona);
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
