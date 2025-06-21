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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSupervisor.SuspendLayout();
            this.gbAdministrador.SuspendLayout();
            this.gbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(0, 9);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(487, 40);
            this.btnModificarPersona.TabIndex = 0;
            this.btnModificarPersona.Text = "Modificar Persona";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            this.btnModificarPersona.Click += new System.EventHandler(this.btnModificarPersona_Click);
            // 
            // btnDesbloquearCredencial
            // 
            this.btnDesbloquearCredencial.Location = new System.Drawing.Point(0, 55);
            this.btnDesbloquearCredencial.Name = "btnDesbloquearCredencial";
            this.btnDesbloquearCredencial.Size = new System.Drawing.Size(487, 40);
            this.btnDesbloquearCredencial.TabIndex = 1;
            this.btnDesbloquearCredencial.Text = "Desbloquear Credencial";
            this.btnDesbloquearCredencial.UseVisualStyleBackColor = true;
            this.btnDesbloquearCredencial.Click += new System.EventHandler(this.btnDesbloquearCredencial_Click);
            // 
            // btnAutorizaciones
            // 
            this.btnAutorizaciones.Location = new System.Drawing.Point(0, 0);
            this.btnAutorizaciones.Name = "btnAutorizaciones";
            this.btnAutorizaciones.Size = new System.Drawing.Size(487, 40);
            this.btnAutorizaciones.TabIndex = 2;
            this.btnAutorizaciones.Text = "Autorizaciones";
            this.btnAutorizaciones.UseVisualStyleBackColor = true;
            this.btnAutorizaciones.Click += new System.EventHandler(this.btnAutorizaciones_Click);
            // 
            // btnOperador
            // 
            this.btnOperador.Location = new System.Drawing.Point(0, 1);
            this.btnOperador.Name = "btnOperador";
            this.btnOperador.Size = new System.Drawing.Size(487, 40);
            this.btnOperador.TabIndex = 3;
            this.btnOperador.Text = "Seccion Ventas";
            this.btnOperador.UseVisualStyleBackColor = true;
            this.btnOperador.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // gbSupervisor
            // 
            this.gbSupervisor.Controls.Add(this.btnModificarPersona);
            this.gbSupervisor.Controls.Add(this.btnDesbloquearCredencial);
            this.gbSupervisor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupervisor.Location = new System.Drawing.Point(150, 110);
            this.gbSupervisor.Name = "gbSupervisor";
            this.gbSupervisor.Size = new System.Drawing.Size(487, 96);
            this.gbSupervisor.TabIndex = 4;
            this.gbSupervisor.TabStop = false;
            // 
            // gbAdministrador
            // 
            this.gbAdministrador.Controls.Add(this.btnAutorizaciones);
            this.gbAdministrador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdministrador.Location = new System.Drawing.Point(150, 221);
            this.gbAdministrador.Name = "gbAdministrador";
            this.gbAdministrador.Size = new System.Drawing.Size(487, 44);
            this.gbAdministrador.TabIndex = 5;
            this.gbAdministrador.TabStop = false;
            // 
            // gbOperador
            // 
            this.gbOperador.Controls.Add(this.btnOperador);
            this.gbOperador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperador.Location = new System.Drawing.Point(150, 285);
            this.gbOperador.Name = "gbOperador";
            this.gbOperador.Size = new System.Drawing.Size(487, 41);
            this.gbOperador.TabIndex = 6;
            this.gbOperador.TabStop = false;
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContrasena.Location = new System.Drawing.Point(150, 344);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(487, 40);
            this.btnCambiarContrasena.TabIndex = 7;
            this.btnCambiarContrasena.Text = "Cambiar contrasena";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(660, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarContrasena);
            this.Controls.Add(this.gbOperador);
            this.Controls.Add(this.gbAdministrador);
            this.Controls.Add(this.gbSupervisor);
            this.Name = "Menu";
            this.Text = "Menu";
            this.gbSupervisor.ResumeLayout(false);
            this.gbAdministrador.ResumeLayout(false);
            this.gbOperador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}