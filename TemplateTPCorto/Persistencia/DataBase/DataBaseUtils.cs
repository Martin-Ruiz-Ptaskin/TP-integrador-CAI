using Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DataBase
{
    public class DataBaseUtils
    {
        // Ruta base constante
        private readonly string archivoCsv = Path.GetFullPath(Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        @"..\..\..\Persistencia\DataBase\Tablas"
        ));

        public List<String> BuscarRegistro(String nombreArchivo)
        {
            // Construir la ruta completa sin modificar archivoCsv
            string rutaArchivo = Path.Combine(archivoCsv, nombreArchivo);

            List<String> listado = new List<String>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        listado.Add(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return listado;
        }

        public void BorrarRegistro(string id, String nombreArchivo)
        {
            // Construir la ruta completa sin modificar archivoCsv
            string rutaArchivo = Path.Combine(archivoCsv, nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }

                // Leer el archivo y obtener las líneas
                List<string> listado = BuscarRegistro(nombreArchivo);

                // Filtrar las líneas que no coinciden con el ID a borrar (comparar solo la primera columna)
                var registrosRestantes = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != id; // Verifica solo el ID (primera columna)
                }).ToList();

                // Sobrescribir el archivo con las líneas restantes
                File.WriteAllLines(rutaArchivo, registrosRestantes);

                Console.WriteLine($"Registro con ID {id} borrado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar borrar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        public void AgregarRegistro(string nombreArchivo, string nuevoRegistro)
        {
            // Construir la ruta completa sin modificar archivoCsv
            string rutaArchivo = Path.Combine(archivoCsv, nombreArchivo);

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }

                // Abrir el archivo y agregar el nuevo registro
                using (StreamWriter sw = new StreamWriter(rutaArchivo, append: true))
                {
                    sw.WriteLine(nuevoRegistro); // Agregar la nueva línea
                }

                Console.WriteLine("Registro agregado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar agregar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        public Boolean ModificarContrasenaPorLegajo(string legajo, string nuevaContrasena, string nombreArchivo, Boolean? esDesbloqueo)
        {
            string rutaArchivo = Path.Combine(archivoCsv, nombreArchivo);
            try
            {
                List<string> listado = BuscarRegistro(nombreArchivo);
                var registrosPorCargar = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != legajo;
                }).ToList();
                var usuarioAModificar = listado.FirstOrDefault(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] == legajo;
                });
                var datosUsuario = usuarioAModificar.Split(';');
                datosUsuario[2] = nuevaContrasena; // Cambiar la contraseña
                // Actualizar la fecha de último login, si es un desbloqueo, queda vacio
                datosUsuario[4] = esDesbloqueo == true ? "" : DateTime.Now.ToString("d/M/yyyy");
                var usuarioActualizado = string.Join(";", datosUsuario);
                registrosPorCargar.Add(usuarioActualizado);
                File.WriteAllLines(rutaArchivo, registrosPorCargar);
                Console.WriteLine($"Contraseña modificada correctamente para el legajo {legajo}.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al intentar modificar la contraseña: {e.Message}");
            }
            return false;
        }

        public Boolean ModificarFechaPorLegajo(string legajo, string nombreArchivo)
        {
            string rutaArchivo = Path.Combine(archivoCsv, nombreArchivo);
            try
            {
                List<string> listado = BuscarRegistro(nombreArchivo);
                var registrosPorCargar = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != legajo;
                }).ToList();

                var usuarioAModificar = listado.FirstOrDefault(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] == legajo;
                });

                if (usuarioAModificar == null)
                {
                    Console.WriteLine($"No se encontró un usuario con el legajo {legajo}.");
                    return false;
                }

                var datosUsuario = usuarioAModificar.Split(';');
                datosUsuario[4] = DateTime.Now.ToString("d/M/yyyy"); // Actualizar solo la fecha

                var usuarioActualizado = string.Join(";", datosUsuario);
                registrosPorCargar.Add(usuarioActualizado);
                File.WriteAllLines(rutaArchivo, registrosPorCargar);

                Console.WriteLine($"Fecha actualizada correctamente para el legajo {legajo}.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al intentar modificar la fecha: {e.Message}");
            }

            return false;
        }




        public void ModificarRegistro(string nombreArchivo, string id, string nuevoRegistro)
        {
            // Construir la ruta completa sin modificar archivoCsv
            string rutaArchivo = Path.Combine(archivoCsv, nombreArchivo);
            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("El archivo no existe: " + rutaArchivo);
                    return;
                }
                // Leer el archivo y obtener las líneas
                List<string> listado = BuscarRegistro(nombreArchivo);
                // Filtrar las líneas que no coinciden con el ID a modificar (comparar solo la primera columna)
                var registrosRestantes = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != id; // Verifica solo el ID (primera columna)
                }).ToList();
                // Agregar el nuevo registro al final de la lista
                registrosRestantes.Add(nuevoRegistro);
                // Sobrescribir el archivo con las líneas restantes y el nuevo registro
                File.WriteAllLines(rutaArchivo, registrosRestantes);
                Console.WriteLine($"Registro con ID {id} modificado correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al intentar modificar el registro:");
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Pila de errores: {e.StackTrace}");
            }
        }

        public Boolean DesbloquearCredencial(string legajo, string nombreArchivoUsuariosBloqueados, string nombreArchivoIntentosLogin )
        {
            string rutaArchivoUsuariosBloqueados = Path.Combine(archivoCsv, nombreArchivoUsuariosBloqueados);
            string rutaArchivoIntentosLogin = Path.Combine(archivoCsv, nombreArchivoIntentosLogin);
            try
            {
                List<string> listado = BuscarRegistro(nombreArchivoUsuariosBloqueados);
                var registrosPorMantener = listado.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != legajo;
                }).ToList();
                File.WriteAllLines(rutaArchivoUsuariosBloqueados, registrosPorMantener);
                List<string> listadoIntentosLogin = BuscarRegistro(nombreArchivoIntentosLogin);
                var registrosPorMantenerLogin = listadoIntentosLogin.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != legajo;
                }).ToList();
                File.WriteAllLines(rutaArchivoIntentosLogin, registrosPorMantenerLogin);
                Console.WriteLine($"El usuario {legajo} fue desbloqueado.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al intentar desbloquear usuario: {e.Message}");
            }
            return false;
        }

        public Boolean AgragarOperacionDesbloqueo(string legajo, string nuevaContrasena, string archivoOperaciones, string archivoCredenciales)
        {
            string rutaOperaciones = Path.Combine(archivoCsv, archivoOperaciones);
            Random random = new Random();
            try
            {
                List<string> listadoUsuarios = BuscarRegistro(archivoCredenciales);
                var usuarioOperado = listadoUsuarios.FirstOrDefault(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] == legajo;
                });
                List<string> listadoOperaciones = BuscarRegistro(archivoOperaciones);
                var registrosPorCargar = listadoOperaciones.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != legajo;
                }).ToList();
                var datosUsuarioDeLaOperacion = usuarioOperado.Split(';');
                string[] datosOperacion = new string[7];
                datosOperacion[0] = random.Next(0, 100000000).ToString("D8");  //id operacion (random)
                datosOperacion[1] = legajo;  // legajo
                datosOperacion[2] = datosUsuarioDeLaOperacion[1]; // nombre de usuario
                datosOperacion[3] = nuevaContrasena;  // contraseña nueva
                datosOperacion[4] = "2"; // id perfil
                datosOperacion[5] = datosUsuarioDeLaOperacion[3];  // Fecha de alta
                datosOperacion[6] = datosUsuarioDeLaOperacion[4];  // Fecha ultimo login
                var operacionNueva = string.Join(";", datosOperacion);
                registrosPorCargar.Add(operacionNueva);
                File.WriteAllLines(rutaOperaciones, registrosPorCargar);
                Console.WriteLine($"Operacion agregada a persistencia");

                //idOperacion;tipoOperacion;estado;legajoSolicitante;fechaSolicitud;legajoAutorizador;fechaAutorizacion
                string rutaAutorizaciones = Path.Combine(archivoCsv, "autorizacion.csv");
                List<string> listadoAutorizaciones = BuscarRegistro("autorizacion.csv");
                var autorizacionPorCargar = listadoAutorizaciones.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != datosOperacion[0];
                }).ToList();
                string[] datosAutorizacion = new string[7];
                datosAutorizacion[0] = datosOperacion[0];
                datosAutorizacion[1] = "desbloqueoCredencial";
                datosAutorizacion[2] = "Pendiente";
                datosAutorizacion[3] = "Pendiente de agregar"; //Legajo usuario actual pendiente de agregar
                datosAutorizacion[4] = DateTime.Now.ToString("d/M/yyyy");
                datosAutorizacion[5] = " ";
                datosAutorizacion[6] = " ";
                var autorizacionNueva = string.Join(";", datosAutorizacion);
                autorizacionPorCargar.Add(autorizacionNueva);
                File.WriteAllLines(rutaAutorizaciones, autorizacionPorCargar);
                Console.WriteLine($"Autorizacion agregada a persistencia");
                return true;
            }
            catch (Exception e)
            {
                ;
                Console.WriteLine($"Error al persistir la operacion: {e.Message}");
            }
            return false;
        }


        public Boolean AprobarEstadoAutorizacion(string idOperacion, string archivoAutorizaciones)
        {
            string rutaAutorizaciones = Path.Combine(archivoCsv, archivoAutorizaciones);
            try
            {
                List<string> listadoAutorizaciones = BuscarRegistro(archivoAutorizaciones);
                var autorizacionesPorCargar = listadoAutorizaciones.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != idOperacion;
                }).ToList();

                var autorizacionActual = listadoAutorizaciones.FirstOrDefault(linea => linea.Split(';')[0] == idOperacion);
                var datosAutorizacionActual = autorizacionActual.Split(';');

                string[] datosAutorizacionNuevos = new string[7];

                datosAutorizacionNuevos[0] = idOperacion;
                datosAutorizacionNuevos[1] = datosAutorizacionActual[1];
                datosAutorizacionNuevos[2] = "Aprobado";
                datosAutorizacionNuevos[3] = datosAutorizacionActual[3];
                datosAutorizacionNuevos[4] = datosAutorizacionActual[4];
                datosAutorizacionNuevos[5] = " "; //Legajo usuario actual pendiente de agregar
                datosAutorizacionNuevos[6] = DateTime.Now.ToString("d/M/yyyy");
                var autorizacionNueva = string.Join(";", datosAutorizacionNuevos);
                autorizacionesPorCargar.Add(autorizacionNueva);
                File.WriteAllLines(rutaAutorizaciones, autorizacionesPorCargar);
                Console.WriteLine($"Operacion aprobada en persistencia");
                return true;
            }
            catch (Exception e)
            {
                ;
                Console.WriteLine($"Error al eliminar la operacion: {e.Message}");
            }
            return false;
        }

        public Boolean AgragarOperacionModificacion(string legajo, string nombre, string apellido, string dni, string archivoOperaciones)
        {
            try
            {
                string rutaOperaciones = Path.Combine(archivoCsv, archivoOperaciones);
                Random random = new Random();

                List<string> listadoOperaciones = BuscarRegistro(archivoOperaciones);
                var registrosPorCargar = listadoOperaciones.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != legajo;
                }).ToList();

                string[] datosOperacion = new string[6];
                datosOperacion[0] = random.Next(0, 100000000).ToString("D8");
                datosOperacion[1] = legajo;
                datosOperacion[2] = nombre;
                datosOperacion[3] = apellido;
                datosOperacion[4] = dni;
                datosOperacion[5] = DateTime.Now.ToString("d/M/yyyy");

                var operacionNueva = string.Join(";", datosOperacion);
                registrosPorCargar.Add(operacionNueva);
                File.WriteAllLines(rutaOperaciones, registrosPorCargar);

                string rutaAutorizaciones = Path.Combine(archivoCsv, "autorizacion.csv");
                List<string> listadoAutorizaciones = BuscarRegistro("autorizacion.csv");
                var autorizacionPorCargar = listadoAutorizaciones.Where(linea =>
                {
                    var campos = linea.Split(';');
                    return campos[0] != datosOperacion[0];
                }).ToList();
                string[] datosAutorizacion = new string[7];
                datosAutorizacion[0] = datosOperacion[0];
                datosAutorizacion[1] = "modificarPersona";
                datosAutorizacion[2] = "Pendiente";
                datosAutorizacion[3] = "Pendiente de agregar"; //Legajo usuario actual pendiente de agregar
                datosAutorizacion[4] = DateTime.Now.ToString("d/M/yyyy");
                datosAutorizacion[5] = " ";
                datosAutorizacion[6] = " ";
                var autorizacionNueva = string.Join(";", datosAutorizacion);
                autorizacionPorCargar.Add(autorizacionNueva);
                File.WriteAllLines(rutaAutorizaciones, autorizacionPorCargar);
                Console.WriteLine($"Autorizacion agregada a persistencia");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al persistir la operacion: {e.Message}");
            }

            return false;
        }
    }
}


