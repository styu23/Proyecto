using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class ProductoDTO
    {

        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public int? Cantidad { get; set; }
        public int? PrecioCompra { get; set; }
        public int? PrecioVenta { get; set; }
    }
}
