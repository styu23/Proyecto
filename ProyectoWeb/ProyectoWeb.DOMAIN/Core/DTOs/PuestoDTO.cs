using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class PuestoDTO
    {
        public int IdPuesto { get; set; }
        public string? Nombre { get; set; }
        public int? IdAreas { get; set; }
    }
}
