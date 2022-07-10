using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Promocion
    {
        public Promocion()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdPromocion { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? Descuento { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
