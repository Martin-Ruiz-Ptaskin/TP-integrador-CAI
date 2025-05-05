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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "zachary.mills";
            txtPassword.Text = "+OEDT#4j97";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;

            LoginNegocio loginNegocio = new LoginNegocio();
            
            Credencial credencial = loginNegocio.login(usuario, password);
            var legajo = loginNegocio.obtenerLegajoPorNombre(usuario);

            if (credencial != null)
            {
                var usuarioBloqueado = loginNegocio.ValidarUsuarioBloqueado(credencial.Legajo);
                if (usuarioBloqueado) {
                    MessageBox.Show("¡El Usuario se encuentra bloqueado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {
                    // Verificar si es el primer login, si es enviar a la pantalla de actualizacion. si no, login exitoso.
                    bool esPrimerLogin = credencial.FechaUltimoLogin == null;
                    if (esPrimerLogin)
                    {
                        DialogResult messageBoxResponse = MessageBox.Show("Usted debe cambiar su contraseña", "Primer LogIn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if(messageBoxResponse == DialogResult.OK)
                        {
                            this.Hide();
                            FormCambioObligatorioContrasena formCambioObligatorioContrasena = new FormCambioObligatorioContrasena(credencial);
                            formCambioObligatorioContrasena.Show();
                        }
                    }
                    else
                    {
                        bool contrasenaVencida = credencial.FechaUltimoLogin < DateTime.Now.AddDays(-30);
                        if (contrasenaVencida)
                        {
                            DialogResult messageBoxResponse = MessageBox.Show("Usted debe cambiar su contraseña", "Contraseña Vencida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (messageBoxResponse == DialogResult.OK)
                            {
                                this.Hide();
                                FormCambioObligatorioContrasena formCambioObligatorioContrasena = new FormCambioObligatorioContrasena(credencial);
                                formCambioObligatorioContrasena.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Segun consigna tenemos que actualizar la fecha en cada Inicio de Sesion
                            loginNegocio.actualizarFechaLogin(legajo);
                            this.Hide();
                            Menu menu = new Menu(legajo, usuario, credencial);
                            menu.Show();
                        }
                    }
                }
            }
            else
            {
                var usuarioBloqueado = loginNegocio.ValidarUsuarioBloqueado(legajo);

                if (legajo != null)
                {
                    if(usuarioBloqueado)
                    {
                        MessageBox.Show("¡El Usuario se encuentra bloqueado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Si el usuario existe, registrar el intento de login fallido
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        loginNegocio.intentoLoginFallido(legajo);
                    }
                    // Si el usuario no está bloqueado, registrar el intento de login fallido
                }
                
            }

        }
    }
}
