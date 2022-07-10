using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Entrenador
    {
        public int IdEntrenador { get; set; }
        public string? Descripcion { get; set; }
        public int? IdPersona { get; set; }

        public virtual Persona? IdPersonaNavigation { get; set; }
    }
}
