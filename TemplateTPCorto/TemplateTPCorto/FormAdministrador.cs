using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormAdministrador : Form
    {
        AdministradorNegocio administradorNegocio = new AdministradorNegocio();
        OperacionesNegocio operacionesNegocio = new OperacionesNegocio();
        personaNegocio personaNegocio = new personaNegocio();
        Persona personaSeleccionada = new Persona();
        String registroAeliminar = String.Empty;
        public FormAdministrador()
        {
            InitializeComponent();
            List<Datos.OperacionesDesbloqueo> operacionesDeDesbloqueo = new List<Datos.OperacionesDesbloqueo>();
            operacionesDeDesbloqueo = operacionesNegocio.obtenerOperacionesDesbloqueo();
            OperacionesDesbloqueoListBox.SelectedIndexChanged -= OperacionesDesbloqueoListBox_SelectedIndexChanged;
            OperacionesDesbloqueoListBox.DisplayMember = "DisplayInfo";
            OperacionesDesbloqueoListBox.DataSource = operacionesDeDesbloqueo;
            OperacionesDesbloqueoListBox.SelectedIndexChanged += OperacionesDesbloqueoListBox_SelectedIndexChanged;

            obtenerOperacionesmodificacion();
        }

        private void OperacionesDesbloqueoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperacionesDesbloqueo operacionSeleccionada = OperacionesDesbloqueoListBox.SelectedItem as OperacionesDesbloqueo;
            AprobarDesbloqueoBtn.Enabled = true;
        }

        private void AprobarDesbloqueoBtn_Click(object sender, EventArgs e)
        {
            CambioContrasenaNegocio cambioContrasenaNegocio = new CambioContrasenaNegocio();
            OperacionesDesbloqueo operacionSeleccionada = OperacionesDesbloqueoListBox.SelectedItem as OperacionesDesbloqueo;
            bool cambioExitoso = cambioContrasenaNegocio.CambioContrasena(operacionSeleccionada.Legajo, operacionSeleccionada.Contrasena, true);
            if (cambioExitoso)
            {
                bool desbloqueoExitoso = cambioContrasenaNegocio.DesbloquearCredencial(operacionSeleccionada.Legajo);
                if (desbloqueoExitoso)
                {
                    bool operacionEliminada = operacionesNegocio.EliminarOperacionPendiente(operacionSeleccionada.IdOperacion);
                    if (operacionEliminada)
                    {
                        MessageBox.Show($"El usuario: {operacionSeleccionada.Legajo} - {operacionSeleccionada.NombreUsuario}, fue desbloqueado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al desbloquear el usuario, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Error al desbloquear el usuario, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al desbloquear el usuario, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<Datos.OperacionesDesbloqueo> operacionesDeDesbloqueo = new List<Datos.OperacionesDesbloqueo>();
            operacionesDeDesbloqueo = operacionesNegocio.obtenerOperacionesDesbloqueo();
            OperacionesDesbloqueoListBox.SelectedIndexChanged -= OperacionesDesbloqueoListBox_SelectedIndexChanged;
            OperacionesDesbloqueoListBox.DisplayMember = "DisplayInfo";
            OperacionesDesbloqueoListBox.DataSource = operacionesDeDesbloqueo;
            OperacionesDesbloqueoListBox.SelectedIndexChanged += OperacionesDesbloqueoListBox_SelectedIndexChanged;
        }

        private void OperacionesModificacionPersonaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperacionesModificacion operacionSeleccionada = OperacionesModificacionPersonaListBox.SelectedItem as OperacionesModificacion;
            AprobarModificacionBtn.Enabled = true;
            Console.WriteLine(operacionSeleccionada.ToString());
        }

        private void AprobarModificacionBtn_Click(object sender, EventArgs e)
        {
            /* OperacionesModificacion operacionSeleccionada = OperacionesModificacionPersonaListBox.SelectedItem as OperacionesModificacion;
             if (operacionSeleccionada != null)
             {
                 Persona personaModificada = new Persona
                 {
                     Legajo = operacionSeleccionada.Legajo,
                     Nombre = operacionSeleccionada.Nombre,
                     Apellido = operacionSeleccionada.Apellido,
                     Dni = operacionSeleccionada.Dni
                 };

                 PersonaPersistencia personaPersistencia = new PersonaPersistencia();
                 try
                 {
                     personaPersistencia.modificarPersona(personaModificada);

                     bool operacionEliminada = operacionesNegocio.EliminarOperacionModificacion(operacionSeleccionada.IdOperacion);
                     if (operacionEliminada)
                     {
                         MessageBox.Show($"La persona {operacionSeleccionada.Nombre} {operacionSeleccionada.Apellido} fue modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     else
                     {
                         MessageBox.Show("Error al procesar la modificación, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

                     List<OperacionesModificacion> operacionesModificacion = operacionesNegocio.obtenerOperacionesModificacion();
                     OperacionesModificacionPersonaListBox.SelectedIndexChanged -= OperacionesModificacionPersonaListBox_SelectedIndexChanged;
                     OperacionesModificacionPersonaListBox.DataSource = operacionesModificacion;
                     OperacionesModificacionPersonaListBox.SelectedIndexChanged += OperacionesModificacionPersonaListBox_SelectedIndexChanged;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show($"Error al modificar la persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
             {
                 MessageBox.Show("Por favor, seleccione una operación de modificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }*/
        }

       

        private void AprobarModificacionBtn_Click_2(object sender, EventArgs e)
        {
            try {
                personaNegocio.modificarPersonaPersitencia(personaSeleccionada, registroAeliminar);

                obtenerOperacionesmodificacion();
                MessageBox.Show($"La persona {personaSeleccionada.Nombre} {personaSeleccionada.Apellido} fue modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Error al modificar la persona, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperacionesModificacionPersonaListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            OperacionesModificacion operacionSeleccionada = OperacionesModificacionPersonaListBox.SelectedItem as OperacionesModificacion;
            registroAeliminar=operacionSeleccionada.IdOperacion;
            if (operacionSeleccionada != null)
            {
                // Crear la cadena en formato CSV
                string datosPersona = $"{operacionSeleccionada.Legajo};{operacionSeleccionada.Nombre};{operacionSeleccionada.Apellido};{operacionSeleccionada.Dni};{operacionSeleccionada.FechaIngreso:dd/MM/yyyy}";


                // Opcional: Mostrar información de la persona en consola o en la interfaz
                Console.WriteLine($"Persona instanciada: {personaSeleccionada.Nombre} {personaSeleccionada.Apellido}, DNI: {personaSeleccionada.Dni}");
                // Instanciar la persona usando el constructor que acepta una cadena CSV
                personaSeleccionada = new Persona(datosPersona);

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una operación válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void obtenerOperacionesmodificacion()
        {

            List<OperacionesModificacion> operacionesModificacion = new List<OperacionesModificacion>();
            operacionesModificacion = operacionesNegocio.obtenerOperacionesModificacion();
            OperacionesModificacionPersonaListBox.SelectedIndexChanged -= OperacionesModificacionPersonaListBox_SelectedIndexChanged;
            OperacionesModificacionPersonaListBox.DisplayMember = "DisplayInfo";
            OperacionesModificacionPersonaListBox.DataSource = operacionesModificacion;
            OperacionesModificacionPersonaListBox.SelectedIndexChanged += OperacionesModificacionPersonaListBox_SelectedIndexChanged;
        }
    }
}
