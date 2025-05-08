namespace TemplateTPCorto
{
    partial class FormCambioContrasena
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevaContrasenaTxt = new System.Windows.Forms.TextBox();
            this.NuevaContrasenaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio obligatorio de contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su nueva contraseña";
            // 
            // NuevaContrasenaTxt
            // 
            this.NuevaContrasenaTxt.Location = new System.Drawing.Point(50, 126);
            this.NuevaContrasenaTxt.Name = "NuevaContrasenaTxt";
            this.NuevaContrasenaTxt.Size = new System.Drawing.Size(100, 22);
            this.NuevaContrasenaTxt.TabIndex = 2;
            this.NuevaContrasenaTxt.TextChanged += new System.EventHandler(this.NuevaContrasenaTxt_TextChanged);
            // 
            // NuevaContrasenaBtn
            // 
            this.NuevaContrasenaBtn.Enabled = false;
            this.NuevaContrasenaBtn.Location = new System.Drawing.Point(50, 165);
            this.NuevaContrasenaBtn.Name = "NuevaContrasenaBtn";
            this.NuevaContrasenaBtn.Size = new System.Drawing.Size(80, 29);
            this.NuevaContrasenaBtn.TabIndex = 3;
            this.NuevaContrasenaBtn.Text = "Confirmar";
            this.NuevaContrasenaBtn.UseVisualStyleBackColor = true;
            this.NuevaContrasenaBtn.Click += new System.EventHandler(this.NuevaContrasenaBtn_Click);
            // 
            // FormCambioObligatorioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NuevaContrasenaBtn);
            this.Controls.Add(this.NuevaContrasenaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCambioObligatorioContrasena";
            this.Text = "CambioObligatorioContrasena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NuevaContrasenaTxt;
        private System.Windows.Forms.Button NuevaContrasenaBtn;
    }
}