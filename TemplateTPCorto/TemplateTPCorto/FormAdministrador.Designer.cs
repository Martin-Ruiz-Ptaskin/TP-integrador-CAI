﻿namespace TemplateTPCorto
{
    partial class FormAdministrador
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.AprobarDesbloqueoBtn = new System.Windows.Forms.Button();
            this.OperacionesDesbloqueoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OperacionesModificacionPersonaListBox = new System.Windows.Forms.ListBox();
            this.AprobarModificacionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AprobarDesbloqueoBtn
            // 
            this.AprobarDesbloqueoBtn.Enabled = false;
            this.AprobarDesbloqueoBtn.Location = new System.Drawing.Point(70, 229);
            this.AprobarDesbloqueoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AprobarDesbloqueoBtn.Name = "AprobarDesbloqueoBtn";
            this.AprobarDesbloqueoBtn.Size = new System.Drawing.Size(123, 39);
            this.AprobarDesbloqueoBtn.TabIndex = 0;
            this.AprobarDesbloqueoBtn.Text = "Aprobar Desbloqueo";
            this.AprobarDesbloqueoBtn.UseVisualStyleBackColor = true;
            this.AprobarDesbloqueoBtn.Click += new System.EventHandler(this.AprobarDesbloqueoBtn_Click);
            // 
            // OperacionesDesbloqueoListBox
            // 
            this.OperacionesDesbloqueoListBox.FormattingEnabled = true;
            this.OperacionesDesbloqueoListBox.Location = new System.Drawing.Point(70, 58);
            this.OperacionesDesbloqueoListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OperacionesDesbloqueoListBox.Name = "OperacionesDesbloqueoListBox";
            this.OperacionesDesbloqueoListBox.Size = new System.Drawing.Size(350, 160);
            this.OperacionesDesbloqueoListBox.TabIndex = 5;
            this.OperacionesDesbloqueoListBox.SelectedIndexChanged += new System.EventHandler(this.OperacionesDesbloqueoListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operaciones de desbloqueo";
            // 
            // OperacionesModificacionPersonaListBox
            // 
            this.OperacionesModificacionPersonaListBox.FormattingEnabled = true;
            this.OperacionesModificacionPersonaListBox.Location = new System.Drawing.Point(570, 58);
            this.OperacionesModificacionPersonaListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OperacionesModificacionPersonaListBox.Name = "OperacionesModificacionPersonaListBox";
            this.OperacionesModificacionPersonaListBox.Size = new System.Drawing.Size(350, 160);
            this.OperacionesModificacionPersonaListBox.TabIndex = 8;
            this.OperacionesModificacionPersonaListBox.SelectedIndexChanged += new System.EventHandler(this.OperacionesModificacionPersonaListBox_SelectedIndexChanged_1);
            // 
            // AprobarModificacionBtn
            // 
            this.AprobarModificacionBtn.Enabled = false;
            this.AprobarModificacionBtn.Location = new System.Drawing.Point(570, 222);
            this.AprobarModificacionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AprobarModificacionBtn.Name = "AprobarModificacionBtn";
            this.AprobarModificacionBtn.Size = new System.Drawing.Size(123, 39);
            this.AprobarModificacionBtn.TabIndex = 7;
            this.AprobarModificacionBtn.Text = "Aprobar Modificacion";
            this.AprobarModificacionBtn.UseVisualStyleBackColor = true;
            this.AprobarModificacionBtn.Click += new System.EventHandler(this.AprobarModificacionBtn_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operaciones de modificación de persona";
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OperacionesModificacionPersonaListBox);
            this.Controls.Add(this.AprobarModificacionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperacionesDesbloqueoListBox);
            this.Controls.Add(this.AprobarDesbloqueoBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button AprobarDesbloqueoBtn;
        private System.Windows.Forms.ListBox OperacionesDesbloqueoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OperacionesModificacionPersonaListBox;
        private System.Windows.Forms.Button AprobarModificacionBtn;
        private System.Windows.Forms.Label label2;
    }
}