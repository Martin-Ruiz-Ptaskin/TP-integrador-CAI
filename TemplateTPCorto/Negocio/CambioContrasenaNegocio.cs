using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CambioContrasenaNegocio
    {
        private UsuarioPersistencia usuarioPersistencia = new UsuarioPersistencia();

        public Boolean CambioContrasena(String legajo, String nuevaContrasena, Boolean? esDesbloqueo = null)
        {
           return usuarioPersistencia.cambiarContrasena(legajo, nuevaContrasena, esDesbloqueo);
        }

        public Boolean DesbloquearCredencial(String legajo)
        {
            return usuarioPersistencia.desbloquearCredencial(legajo);
        }
    }
}
