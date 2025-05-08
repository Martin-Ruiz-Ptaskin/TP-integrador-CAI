using Datos;
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

        public Boolean EliminarOperacionDesbloqueo(String idOperacion)
        {
            try
            {
                return dataBaseUtils.EliminarOperacionDesbloqueo(idOperacion, "operacion_cambio_credencial.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el método debloquear credencial: {ex.Message}");
            }
            return false;
        }

        public List<OperacionesDesbloqueo> obtenerOperacionesDeDesbloqueo()
        {
            List<OperacionesDesbloqueo> operacionesDesbloqueos = new List<OperacionesDesbloqueo>();
            List<String> listado = dataBaseUtils.BuscarRegistro("operacion_cambio_credencial.csv");

            if (listado != null && listado.Count > 0)
            {
                listado.RemoveAt(0);

                foreach (String operacionActual in listado)
                {
                    try
                    {
                        OperacionesDesbloqueo operacion = new OperacionesDesbloqueo(operacionActual);
                        operacionesDesbloqueos.Add(operacion);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al obtener las personas: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontraron registros en el archivo operacion_cambio_credencial.csv.");
            }

            return operacionesDesbloqueos;
        }
    }
}
