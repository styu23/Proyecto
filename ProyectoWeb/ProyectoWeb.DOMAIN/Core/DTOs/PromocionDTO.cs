using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class PromocionDTO
    {
         public int IdPromocion { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? Descuento { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
