using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class OperacionesPersistencia
    {
        private DataBaseUtils dataBaseUtils = new DataBaseUtils();

        public Boolean AgregarOperacionDesbloqueo(String legajo, String nuevaContrasena)
        {
            try
            {
                return dataBaseUtils.AgragarOperacionDesbloqueo(legajo, nuevaContrasena, "operacion_cambio_credencial.csv", "credenciales.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el método debloquear credencial: {ex.Message}");
            }
            return false;
        }
    }
}
