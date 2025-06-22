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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio obligatorio de contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su nueva contraseña";
            // 
            // NuevaContrasenaTxt
            // 
            this.NuevaContrasenaTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaContrasenaTxt.Location = new System.Drawing.Point(195, 122);
            this.NuevaContrasenaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevaContrasenaTxt.Name = "NuevaContrasenaTxt";
            this.NuevaContrasenaTxt.Size = new System.Drawing.Size(189, 23);
            this.NuevaContrasenaTxt.TabIndex = 2;
            this.NuevaContrasenaTxt.TextChanged += new System.EventHandler(this.NuevaContrasenaTxt_TextChanged);
            // 
            // NuevaContrasenaBtn
            // 
            this.NuevaContrasenaBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NuevaContrasenaBtn.Enabled = false;
            this.NuevaContrasenaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaContrasenaBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NuevaContrasenaBtn.Location = new System.Drawing.Point(195, 161);
            this.NuevaContrasenaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NuevaContrasenaBtn.Name = "NuevaContrasenaBtn";
            this.NuevaContrasenaBtn.Size = new System.Drawing.Size(189, 24);
            this.NuevaContrasenaBtn.TabIndex = 3;
            this.NuevaContrasenaBtn.Text = "Confirmar";
            this.NuevaContrasenaBtn.UseVisualStyleBackColor = false;
            this.NuevaContrasenaBtn.Click += new System.EventHandler(this.NuevaContrasenaBtn_Click);
            // 
            // FormCambioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.NuevaContrasenaBtn);
            this.Controls.Add(this.NuevaContrasenaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCambioContrasena";
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