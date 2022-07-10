using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Cliente
    {
        public int IdDni { get; set; }
        public int? Dni { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Ocupacion { get; set; }
        public int? TelefonoEmergencia { get; set; }
        public int? IdPlanes { get; set; }
        public int? IdPromocion { get; set; }
        public string? NumBoleta { get; set; }

        public virtual Planes? IdPlanesNavigation { get; set; }
        public virtual Promocion? IdPromocionNavigation { get; set; }
    }
}
