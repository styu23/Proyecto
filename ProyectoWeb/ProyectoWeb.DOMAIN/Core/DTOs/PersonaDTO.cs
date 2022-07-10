﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class PersonaDTO
    {
        public int IdPersona { get; set; }
        public int? Dni { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Sexo { get; set; }
    }
}
