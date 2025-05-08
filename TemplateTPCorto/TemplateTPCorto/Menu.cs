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
using TemplateTPCorto.PersonasForms;

namespace TemplateTPCorto
{
    public partial class Menu : Form
    {
        private string legajo;
        private string usuario;
        private Credencial credencial;
        private List<string> roles;

        public Menu(string _legajo, string _usuario, Credencial _credencial)
        {
            InitializeComponent();
            legajo = _legajo;
            usuario = _usuario;
            gbSupervisor.Visible = false;
            gbAdministrador.Visible = false;
            gbOperador.Visible = false;
            mostrarFuncionesSegunRol(legajo);
            credencial = _credencial;
        }
        LoginNegocio loginNegocio = new LoginNegocio();
        //            roles = loginNegocio.obtenerRolesPorLegajo(legajo);

        private void mostrarFuncionesSegunRol(string legajo)
        {
            roles = loginNegocio.obtenerRolesPorLegajo(legajo);

            foreach (string rol in roles) { 
            
                if(rol == "1")
                {
                    gbOperador.Visible = true;
                }
                if (rol == "2")
                {
                    gbSupervisor.Visible= true;
                }
                if (rol == "3")
                {
                    gbAdministrador.Visible = true;
                }
             
            }
        }

        private void btnDesbloquearCredencial_Click(object sender, EventArgs e)
        {
            FormDesbloquearCredencial desbloquearCredencial = new FormDesbloquearCredencial();
            desbloquearCredencial.Show();
        }

        private void btnAutorizaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            ListaPersonas listaPersonas = new ListaPersonas();
            listaPersonas.Show();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            FormCambioContrasena formCambioObligatorioContrasena = new FormCambioContrasena(credencial);
            formCambioObligatorioContrasena.Show();
        }
    }
}
