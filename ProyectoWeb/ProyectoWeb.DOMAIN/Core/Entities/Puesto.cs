using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Puesto
    {
        public int IdPuesto { get; set; }
        public string? Nombre { get; set; }
        public int? IdAreas { get; set; }

        public virtual Areas? IdAreasNavigation { get; set; }
    }
}
