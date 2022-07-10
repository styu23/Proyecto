using System;
using System.Collections.Generic;

namespace ProyectoWeb.DOMAIN.Core.Entities
{
    public partial class Persona
    {
        public Persona()
        {
            Empleado = new HashSet<Empleado>();
            Entrenador = new HashSet<Entrenador>();
        }

        public int IdPersona { get; set; }
        public int? Dni { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Sexo { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Entrenador> Entrenador { get; set; }
    }
}
