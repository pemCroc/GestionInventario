using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaGestionInventario.Modelos;

namespace SistemaGestionInventario.Controladores
{

    public class ProductoController
    {

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Productos";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = double.Parse(reader["Precio"].ToString()),
                        Existencia = int.Parse(reader["Existencia"].ToString()),
                        Proveedor = reader["Proveedor"].ToString()
                    });
                }
            }

            return productos;
        }
        public static void AgregarProducto(Producto producto)
        {
            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Productos (CodigoProducto, Nombre, Categoria, Precio, Existencia, Proveedor) " +
                               "VALUES (@CodigoProducto, @Nombre, @Categoria, @Precio, @Existencia, @Proveedor)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Existencia", producto.Existencia);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                command.ExecuteNonQuery();
            }
        }

        public static bool ProductoExistente(string codigoProducto)
        {
            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Productos WHERE CodigoProducto = @CodigoProducto";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0; // Retorna true si ya existe
            }
        }

        public static void EliminarProducto(string codigoProducto)
        {
            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = @"DELETE FROM Productos WHERE CodigoProducto = @CodigoProducto";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                command.ExecuteNonQuery();
            }
        }
        public static List<Producto> ConsultarPorCategoria(string categoria)
        {
            List<Producto> productos = new List<Producto>();

            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Productos WHERE Categoria = @Categoria";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Categoria", categoria);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = double.Parse(reader["Precio"].ToString()),
                        Existencia = int.Parse(reader["Existencia"].ToString()),
                        Proveedor = reader["Proveedor"].ToString()
                    });
                }
            }

            return productos;
        }
        public static List<Producto> ConsultarPorProveedor(string proveedor)
        {
            List<Producto> productos = new List<Producto>();

            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Productos WHERE Proveedor = @Proveedor";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Proveedor", proveedor);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = double.Parse(reader["Precio"].ToString()),
                        Existencia = int.Parse(reader["Existencia"].ToString()),
                        Proveedor = reader["Proveedor"].ToString()
                    });
                }
            }

            return productos;
        }
        public static List<Producto> ReporteStockBajo()
        {
            List<Producto> productos = new List<Producto>();

            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Productos WHERE Existencia < 10";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = double.Parse(reader["Precio"].ToString()),
                        Existencia = int.Parse(reader["Existencia"].ToString()),
                        Proveedor = reader["Proveedor"].ToString()
                    });
                }
            }

            return productos;
        }
        public static void EditarProducto(Producto producto)
        {
            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = @"UPDATE Productos
                         SET Nombre = @Nombre, Categoria = @Categoria, Precio = @Precio,
                             Existencia = @Existencia, Proveedor = @Proveedor
                         WHERE CodigoProducto = @CodigoProducto";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Existencia", producto.Existencia);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                command.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                command.ExecuteNonQuery();
            }
        }
        public static List<string> ObtenerCategorias()
        {
            List<string> categorias = new List<string>();

            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT DISTINCT Categoria FROM Productos WHERE Categoria IS NOT NULL AND Categoria != ''";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(reader["Categoria"].ToString());
                }
            }

            return categorias;
        }
        public static List<string> ObtenerProveedores()
        {
            List<string> proveedores = new List<string>();

            using (var connection = BaseDatos.GetConnection())
            {
                connection.Open();
                string query = "SELECT DISTINCT Proveedor FROM Productos WHERE Proveedor IS NOT NULL AND Proveedor != ''";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    proveedores.Add(reader["Proveedor"].ToString());
                }
            }

            return proveedores;
        }


    }
}
