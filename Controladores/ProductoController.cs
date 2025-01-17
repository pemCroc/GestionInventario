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

    }
}
