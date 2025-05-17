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

        public Boolean AprobarEstadoAutorizacion(String idOperacion)
        {
            try
            {
                return dataBaseUtils.AprobarEstadoAutorizacion(idOperacion, "autorizacion.csv");
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
        public List<OperacionesModificacion> obtenerOperacionesDeModificacion()
        {
            List<OperacionesModificacion> operaciones = new List<OperacionesModificacion>();
            List<string> registros = dataBaseUtils.BuscarRegistro("operacion_cambio_persona.csv");

            if (registros != null && registros.Count > 0)
            {
                registros.RemoveAt(0);

                foreach (string linea in registros)
                {
                    try
                    {
                        OperacionesModificacion op = new OperacionesModificacion(linea);
                        operaciones.Add(op);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al parsear operación: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontraron registros en operacion_cambio_persona.csv.");
            }

            return operaciones;
        }

        public Boolean AgregarOperacionModificacion(Persona persona)
        {
            try
            {
                return dataBaseUtils.AgragarOperacionModificacion(
                    persona.Legajo,
                    persona.Nombre,
                    persona.Apellido,
                    persona.Dni,
                    "operacion_cambio_persona.csv"
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el método AgregarOperacionModificacion: {ex.Message}");
                return false;
            }
        }
    }
}
