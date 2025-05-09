using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OperacionesNegocio
    {
        private OperacionesPersistencia operacionesPersistencia = new OperacionesPersistencia();

        public Boolean AgregarOperacionDesbloqueo(String legajo, String nuevaContrasena)
        {
            return operacionesPersistencia.AgregarOperacionDesbloqueo(legajo, nuevaContrasena);
        }

        public List<OperacionesDesbloqueo> obtenerOperacionesDesbloqueo()
        {
            List<OperacionesDesbloqueo> operacionesDesbloqueo = operacionesPersistencia.obtenerOperacionesDeDesbloqueo();
            return operacionesDesbloqueo;
        }

        public List<OperacionesModificacion> obtenerOperacionesModificacion()
        {
            List<OperacionesModificacion> OperacionesModificacion = operacionesPersistencia.obtenerOperacionesDeModificacion();
            return OperacionesModificacion;
        }


        public Boolean EliminarOperacionPendiente(String idOperacion)
        {
            return operacionesPersistencia.EliminarOperacionDesbloqueo(idOperacion);
        }
        public Boolean EliminarOperacionModificacion(String idOperacion)
        {
            return operacionesPersistencia.EliminarOperacionModificacion(idOperacion);
        }
        public Boolean AgregarOperacionModificacion(Persona persona)
        {
            return operacionesPersistencia.AgregarOperacionModificacion(persona);
        }

    }
}
