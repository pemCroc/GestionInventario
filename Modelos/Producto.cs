namespace SistemaGestionInventario.Modelos
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public string Proveedor { get; set; }
    }
}
