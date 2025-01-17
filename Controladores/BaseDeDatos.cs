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
    }


}

