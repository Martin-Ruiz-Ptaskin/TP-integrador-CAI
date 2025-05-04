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

        public Boolean cambioObligatorio(String legajo, String nuevaContrasena)
        {
           return usuarioPersistencia.cambiarContrasena(legajo, nuevaContrasena);
        }
    }
}
