using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class ClienteDTO
    {
        public int IdDni { get; set; }
        public int? Dni { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Ocupacion { get; set; }
     
    }

    public class ClientePrincipalDTO {
        public int? Dni { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Ocupacion { get; set; }
        public int? TelefonoEmergencia {    get; set; }
            

        }

    public class ClienteOcupacion {
        public int? Dni { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Ocupacion { get; set; }
    }


}
