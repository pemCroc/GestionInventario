namespace GestiónInventario.Vistas
{
    partial class FormularioProductos
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Existencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.Proveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Consulta = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.StockBajo = new System.Windows.Forms.Button();
            this.CSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(17, 60);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Producto:";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(143, 60);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 20);
            this.Codigo.TabIndex = 3;
            this.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(274, 60);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 20);
            this.Precio.TabIndex = 5;
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Existencia
            // 
            this.Existencia.Location = new System.Drawing.Point(400, 60);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(100, 20);
            this.Existencia.TabIndex = 7;
            this.Existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoría:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Categoria
            // 
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(524, 60);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(121, 21);
            this.Categoria.TabIndex = 9;
            // 
            // Proveedor
            // 
            this.Proveedor.FormattingEnabled = true;
            this.Proveedor.Location = new System.Drawing.Point(662, 60);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(121, 21);
            this.Proveedor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proveedor:";
            // 
            // Productos
            // 
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.Location = new System.Drawing.Point(18, 138);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(356, 229);
            this.Productos.TabIndex = 12;
            this.Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            this.Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(400, 138);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(171, 54);
            this.Agregar.TabIndex = 13;
            this.Agregar.Text = "Agregar Producto";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(400, 219);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(171, 54);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar Producto";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(400, 313);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(171, 54);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar Producto";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Consultar por: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Categoria",
            "Proveedor"});
            this.comboBox1.Location = new System.Drawing.Point(632, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Consulta
            // 
            this.Consulta.Location = new System.Drawing.Point(644, 172);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(100, 20);
            this.Consulta.TabIndex = 18;
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(642, 219);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(109, 33);
            this.Consultar.TabIndex = 19;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // StockBajo
            // 
            this.StockBajo.Location = new System.Drawing.Point(55, 387);
            this.StockBajo.Name = "StockBajo";
            this.StockBajo.Size = new System.Drawing.Size(288, 51);
            this.StockBajo.TabIndex = 20;
            this.StockBajo.Text = "Stock Bajo";
            this.StockBajo.UseVisualStyleBackColor = true;
            this.StockBajo.Click += new System.EventHandler(this.StockBajo_Click);
            // 
            // CSV
            // 
            this.CSV.BackColor = System.Drawing.Color.Lime;
            this.CSV.Location = new System.Drawing.Point(636, 299);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(117, 117);
            this.CSV.TabIndex = 22;
            this.CSV.Text = "Exportar a CSV";
            this.CSV.UseVisualStyleBackColor = false;
            this.CSV.Click += new System.EventHandler(this.CSV_Click);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.CSV);
            this.Controls.Add(this.StockBajo);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Existencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.ComboBox Proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Productos;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Consulta;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button StockBajo;
        private System.Windows.Forms.Button CSV;
    }
}