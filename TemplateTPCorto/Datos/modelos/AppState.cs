using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Datos.modelos
{
   // La clase AppState debe ser tratada como un Singleton para garantizar que los datos del usuario logueado y sus roles se mantengan en memoria y sean accesibles de manera consistente en toda la aplicación.El patrón Singleton asegura que solo exista una única instancia de la clase durante el ciclo de vida de la aplicación, lo que es ideal para almacenar información global como el estado del usuario.
    public class AppState
    {
        private static AppState _instance;
        private static readonly object _lock = new object();

        public static AppState Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new AppState();
                        }
                    }
                }
                return _instance;
            }
        }

        public static Persona UsuarioActual { get; set; }
        public static List<string> Roles { get; set; } = new List<string>();

        // Constructor privado para evitar instanciación externa
        private AppState() { }
    }
}
