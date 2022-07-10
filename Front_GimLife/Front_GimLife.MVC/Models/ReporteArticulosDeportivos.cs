namespace Front_GimLife.MVC.Models
{
    public class ReporteArticulosDeportivos
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public int precio_compra { get; set; }
        public int precio_venta { get; set; }
        public string proveedor { get; set; }

    }


    public class ReportesClientes
    {
        public int id_dni { get; set; }
        public string cliente { get; set; }
        public int dni { get; set; }
        public string fecha_ini { get; set; }
        public string fecha_fin { get; set; }
        public string ocupacion { get; set; }
        public string planes { get; set; }
        public string promocion { get; set; }


    }
}
