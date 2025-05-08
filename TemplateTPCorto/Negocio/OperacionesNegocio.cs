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

        public List<OperacionesDesbloqueo> obtenerOperaciones()
        {
            List<OperacionesDesbloqueo> operacionesDesbloqueo = operacionesPersistencia.obtenerOperacionesDeDesbloqueo();
            return operacionesDesbloqueo;
        }

        public Boolean EliminarOperacionPendiente(String idOperacion)
        {
            return operacionesPersistencia.EliminarOperacionDesbloqueo(idOperacion);
        }
    }
}
