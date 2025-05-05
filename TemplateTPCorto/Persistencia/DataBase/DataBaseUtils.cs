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

        public Boolean ModificarContrasenaPorLegajo(string legajo, string nuevaContrasena, string nombreArchivo)
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
                datosUsuario[4] = DateTime.Now.ToString("d/M/yyyy"); // Actualizar la fecha de último login
                var usuarioActualizado = string.Join(";", datosUsuario);
                registrosPorCargar.Add(usuarioActualizado);
                File.WriteAllLines(rutaArchivo, registrosPorCargar);
                Console.WriteLine($"Contraseña modificada correctamente para el legajo {legajo}.");
                return true;
            }
            catch (Exception e)
            {;
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

    }
}


