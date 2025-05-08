namespace TemplateTPCorto
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificarPersona = new System.Windows.Forms.Button();
            this.btnDesbloquearCredencial = new System.Windows.Forms.Button();
            this.btnAutorizaciones = new System.Windows.Forms.Button();
            this.btnOperador = new System.Windows.Forms.Button();
            this.gbSupervisor = new System.Windows.Forms.GroupBox();
            this.gbAdministrador = new System.Windows.Forms.GroupBox();
            this.gbOperador = new System.Windows.Forms.GroupBox();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.gbSupervisor.SuspendLayout();
            this.gbAdministrador.SuspendLayout();
            this.gbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(0, 11);
            this.btnModificarPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(649, 49);
            this.btnModificarPersona.TabIndex = 0;
            this.btnModificarPersona.Text = "Modificar Persona";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            this.btnModificarPersona.Click += new System.EventHandler(this.btnModificarPersona_Click);
            // 
            // btnDesbloquearCredencial
            // 
            this.btnDesbloquearCredencial.Location = new System.Drawing.Point(0, 68);
            this.btnDesbloquearCredencial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesbloquearCredencial.Name = "btnDesbloquearCredencial";
            this.btnDesbloquearCredencial.Size = new System.Drawing.Size(649, 49);
            this.btnDesbloquearCredencial.TabIndex = 1;
            this.btnDesbloquearCredencial.Text = "Desbloquear Credencial";
            this.btnDesbloquearCredencial.UseVisualStyleBackColor = true;
            this.btnDesbloquearCredencial.Click += new System.EventHandler(this.btnDesbloquearCredencial_Click);
            // 
            // btnAutorizaciones
            // 
            this.btnAutorizaciones.Location = new System.Drawing.Point(0, 0);
            this.btnAutorizaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutorizaciones.Name = "btnAutorizaciones";
            this.btnAutorizaciones.Size = new System.Drawing.Size(649, 49);
            this.btnAutorizaciones.TabIndex = 2;
            this.btnAutorizaciones.Text = "Autorizaciones";
            this.btnAutorizaciones.UseVisualStyleBackColor = true;
            this.btnAutorizaciones.Click += new System.EventHandler(this.btnAutorizaciones_Click);
            // 
            // btnOperador
            // 
            this.btnOperador.Location = new System.Drawing.Point(0, 1);
            this.btnOperador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperador.Name = "btnOperador";
            this.btnOperador.Size = new System.Drawing.Size(649, 49);
            this.btnOperador.TabIndex = 3;
            this.btnOperador.Text = "Ir a fase 2";
            this.btnOperador.UseVisualStyleBackColor = true;
            this.btnOperador.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // gbSupervisor
            // 
            this.gbSupervisor.Controls.Add(this.btnModificarPersona);
            this.gbSupervisor.Controls.Add(this.btnDesbloquearCredencial);
            this.gbSupervisor.Location = new System.Drawing.Point(169, 89);
            this.gbSupervisor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSupervisor.Name = "gbSupervisor";
            this.gbSupervisor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSupervisor.Size = new System.Drawing.Size(649, 118);
            this.gbSupervisor.TabIndex = 4;
            this.gbSupervisor.TabStop = false;
            // 
            // gbAdministrador
            // 
            this.gbAdministrador.Controls.Add(this.btnAutorizaciones);
            this.gbAdministrador.Location = new System.Drawing.Point(169, 225);
            this.gbAdministrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdministrador.Name = "gbAdministrador";
            this.gbAdministrador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdministrador.Size = new System.Drawing.Size(649, 54);
            this.gbAdministrador.TabIndex = 5;
            this.gbAdministrador.TabStop = false;
            // 
            // gbOperador
            // 
            this.gbOperador.Controls.Add(this.btnOperador);
            this.gbOperador.Location = new System.Drawing.Point(169, 304);
            this.gbOperador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOperador.Name = "gbOperador";
            this.gbOperador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOperador.Size = new System.Drawing.Size(649, 50);
            this.gbOperador.TabIndex = 6;
            this.gbOperador.TabStop = false;
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Location = new System.Drawing.Point(169, 377);
            this.btnCambiarContrasena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(649, 49);
            this.btnCambiarContrasena.TabIndex = 7;
            this.btnCambiarContrasena.Text = "Cambiar contrasena";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCambiarContrasena);
            this.Controls.Add(this.gbOperador);
            this.Controls.Add(this.gbAdministrador);
            this.Controls.Add(this.gbSupervisor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.gbSupervisor.ResumeLayout(false);
            this.gbAdministrador.ResumeLayout(false);
            this.gbOperador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarPersona;
        private System.Windows.Forms.Button btnDesbloquearCredencial;
        private System.Windows.Forms.Button btnAutorizaciones;
        private System.Windows.Forms.Button btnOperador;
        private System.Windows.Forms.GroupBox gbSupervisor;
        private System.Windows.Forms.GroupBox gbAdministrador;
        private System.Windows.Forms.GroupBox gbOperador;
        private System.Windows.Forms.Button btnCambiarContrasena;
    }
}