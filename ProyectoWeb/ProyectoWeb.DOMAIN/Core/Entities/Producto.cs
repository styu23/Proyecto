using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public int? Cantidad { get; set; }
        public int? PrecioCompra { get; set; }
        public int? PrecioVenta { get; set; }
        public int? IdProveedor { get; set; }

        public virtual Proveedor? IdProveedorNavigation { get; set; }
    }
}
