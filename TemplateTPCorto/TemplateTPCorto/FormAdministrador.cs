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
        public FormAdministrador()
        {
            InitializeComponent();
            List<Datos.OperacionesDesbloqueo> operacionesDeDesbloqueo = new List<Datos.OperacionesDesbloqueo>();
            operacionesDeDesbloqueo = operacionesNegocio.obtenerOperaciones();
            OperacionesDesbloqueoListBox.SelectedIndexChanged -= OperacionesDesbloqueoListBox_SelectedIndexChanged;
            OperacionesDesbloqueoListBox.DisplayMember = "DisplayInfo";
            OperacionesDesbloqueoListBox.DataSource = operacionesDeDesbloqueo;
            OperacionesDesbloqueoListBox.SelectedIndexChanged += OperacionesDesbloqueoListBox_SelectedIndexChanged;
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
            operacionesDeDesbloqueo = operacionesNegocio.obtenerOperaciones();
            OperacionesDesbloqueoListBox.SelectedIndexChanged -= OperacionesDesbloqueoListBox_SelectedIndexChanged;
            OperacionesDesbloqueoListBox.DisplayMember = "NombreUsuario";
            OperacionesDesbloqueoListBox.DataSource = operacionesDeDesbloqueo;
            OperacionesDesbloqueoListBox.SelectedIndexChanged += OperacionesDesbloqueoListBox_SelectedIndexChanged;
        }

        
    }
}
