using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Ruc { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Correo { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
