using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdministradorNegocio
    {
        private OperacionesPersistencia operacionesPersistencia = new OperacionesPersistencia();

        public Boolean AgregarOperacionDesbloqueo(String legajo, String nuevaContrasena)
        {
           return operacionesPersistencia.AgregarOperacionDesbloqueo(legajo, nuevaContrasena);
        }

        
    }
}
