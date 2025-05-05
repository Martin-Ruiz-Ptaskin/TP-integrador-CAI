using System;
using Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace TemplateTPCorto.PersonasForms
{
    public partial class ListaPersonas : Form
    {
        new personaNegocio personaNegocio = new Negocio.personaNegocio();
        public ListaPersonas()
        {
            InitializeComponent();
            // Inicializar la lista de personas
            List<Datos.Persona> personas = new List<Datos.Persona>();
            // Llenar la lista de personas con datos de ejemplo
            personas = personaNegocio.obtenerPersonas();
            // Asignar la lista de personas al ListBox
            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

            listBox1.DataSource = personas;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Persona personaSeleccionada = listBox1.SelectedItem as Persona;
            if (personaSeleccionada != null)
            {
                {
                    // Crear una instancia del formulario ModificarPersona

                    // Mostrar el formulario como un cuadro de diálogo
                    modificarPersona modificarForm = new modificarPersona(personaSeleccionada);

                    modificarForm.ShowDialog();

                    // Actualizar la lista de personas después de modificar
                   
                }
                // Aquí puedes usar todas las propiedades del objeto Persona
            }

        }

        /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //abrir Form de modificar personas
            Persona personaSeleccionada = listBox1.SelectedItem as Persona;

            if (personaSeleccionada != null)
            {
                // Crear una instancia del formulario ModificarPersona

                // Mostrar el formulario como un cuadro de diálogo
                modificarPersona modificarForm = new modificarPersona(personaSeleccionada);

                modificarForm.ShowDialog();

                // Actualizar la lista de personas después de modificar
                listBox1.DataSource = null;
                listBox1.DataSource = personaNegocio.obtenerPersonas();
            }

        }*/
    }
}
