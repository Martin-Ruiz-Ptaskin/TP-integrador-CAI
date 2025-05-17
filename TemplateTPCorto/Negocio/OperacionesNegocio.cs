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

        public List<Autorizaciones> obtenerAutorizacionesDesbloqueo()
        {
            List<Autorizaciones> operacionesDesbloqueo = operacionesPersistencia.obtenerOperacionesDeDesbloqueo();
            return operacionesDesbloqueo;
        }

        public OperacionesDesbloqueo obtenerOperacionesDeDesbloqueoActual(string idOperacion)
        {
            OperacionesDesbloqueo operacionesDesbloqueo = operacionesPersistencia.obtenerOperacionesDeDesbloqueoActual(idOperacion);
            return operacionesDesbloqueo;
        }

        public OperacionesModificacion obtenerOperacionesModificacionActual(string idOperacion)
        {
            OperacionesModificacion operacionesModificacion = operacionesPersistencia.obtenerOperacionesModificacionActual(idOperacion);
            return operacionesModificacion;
        }

        public List<Autorizaciones> obtenerOperacionesModificacion()
        {
            List<Autorizaciones> autorizacionesModificacion = operacionesPersistencia.obtenerOperacionesDeModificacion();
            return autorizacionesModificacion;
        }

        public Boolean AprobarEstadoAutorizacion(String idOperacion)
        {
            return operacionesPersistencia.AprobarEstadoAutorizacion(idOperacion);
        }

        public Boolean AgregarOperacionModificacion(Persona persona)
        {
            return operacionesPersistencia.AgregarOperacionModificacion(persona);
        }

    }
}
