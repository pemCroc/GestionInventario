using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GestiónInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Database
        {
            private static string connectionString = @"Data Source=Inventario.db;Version=3;";

            public static SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = Database.GetConnection())
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa con SQLite.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }

}
