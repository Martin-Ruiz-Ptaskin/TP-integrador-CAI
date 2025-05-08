namespace TemplateTPCorto
{
    partial class FormDesbloquearCredencial
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
            this.usuariosListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmarCambioBtn = new System.Windows.Forms.Button();
            this.DatosLbl = new System.Windows.Forms.Label();
            this.CambioContrasenaLbl = new System.Windows.Forms.Label();
            this.NuevaContrasenaTxt = new System.Windows.Forms.TextBox();
            this.DatosUsuarioLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuariosListBox
            // 
            this.usuariosListBox.FormattingEnabled = true;
            this.usuariosListBox.ItemHeight = 16;
            this.usuariosListBox.Location = new System.Drawing.Point(41, 85);
            this.usuariosListBox.Name = "usuariosListBox";
            this.usuariosListBox.Size = new System.Drawing.Size(238, 196);
            this.usuariosListBox.TabIndex = 4;
            this.usuariosListBox.SelectedIndexChanged += new System.EventHandler(this.usuariosListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un usuario para desbloquear credencial";
            // 
            // ConfirmarCambioBtn
            // 
            this.ConfirmarCambioBtn.Enabled = false;
            this.ConfirmarCambioBtn.Location = new System.Drawing.Point(417, 273);
            this.ConfirmarCambioBtn.Name = "ConfirmarCambioBtn";
            this.ConfirmarCambioBtn.Size = new System.Drawing.Size(202, 37);
            this.ConfirmarCambioBtn.TabIndex = 5;
            this.ConfirmarCambioBtn.Text = "Desbloquear Credencial";
            this.ConfirmarCambioBtn.UseVisualStyleBackColor = true;
            this.ConfirmarCambioBtn.Visible = false;
            this.ConfirmarCambioBtn.Click += new System.EventHandler(this.ConfirmarCambioBtn_Click);
            // 
            // DatosLbl
            // 
            this.DatosLbl.AutoSize = true;
            this.DatosLbl.Location = new System.Drawing.Point(405, 131);
            this.DatosLbl.Name = "DatosLbl";
            this.DatosLbl.Size = new System.Drawing.Size(123, 16);
            this.DatosLbl.TabIndex = 6;
            this.DatosLbl.Text = "Usuario a modificar";
            this.DatosLbl.Visible = false;
            // 
            // CambioContrasenaLbl
            // 
            this.CambioContrasenaLbl.AutoSize = true;
            this.CambioContrasenaLbl.Location = new System.Drawing.Point(405, 183);
            this.CambioContrasenaLbl.Name = "CambioContrasenaLbl";
            this.CambioContrasenaLbl.Size = new System.Drawing.Size(117, 16);
            this.CambioContrasenaLbl.TabIndex = 7;
            this.CambioContrasenaLbl.Text = "Nueva contraseña";
            this.CambioContrasenaLbl.Visible = false;
            // 
            // NuevaContrasenaTxt
            // 
            this.NuevaContrasenaTxt.Location = new System.Drawing.Point(551, 183);
            this.NuevaContrasenaTxt.Name = "NuevaContrasenaTxt";
            this.NuevaContrasenaTxt.Size = new System.Drawing.Size(100, 22);
            this.NuevaContrasenaTxt.TabIndex = 9;
            this.NuevaContrasenaTxt.Visible = false;
            this.NuevaContrasenaTxt.TextChanged += new System.EventHandler(this.NuevaContrasenaTxt_TextChanged);
            // 
            // DatosUsuarioLbl
            // 
            this.DatosUsuarioLbl.AutoSize = true;
            this.DatosUsuarioLbl.Location = new System.Drawing.Point(548, 131);
            this.DatosUsuarioLbl.Name = "DatosUsuarioLbl";
            this.DatosUsuarioLbl.Size = new System.Drawing.Size(43, 16);
            this.DatosUsuarioLbl.TabIndex = 10;
            this.DatosUsuarioLbl.Text = "Datos";
            this.DatosUsuarioLbl.Visible = false;
            // 
            // FormDesbloquearCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosUsuarioLbl);
            this.Controls.Add(this.NuevaContrasenaTxt);
            this.Controls.Add(this.CambioContrasenaLbl);
            this.Controls.Add(this.DatosLbl);
            this.Controls.Add(this.ConfirmarCambioBtn);
            this.Controls.Add(this.usuariosListBox);
            this.Controls.Add(this.label1);
            this.Name = "FormDesbloquearCredencial";
            this.Text = "DesbloquearCredencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usuariosListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmarCambioBtn;
        private System.Windows.Forms.Label DatosLbl;
        private System.Windows.Forms.Label CambioContrasenaLbl;
        private System.Windows.Forms.TextBox NuevaContrasenaTxt;
        private System.Windows.Forms.Label DatosUsuarioLbl;
    }
}