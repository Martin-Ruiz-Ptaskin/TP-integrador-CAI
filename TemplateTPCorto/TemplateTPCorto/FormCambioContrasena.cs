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
    public partial class FormCambioContrasena : Form
    {
        private Credencial _credencial;
        public FormCambioContrasena(Credencial credencial)
        {
            InitializeComponent();
            _credencial = credencial;
        }

        private void NuevaContrasenaBtn_Click(object sender, EventArgs e)
        {
            CambioContrasenaNegocio cambioContrasenaNegocio = new CambioContrasenaNegocio();
            String nuevaContrasena = NuevaContrasenaTxt.Text;
            if(_credencial.Contrasena != nuevaContrasena)
            {
                bool cambioExitoso = cambioContrasenaNegocio.CambioContrasena(_credencial.Legajo, nuevaContrasena);
                if (cambioExitoso)
                {
                    MessageBox.Show("Su contraseña fue modificada correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                }
                else
                {
                    MessageBox.Show("Error al cambiar la contraseña, intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a la anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void NuevaContrasenaTxt_TextChanged(object sender, EventArgs e)
        {
            if (NuevaContrasenaTxt.Text.Length >= 8)
            {
                NuevaContrasenaBtn.Enabled = true;
            }
            else
            {
                NuevaContrasenaBtn.Enabled = false;
            }
        }
    }
}
