using GestiónInventario.Vistas;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónInventario
{
    internal static class Program
    {
        // Configura el subproceso principal para trabajar con STA. (@"Data Source=|DataDirectory|\Inventario.db;Version=3;";)
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormularioProductos());   
        }
    }
}
