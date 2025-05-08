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
    public partial class FormDesbloquearCredencial : Form
    {
        personaNegocio personaNegocio = new Negocio.personaNegocio();

        public FormDesbloquearCredencial()
        {
            InitializeComponent();
            List<Datos.Persona> personas = new List<Datos.Persona>();
            personas = personaNegocio.obtenerPersonas();
            usuariosListBox.SelectedIndexChanged -= usuariosListBox_SelectedIndexChanged;
            usuariosListBox.DataSource = personas;
            usuariosListBox.SelectedIndexChanged += usuariosListBox_SelectedIndexChanged;
        }

        private void usuariosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona personaSeleccionada = usuariosListBox.SelectedItem as Persona;
            if (personaSeleccionada != null)
            {
                DatosUsuarioLbl.Text = $"{personaSeleccionada.Legajo} - {personaSeleccionada.Nombre} {personaSeleccionada.Apellido}";
                DatosLbl.Visible = true;
                DatosUsuarioLbl.Visible = true;
                CambioContrasenaLbl.Visible = true;
                NuevaContrasenaTxt.Visible = true;
                ConfirmarCambioBtn.Visible = true;
                // Completar los campos de usuario

            }
        }

        private void NuevaContrasenaTxt_TextChanged(object sender, EventArgs e)
        {
            if (NuevaContrasenaTxt.Text != "") {
                ConfirmarCambioBtn.Enabled = true;
            }
            else
            {
                ConfirmarCambioBtn.Enabled = false;
            }
        }

        private void ConfirmarCambioBtn_Click(object sender, EventArgs e)
        {
            OperacionesNegocio operacionesNegocio = new OperacionesNegocio();
            Persona personaSeleccionada = usuariosListBox.SelectedItem as Persona;
            
            String nuevaContrasena = NuevaContrasenaTxt.Text;
            bool operacionAgregada = operacionesNegocio.AgregarOperacionDesbloqueo(personaSeleccionada.Legajo, nuevaContrasena);
            if (operacionAgregada)
            {
                MessageBox.Show($"Operacion agregada exitosamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*  TO-DO Mover esta logica a la pantalla de ADMINISTRADOR!, aca solo persistir operacion sin ejecutar.
            bool cambioExitoso = cambioContrasenaNegocio.CambioContrasena(personaSeleccionada.Legajo, nuevaContrasena, true);
            if (cambioExitoso)
            {
                bool desbloqueoExitoso = cambioContrasenaNegocio.DesbloquearCredencial(personaSeleccionada.Legajo);
                if (desbloqueoExitoso)
                {
                    MessageBox.Show($"El usuario: {personaSeleccionada.Legajo} - {personaSeleccionada.Nombre} {personaSeleccionada.Apellido}, fue desbloqueado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            */
        }
    }
}
