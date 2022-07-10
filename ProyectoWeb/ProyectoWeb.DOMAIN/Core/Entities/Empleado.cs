using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public int? IdPersona { get; set; }
        public string? Sueldo { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }

        public virtual Persona? IdPersonaNavigation { get; set; }
    }
}
