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
            List<Datos.Autorizaciones> operacionesDeDesbloqueo = new List<Datos.Autorizaciones>();
            operacionesDeDesbloqueo = operacionesNegocio.obtenerAutorizacionesDesbloqueo();
            OperacionesDesbloqueoListBox.SelectedIndexChanged -= OperacionesDesbloqueoListBox_SelectedIndexChanged;
            OperacionesDesbloqueoListBox.DisplayMember = "DisplayInfo";
            OperacionesDesbloqueoListBox.DataSource = operacionesDeDesbloqueo;
            OperacionesDesbloqueoListBox.SelectedIndexChanged += OperacionesDesbloqueoListBox_SelectedIndexChanged;

            obtenerOperacionesmodificacion();
        }

        private void OperacionesDesbloqueoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autorizaciones operacionSeleccionada = OperacionesDesbloqueoListBox.SelectedItem as Autorizaciones;
            AprobarDesbloqueoBtn.Enabled = true;
        }

        private void AprobarDesbloqueoBtn_Click(object sender, EventArgs e)
        {
            CambioContrasenaNegocio cambioContrasenaNegocio = new CambioContrasenaNegocio();
            Autorizaciones autorizacionSeleccionada = OperacionesDesbloqueoListBox.SelectedItem as Autorizaciones;
            OperacionesDesbloqueo operacionSeleccionada = operacionesNegocio.obtenerOperacionesDeDesbloqueoActual(autorizacionSeleccionada.idOperacion);
            bool cambioExitoso = cambioContrasenaNegocio.CambioContrasena(operacionSeleccionada.Legajo, operacionSeleccionada.Contrasena, true);
            if (cambioExitoso)
            {
                bool desbloqueoExitoso = cambioContrasenaNegocio.DesbloquearCredencial(operacionSeleccionada.Legajo);
                if (desbloqueoExitoso)
                {
                    
                    bool operacionEliminada = operacionesNegocio.AprobarEstadoAutorizacion(operacionSeleccionada.IdOperacion);
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
            List<Datos.Autorizaciones> operacionesDeDesbloqueo = new List<Datos.Autorizaciones>();
            operacionesDeDesbloqueo = operacionesNegocio.obtenerAutorizacionesDesbloqueo();
            OperacionesDesbloqueoListBox.SelectedIndexChanged -= OperacionesDesbloqueoListBox_SelectedIndexChanged;
            OperacionesDesbloqueoListBox.DisplayMember = "DisplayInfo";
            OperacionesDesbloqueoListBox.DataSource = operacionesDeDesbloqueo;
            OperacionesDesbloqueoListBox.SelectedIndexChanged += OperacionesDesbloqueoListBox_SelectedIndexChanged;
        }

        private void OperacionesModificacionPersonaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperacionesModificacion operacionSeleccionada = OperacionesModificacionPersonaListBox.SelectedItem as OperacionesModificacion;
            AprobarModificacionBtn.Enabled = true;
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
            Autorizaciones autorizacionSeleccionada = OperacionesModificacionPersonaListBox.SelectedItem as Autorizaciones;
            OperacionesModificacion operacionSeleccionada = operacionesNegocio.obtenerOperacionesModificacionActual(autorizacionSeleccionada.idOperacion);
            registroAeliminar =operacionSeleccionada.IdOperacion;
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
            List<Autorizaciones> operacionesModificacion = new List<Autorizaciones>();
            operacionesModificacion = operacionesNegocio.obtenerOperacionesModificacion();
            OperacionesModificacionPersonaListBox.SelectedIndexChanged -= OperacionesModificacionPersonaListBox_SelectedIndexChanged;
            OperacionesModificacionPersonaListBox.DisplayMember = "DisplayInfo";
            OperacionesModificacionPersonaListBox.DataSource = operacionesModificacion;
            OperacionesModificacionPersonaListBox.SelectedIndexChanged += OperacionesModificacionPersonaListBox_SelectedIndexChanged;
        }
    }
}
