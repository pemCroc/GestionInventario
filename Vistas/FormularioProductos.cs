﻿using SistemaGestionInventario.Controladores;
using SistemaGestionInventario.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónInventario.Vistas
{
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(Codigo.Text) ||
                string.IsNullOrWhiteSpace(Nombre.Text) ||
                string.IsNullOrWhiteSpace(Precio.Text) ||
                string.IsNullOrWhiteSpace(Existencia.Text) ||
                string.IsNullOrWhiteSpace(Categoria.Text) ||
                string.IsNullOrWhiteSpace(Proveedor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(Precio.Text, out double precio) || !int.TryParse(Existencia.Text, out int existencia))
            {
                MessageBox.Show("Precio y Existencia deben ser valores numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoProducto = Codigo.Text.Trim();
            if (ProductoController.ProductoExistente(codigoProducto))
            {
                MessageBox.Show("El código de producto ya existe. Por favor, ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creacion del producto
            Producto nuevoProducto = new Producto
            {
                CodigoProducto = Codigo.Text.Trim(),
                Nombre = Nombre.Text.Trim(),
                Categoria = Categoria.Text,
                Precio = precio,
                Existencia = existencia,
                Proveedor = Proveedor.Text
            };

            ProductoController.AgregarProducto(nuevoProducto);
            CargarProductos();
            MessageBox.Show("Producto agregado exitosamente.");
            LimpiarCampos();
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre.Text) ||
                string.IsNullOrWhiteSpace(Categoria.Text) ||
                string.IsNullOrWhiteSpace(Precio.Text) ||
                string.IsNullOrWhiteSpace(Existencia.Text) ||
                string.IsNullOrWhiteSpace(Proveedor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(Precio.Text, out double precio) || !int.TryParse(Existencia.Text, out int existencia))
            {
                MessageBox.Show("Precio y Existencia deben ser valores numéricos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Producto productoEditado = new Producto
            {
                CodigoProducto = Codigo.Text.Trim(),
                Nombre = Nombre.Text.Trim(),
                Categoria = Categoria.Text,
                Precio = precio,
                Existencia = existencia,
                Proveedor = Proveedor.Text
            };

            // Actualizar en la base de datos
            try
            {
                ProductoController.EditarProducto(productoEditado);
                MessageBox.Show("Producto editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarCampos();
                Codigo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Productos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila 
            DataGridViewRow filaSeleccionada = Productos.SelectedRows[0];
            string codigoProducto = filaSeleccionada.Cells["CodigoProducto"].Value.ToString();
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de eliminar el producto con código {codigoProducto}?",
                                                        "Confirmación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    ProductoController.EliminarProducto(codigoProducto);
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                    Codigo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void CargarProductos()
        {
            Productos.DataSource = null;
            Productos.DataSource = ProductoController.ObtenerProductos();
        }
        private void LimpiarCampos()
        {
            Codigo.Clear();
            Nombre.Clear();
            Precio.Clear();
            Existencia.Clear();
            Categoria.Clear();
            Proveedor.Clear();
        }
        private void Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow filaSeleccionada = Productos.Rows[e.RowIndex];
                Codigo.Text = filaSeleccionada.Cells["CodigoProducto"].Value.ToString();
                Nombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                Categoria.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                Precio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                Existencia.Text = filaSeleccionada.Cells["Existencia"].Value.ToString();
                Proveedor.Text = filaSeleccionada.Cells["Proveedor"].Value.ToString();

                // Desactivar el campo Código
                Codigo.Enabled = false;
            }
        }
        private void Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Consultas.Text) || string.IsNullOrWhiteSpace(Validar.Text))
            {
                MessageBox.Show("Por favor, seleccione un criterio y un valor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string criterio = Consultas.Text;
            string valor = Validar.Text;     // Obtener el valor dinamico del segundo ComboBox

            try
            {
                List<Producto> productos;

                if (criterio == "Categoria")
                {
                    productos = ProductoController.ConsultarPorCategoria(valor);
                }
                else if (criterio == "Proveedor")
                {
                    productos = ProductoController.ConsultarPorProveedor(valor);
                }
                else
                {
                    MessageBox.Show("Seleccione un criterio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Productos.DataSource = null;
                Productos.DataSource = productos;
                if (productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos con el criterio proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StockBajo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productos = ProductoController.ReporteStockBajo();

                Productos.DataSource = null;
                Productos.DataSource = productos;

                if (productos.Count == 0)
                {
                    MessageBox.Show("No hay productos con stock bajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CSV_Click(object sender, EventArgs e)
        {
            if (Productos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV|*.csv",
                Title = "Guardar como CSV",
                FileName = "Productos.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        for (int i = 0; i <Productos.Columns.Count; i++)
                        {
                            sw.Write(Productos.Columns[i].HeaderText);
                            if (i < Productos.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                        foreach (DataGridViewRow row in Productos.Rows)
                        {
                            for (int i = 0; i < Productos.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < Productos.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Datos exportados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Consulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = Consultas.Text;
            Validar.Items.Clear();

            try
            {
                if (criterio == "Categoria")
                {
                    List<string> categorias = ProductoController.ObtenerCategorias();
                    Validar.Items.AddRange(categorias.ToArray());
                }
                else if (criterio == "Proveedor")
                {
                    List<string> proveedores = ProductoController.ObtenerProveedores();
                    Validar.Items.AddRange(proveedores.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los valores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TablaCompleta_Click(object sender, EventArgs e)
        {
            try
            {
                // Cargar todos los productos desde la base de datos
                List<Producto> productos = ProductoController.ObtenerProductos();
                Productos.DataSource = null; // Limpiar
                Productos.DataSource = productos;
                LimpiarCampos();
                Codigo.Enabled = true;
                if (productos.Count == 0)
                {
                    MessageBox.Show("No hay productos en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la tabla completa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Label_On(object sender, EventArgs e)
        {
            // Ocultar el Label
            PlaceHolder.Visible = false;
        }
        private void Label_Off(object sender, EventArgs e)
        {
            // Mostrar el Label
            if (string.IsNullOrWhiteSpace(Consultas.Text))
            {
                PlaceHolder.Visible = true;
            }
        }
        private void Deseleccionar_Click(object sender, MouseEventArgs e)
        {
            // Ubicación del clic en la tabla
            var hitTestInfo = Productos.HitTest(e.X, e.Y);

            // Verificar si el clic fue en un área vacía
            if (hitTestInfo.Type == DataGridViewHitTestType.None)
            {
                // Deseleccionar todas las filas si se hace clic en un área vacía
                Productos.ClearSelection();
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                        Codigo.Enabled = true;
                    }
                }
            }
        }
    }
}

