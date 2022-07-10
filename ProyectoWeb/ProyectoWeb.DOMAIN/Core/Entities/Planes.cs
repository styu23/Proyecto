using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Planes
    {
        public Planes()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdPlanes { get; set; }
        public string? Planes1 { get; set; }
        public int? Precio { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
