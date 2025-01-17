using SistemaGestionInventario.Controladores;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Productos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = Productos.SelectedRows[0];
            string codigoProducto = filaSeleccionada.Cells["CodigoProducto"].Value.ToString();

            // Confirmar eliminación
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
            Categoria.SelectedIndex = -1; // Deseleccionar categoría
            Proveedor.SelectedIndex = -1; // Deseleccionar proveedor
        }

        private void Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
