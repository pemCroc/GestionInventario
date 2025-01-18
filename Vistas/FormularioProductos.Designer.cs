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
            this.label6 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Consultas = new System.Windows.Forms.ComboBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.CSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlaceHolder = new System.Windows.Forms.Label();
            this.StockBajo = new System.Windows.Forms.Button();
            this.Validar = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Proveedor = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.TextBox();
            this.TablaCompleta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Producto";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(7, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 22);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Producto";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(121, 32);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 22);
            this.Codigo.TabIndex = 3;
            this.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(235, 32);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 22);
            this.Precio.TabIndex = 5;
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Existencia
            // 
            this.Existencia.Location = new System.Drawing.Point(235, 86);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(100, 22);
            this.Existencia.TabIndex = 7;
            this.Existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoría";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proveedor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Productos
            // 
            this.Productos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.Location = new System.Drawing.Point(12, 13);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(568, 229);
            this.Productos.TabIndex = 12;
            this.Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            this.Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            this.Productos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Deseleccionar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregar.Location = new System.Drawing.Point(13, 31);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(171, 54);
            this.Agregar.TabIndex = 13;
            this.Agregar.Text = "Agregar Producto";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.Yellow;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.Location = new System.Drawing.Point(13, 91);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(171, 54);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar Producto";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.Cursor = System.Windows.Forms.Cursors.No;
            this.Eliminar.Location = new System.Drawing.Point(13, 151);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(171, 54);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar Producto";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(117, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Consultar por: ";
            // 
            // Consultas
            // 
            this.Consultas.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Consultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Consultas.FormattingEnabled = true;
            this.Consultas.Items.AddRange(new object[] {
            "Categoria",
            "Proveedor"});
            this.Consultas.Location = new System.Drawing.Point(35, 41);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(257, 21);
            this.Consultas.TabIndex = 17;
            this.Consultas.SelectedIndexChanged += new System.EventHandler(this.Consulta_SelectedIndexChanged);
            this.Consultas.Enter += new System.EventHandler(this.Label_On);
            this.Consultas.Leave += new System.EventHandler(this.Label_Off);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.MintCream;
            this.Consultar.Location = new System.Drawing.Point(14, 109);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(149, 63);
            this.Consultar.TabIndex = 19;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // CSV
            // 
            this.CSV.BackColor = System.Drawing.Color.Lime;
            this.CSV.Location = new System.Drawing.Point(35, 435);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(312, 40);
            this.CSV.TabIndex = 22;
            this.CSV.Text = "Exportar a CSV";
            this.CSV.UseVisualStyleBackColor = false;
            this.CSV.Click += new System.EventHandler(this.CSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.Editar);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(597, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 229);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.PlaceHolder);
            this.groupBox2.Controls.Add(this.StockBajo);
            this.groupBox2.Controls.Add(this.Validar);
            this.groupBox2.Controls.Add(this.Consultar);
            this.groupBox2.Controls.Add(this.Consultas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(457, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 183);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // PlaceHolder
            // 
            this.PlaceHolder.AutoSize = true;
            this.PlaceHolder.Location = new System.Drawing.Point(43, 44);
            this.PlaceHolder.Name = "PlaceHolder";
            this.PlaceHolder.Size = new System.Drawing.Size(217, 16);
            this.PlaceHolder.TabIndex = 23;
            this.PlaceHolder.Text = "Elige una categoria o un proveedor";
            // 
            // StockBajo
            // 
            this.StockBajo.BackColor = System.Drawing.Color.MintCream;
            this.StockBajo.Location = new System.Drawing.Point(169, 109);
            this.StockBajo.Name = "StockBajo";
            this.StockBajo.Size = new System.Drawing.Size(149, 63);
            this.StockBajo.TabIndex = 22;
            this.StockBajo.Text = "Stock Bajo";
            this.StockBajo.UseVisualStyleBackColor = false;
            this.StockBajo.Click += new System.EventHandler(this.StockBajo_Click);
            // 
            // Validar
            // 
            this.Validar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Validar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Validar.FormattingEnabled = true;
            this.Validar.Items.AddRange(new object[] {
            "Categoria",
            "Proveedor"});
            this.Validar.Location = new System.Drawing.Point(35, 76);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(257, 21);
            this.Validar.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.Proveedor);
            this.groupBox3.Controls.Add(this.Categoria);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Nombre);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Codigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Precio);
            this.groupBox3.Controls.Add(this.Existencia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(26, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 128);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // Proveedor
            // 
            this.Proveedor.Location = new System.Drawing.Point(121, 86);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(100, 22);
            this.Proveedor.TabIndex = 11;
            this.Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(7, 86);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(100, 22);
            this.Categoria.TabIndex = 9;
            this.Categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TablaCompleta
            // 
            this.TablaCompleta.BackColor = System.Drawing.Color.MintCream;
            this.TablaCompleta.Location = new System.Drawing.Point(35, 382);
            this.TablaCompleta.Name = "TablaCompleta";
            this.TablaCompleta.Size = new System.Drawing.Size(312, 47);
            this.TablaCompleta.TabIndex = 23;
            this.TablaCompleta.Text = "Ver Tabla Completa";
            this.TablaCompleta.UseVisualStyleBackColor = false;
            this.TablaCompleta.Click += new System.EventHandler(this.TablaCompleta_Click);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 482);
            this.Controls.Add(this.TablaCompleta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Productos;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Consultas;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button CSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Proveedor;
        private System.Windows.Forms.TextBox Categoria;
        private System.Windows.Forms.ComboBox Validar;
        private System.Windows.Forms.Button StockBajo;
        private System.Windows.Forms.Button TablaCompleta;
        private System.Windows.Forms.Label PlaceHolder;
    }
}