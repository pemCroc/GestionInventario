using SistemaGestionInventario.Modelos;
using System;
using System.Data.SQLite;



namespace SistemaGestionInventario.Controladores
{

    public class BaseDatos
    {
        private static string connectionString = @"Data Source=|DataDirectory|\Inventario.db;Version=3;";
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
            public static void VerificarTablas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                // Tabla Productos
                string crearTablaProductos = @"
        CREATE TABLE IF NOT EXISTS Productos (
            CodigoProducto TEXT PRIMARY KEY,
            Nombre TEXT NOT NULL,
            Categoria TEXT,
            Precio REAL NOT NULL,
            Existencia INTEGER NOT NULL,
            Proveedor TEXT
        );";

                // Tabla Categorías
                string crearTablaCategorias = @"
        CREATE TABLE IF NOT EXISTS Categorias (
            IdCategoria INTEGER PRIMARY KEY AUTOINCREMENT,
            NombreCategoria TEXT UNIQUE NOT NULL,
            Descripcion TEXT
        );";

                // Tabla Proveedores
                string crearTablaProveedores = @"
        CREATE TABLE IF NOT EXISTS Proveedores (
            IdProveedor INTEGER PRIMARY KEY AUTOINCREMENT,
            NombreEmpresa TEXT UNIQUE NOT NULL,
            Contacto TEXT NOT NULL,
            Direccion TEXT,
            Telefono TEXT NOT NULL
        );";

                // Ejecutar las consultas para crear las tablas
                using (var command = new SQLiteCommand(crearTablaProductos, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(crearTablaCategorias, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(crearTablaProveedores, connection))
                {

                }

            }
        }
    } 
}



