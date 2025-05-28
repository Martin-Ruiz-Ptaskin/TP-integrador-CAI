namespace TemplateTPCorto
{
    partial class FormVentas
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
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.Carrito = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lablSubTotal = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(188, 50);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(301, 24);
            this.cmbClientes.TabIndex = 0;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria Productos";
            // 
            // cboCategoriaProductos
            // 
            this.cboCategoriaProductos.FormattingEnabled = true;
            this.cboCategoriaProductos.Location = new System.Drawing.Point(188, 101);
            this.cboCategoriaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategoriaProductos.Name = "cboCategoriaProductos";
            this.cboCategoriaProductos.Size = new System.Drawing.Size(183, 24);
            this.cboCategoriaProductos.TabIndex = 3;
            this.cboCategoriaProductos.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaProductos_SelectedIndexChanged);
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 16;
            this.lstProducto.Location = new System.Drawing.Point(39, 162);
            this.lstProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(450, 260);
            this.lstProducto.TabIndex = 4;
            this.lstProducto.SelectedIndexChanged += new System.EventHandler(this.lstProducto_SelectedIndexChanged);
            // 
            // Carrito
            // 
            this.Carrito.FormattingEnabled = true;
            this.Carrito.ItemHeight = 16;
            this.Carrito.Location = new System.Drawing.Point(560, 50);
            this.Carrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(385, 308);
            this.Carrito.TabIndex = 5;
            this.Carrito.SelectedIndexChanged += new System.EventHandler(this.Carrito_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(684, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(123, 443);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(361, 437);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar a carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lablSubTotal
            // 
            this.lablSubTotal.AutoSize = true;
            this.lablSubTotal.Location = new System.Drawing.Point(684, 394);
            this.lablSubTotal.Name = "lablSubTotal";
            this.lablSubTotal.Size = new System.Drawing.Size(14, 16);
            this.lablSubTotal.TabIndex = 13;
            this.lablSubTotal.Text = "0";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(969, 162);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 15;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(734, 482);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(101, 23);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar Venta";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Enabled = false;
            this.btnListarProductos.Location = new System.Drawing.Point(377, 101);
            this.btnListarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(114, 26);
            this.btnListarProductos.TabIndex = 17;
            this.btnListarProductos.Text = "Listar productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 530);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lablSubTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.cboCategoriaProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategoriaProductos;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.ListBox Carrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lablSubTotal;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnListarProductos;
    }
}