using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Areas
    {
        

        public int IdAreas { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Puesto> Puesto { get; set; }
    }
}
