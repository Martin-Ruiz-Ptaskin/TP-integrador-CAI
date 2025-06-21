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
            this.usuariosListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosListBox.FormattingEnabled = true;
            this.usuariosListBox.ItemHeight = 17;
            this.usuariosListBox.Location = new System.Drawing.Point(31, 69);
            this.usuariosListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usuariosListBox.Name = "usuariosListBox";
            this.usuariosListBox.Size = new System.Drawing.Size(222, 225);
            this.usuariosListBox.TabIndex = 4;
            this.usuariosListBox.SelectedIndexChanged += new System.EventHandler(this.usuariosListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un usuario para desbloquear credencial";
            // 
            // ConfirmarCambioBtn
            // 
            this.ConfirmarCambioBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConfirmarCambioBtn.Enabled = false;
            this.ConfirmarCambioBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarCambioBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmarCambioBtn.Location = new System.Drawing.Point(353, 181);
            this.ConfirmarCambioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmarCambioBtn.Name = "ConfirmarCambioBtn";
            this.ConfirmarCambioBtn.Size = new System.Drawing.Size(152, 32);
            this.ConfirmarCambioBtn.TabIndex = 5;
            this.ConfirmarCambioBtn.Text = "Desbloquear Credencial";
            this.ConfirmarCambioBtn.UseVisualStyleBackColor = false;
            this.ConfirmarCambioBtn.Visible = false;
            this.ConfirmarCambioBtn.Click += new System.EventHandler(this.ConfirmarCambioBtn_Click);
            // 
            // DatosLbl
            // 
            this.DatosLbl.AutoSize = true;
            this.DatosLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosLbl.Location = new System.Drawing.Point(284, 69);
            this.DatosLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DatosLbl.Name = "DatosLbl";
            this.DatosLbl.Size = new System.Drawing.Size(133, 17);
            this.DatosLbl.TabIndex = 6;
            this.DatosLbl.Text = "Usuario a modificar";
            this.DatosLbl.Visible = false;
            // 
            // CambioContrasenaLbl
            // 
            this.CambioContrasenaLbl.AutoSize = true;
            this.CambioContrasenaLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambioContrasenaLbl.Location = new System.Drawing.Point(363, 135);
            this.CambioContrasenaLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CambioContrasenaLbl.Name = "CambioContrasenaLbl";
            this.CambioContrasenaLbl.Size = new System.Drawing.Size(128, 17);
            this.CambioContrasenaLbl.TabIndex = 7;
            this.CambioContrasenaLbl.Text = "Nueva contraseña";
            this.CambioContrasenaLbl.Visible = false;
            // 
            // NuevaContrasenaTxt
            // 
            this.NuevaContrasenaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaContrasenaTxt.Location = new System.Drawing.Point(350, 154);
            this.NuevaContrasenaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevaContrasenaTxt.Name = "NuevaContrasenaTxt";
            this.NuevaContrasenaTxt.Size = new System.Drawing.Size(155, 23);
            this.NuevaContrasenaTxt.TabIndex = 9;
            this.NuevaContrasenaTxt.Visible = false;
            this.NuevaContrasenaTxt.TextChanged += new System.EventHandler(this.NuevaContrasenaTxt_TextChanged);
            // 
            // DatosUsuarioLbl
            // 
            this.DatosUsuarioLbl.AutoSize = true;
            this.DatosUsuarioLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosUsuarioLbl.Location = new System.Drawing.Point(421, 69);
            this.DatosUsuarioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DatosUsuarioLbl.Name = "DatosUsuarioLbl";
            this.DatosUsuarioLbl.Size = new System.Drawing.Size(46, 17);
            this.DatosUsuarioLbl.TabIndex = 10;
            this.DatosUsuarioLbl.Text = "Datos";
            this.DatosUsuarioLbl.Visible = false;
            // 
            // FormDesbloquearCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 366);
            this.Controls.Add(this.DatosUsuarioLbl);
            this.Controls.Add(this.NuevaContrasenaTxt);
            this.Controls.Add(this.CambioContrasenaLbl);
            this.Controls.Add(this.DatosLbl);
            this.Controls.Add(this.ConfirmarCambioBtn);
            this.Controls.Add(this.usuariosListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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