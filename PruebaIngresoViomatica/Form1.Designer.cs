namespace PruebaIngresoViomatica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.facturaDataGrid = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericDescuento = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textIva = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textTotalDescuento = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUCTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CANTIDAD:";
            // 
            // cbProducto
            // 
            this.cbProducto.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(210, 82);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(163, 23);
            this.cbProducto.TabIndex = 3;
            this.cbProducto.TabStop = false;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(469, 82);
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 23);
            this.numericCantidad.TabIndex = 4;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // facturaDataGrid
            // 
            this.facturaDataGrid.AllowUserToAddRows = false;
            this.facturaDataGrid.AllowUserToDeleteRows = false;
            this.facturaDataGrid.AllowUserToResizeColumns = false;
            this.facturaDataGrid.AllowUserToResizeRows = false;
            this.facturaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.precioU,
            this.cantidad,
            this.precioTotal,
            this.buttonEliminar});
            this.facturaDataGrid.Location = new System.Drawing.Point(19, 152);
            this.facturaDataGrid.Name = "facturaDataGrid";
            this.facturaDataGrid.RowTemplate.Height = 25;
            this.facturaDataGrid.Size = new System.Drawing.Size(769, 258);
            this.facturaDataGrid.TabIndex = 5;
            // 
            // numero
            // 
            this.numero.HeaderText = "Num.";
            this.numero.Name = "numero";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // precioU
            // 
            this.precioU.HeaderText = "Precio U.";
            this.precioU.Name = "precioU";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio Final";
            this.precioTotal.Name = "precioTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SUBTOTAL";
            // 
            // textSubTotal
            // 
            this.textSubTotal.AutoSize = true;
            this.textSubTotal.Location = new System.Drawing.Point(659, 426);
            this.textSubTotal.Name = "textSubTotal";
            this.textSubTotal.Size = new System.Drawing.Size(13, 15);
            this.textSubTotal.TabIndex = 7;
            this.textSubTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "DESCUENTO %";
            // 
            // numericDescuento
            // 
            this.numericDescuento.Enabled = false;
            this.numericDescuento.Location = new System.Drawing.Point(659, 451);
            this.numericDescuento.Name = "numericDescuento";
            this.numericDescuento.Size = new System.Drawing.Size(79, 23);
            this.numericDescuento.TabIndex = 9;
            this.numericDescuento.ValueChanged += new System.EventHandler(this.numericDescuento_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "IVA 12%";
            // 
            // textIva
            // 
            this.textIva.AutoSize = true;
            this.textIva.Location = new System.Drawing.Point(659, 513);
            this.textIva.Name = "textIva";
            this.textIva.Size = new System.Drawing.Size(34, 15);
            this.textIva.TabIndex = 11;
            this.textIva.Text = "30.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "TOTAL";
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Location = new System.Drawing.Point(659, 541);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(49, 15);
            this.textTotal.TabIndex = 13;
            this.textTotal.Text = "230.00 $";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(623, 76);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(85, 32);
            this.botonAceptar.TabIndex = 14;
            this.botonAceptar.Text = "ACEPTAR";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total con Descuento";
            // 
            // textTotalDescuento
            // 
            this.textTotalDescuento.AutoSize = true;
            this.textTotalDescuento.Location = new System.Drawing.Point(659, 484);
            this.textTotalDescuento.Name = "textTotalDescuento";
            this.textTotalDescuento.Size = new System.Drawing.Size(22, 15);
            this.textTotalDescuento.TabIndex = 16;
            this.textTotalDescuento.Text = "0 $";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.HeaderText = "Eliminar Producto";
            this.buttonEliminar.Name = "buttonEliminar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.textTotalDescuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textIva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericDescuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.facturaDataGrid);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbProducto;
        private NumericUpDown numericCantidad;
        private DataGridView facturaDataGrid;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precioU;
        private DataGridViewTextBoxColumn cantidad;
        private Label label4;
        private Label textSubTotal;
        private Label label6;
        private NumericUpDown numericDescuento;
        private Label label7;
        private Label textIva;
        private Label label9;
        private Label textTotal;
        private Button botonAceptar;
        private DataGridViewTextBoxColumn precioTotal;
        private Label label5;
        private Label textTotalDescuento;
        private DataGridViewButtonColumn buttonEliminar;
    }
}