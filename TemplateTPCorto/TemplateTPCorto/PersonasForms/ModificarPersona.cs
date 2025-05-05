using System;
using Datos;
using Negocio;
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
    public partial class modificarPersona : Form
    {
        new personaNegocio personaNegocio = new Negocio.personaNegocio();
        new Persona personaAmodificar = new Persona();
        public modificarPersona(Persona persona)
        {
            InitializeComponent();
            textNombre.Text = persona.Nombre;
            textApellido.Text = persona.Apellido;
            textDni.Text = persona.Dni.ToString();
            personaAmodificar = persona;

        }

        private void modificarPersona_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el DNI tenga el formato correcto  
                if (!EsDniValido(textDni.Text))
                {
                    MessageBox.Show("El DNI ingresado no es válido. Debe ser un número de 7 u 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener los nuevos valores de los campos de texto  
                personaAmodificar.Nombre = textNombre.Text;
                personaAmodificar.Apellido = textApellido.Text;
                personaAmodificar.Dni = textDni.Text;

                // Llamar al método de negocio para modificar la persona  
                personaNegocio.modificarPersona(personaAmodificar);

                // Mostrar un mensaje de éxito  
                MessageBox.Show("Persona modificada exitosamente.");

                // Cerrar el formulario  
                this.Close();
            }
            catch (Exception ex)
            {
                // Manejar excepciones y mostrar mensajes de error  
                MessageBox.Show($"Error al modificar la persona: {ex.Message}");
            }
        }
        private bool EsDniValido(string dni)
        {
            // Verificar que el DNI sea un número, contenga solo dígitos y tenga 7 u 8 caracteres
            return dni.All(char.IsDigit) && (dni.Length == 7 || dni.Length == 8);
        }
    }
}