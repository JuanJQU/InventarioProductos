namespace InventarioProductos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.listBoxInventario = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.btnVenderProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(196, 66);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(163, 20);
            this.txtNombreProducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(196, 109);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(163, 20);
            this.txtPrecioProducto.TabIndex = 2;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(196, 147);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(163, 20);
            this.txtCantidadStock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresa cantidad en stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio del Producto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(389, 95);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(163, 47);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Registrar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // listBoxInventario
            // 
            this.listBoxInventario.FormattingEnabled = true;
            this.listBoxInventario.Location = new System.Drawing.Point(588, 21);
            this.listBoxInventario.Name = "listBoxInventario";
            this.listBoxInventario.Size = new System.Drawing.Size(178, 199);
            this.listBoxInventario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(56, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(53, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registro Ventas";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(196, 260);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(163, 20);
            this.txtBuscarProducto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre producto a vender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad a vender";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(196, 298);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(163, 20);
            this.txtCantidadVenta.TabIndex = 13;
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.Location = new System.Drawing.Point(389, 264);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(163, 54);
            this.btnVenderProducto.TabIndex = 14;
            this.btnVenderProducto.Text = "Realizar Venta";
            this.btnVenderProducto.UseVisualStyleBackColor = true;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVenderProducto);
            this.Controls.Add(this.txtCantidadVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxInventario);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ListBox listBoxInventario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Button btnVenderProducto;
    }
}

