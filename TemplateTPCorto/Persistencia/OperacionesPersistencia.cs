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

        public List<Autorizaciones> obtenerOperacionesDeDesbloqueo()
        {
            List<Autorizaciones> autorizaciones = new List<Autorizaciones>();
            List<String> listado = dataBaseUtils.BuscarRegistro("autorizacion.csv");

            if (listado != null && listado.Count > 0)
            {
                listado.RemoveAt(0);

                foreach (String autorizacionActual in listado)
                {
                    try
                    {
                        Autorizaciones autorizacionAgregar = new Autorizaciones(autorizacionActual);
                        if(autorizacionAgregar.estado == "Pendiente" && autorizacionAgregar.tipoOperacion == "desbloqueoCredencial")
                        {
                           autorizaciones.Add(autorizacionAgregar);
                        }
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

            return autorizaciones;
        }

        public OperacionesDesbloqueo obtenerOperacionesDeDesbloqueoActual(string idOperacion)
        {
            List<String> listado = dataBaseUtils.BuscarRegistro("operacion_cambio_credencial.csv");

            if (listado != null && listado.Count > 0)
            {
                listado.RemoveAt(0);

                foreach (String operacionActual in listado)
                {
                    try
                    {
                        OperacionesDesbloqueo datosOperacionActual = new OperacionesDesbloqueo(operacionActual);
                        if(datosOperacionActual.IdOperacion == idOperacion)
                        {
                            return datosOperacionActual;
                        }
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

            return null;
        }

        public OperacionesModificacion obtenerOperacionesModificacionActual(string idOperacion)
        {
            List<String> listado = dataBaseUtils.BuscarRegistro("operacion_cambio_persona.csv");

            if (listado != null && listado.Count > 0)
            {
                listado.RemoveAt(0);

                foreach (String operacionActual in listado)
                {
                    try
                    {
                        OperacionesModificacion datosOperacionActual = new OperacionesModificacion(operacionActual);
                        if (datosOperacionActual.IdOperacion == idOperacion)
                        {
                            return datosOperacionActual;
                        }
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

            return null;
        }

        public List<Autorizaciones> obtenerOperacionesDeModificacion()
        {
            List<Autorizaciones> autorizaciones = new List<Autorizaciones>();
            List<string> registros = dataBaseUtils.BuscarRegistro("autorizacion.csv");

            if (registros != null && registros.Count > 0)
            {
                registros.RemoveAt(0);

                foreach (string linea in registros)
                {
                    try
                    {
                        Autorizaciones autorizacionAgregar = new Autorizaciones(linea);
                        if (autorizacionAgregar.estado == "Pendiente" && autorizacionAgregar.tipoOperacion == "modificarPersona")
                        {
                            autorizaciones.Add(autorizacionAgregar);
                        }

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

            return autorizaciones;
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
