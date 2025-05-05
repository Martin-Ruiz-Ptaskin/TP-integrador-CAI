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
        new PersonaPersistencia personaPersistencia = new PersonaPersistencia();
        public void modificarPersona(Persona persona)
        {
            personaPersistencia.modificarPersona(persona);

        }
    
    public List<Persona> obtenerPersonas()
        {
            List<Persona> personas= personaPersistencia.obtenerPersonas();
            return personas;
        }


    } }