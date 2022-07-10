using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class ProveedorDTO
    {
        public int IdProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Ruc { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Correo { get; set; }

    }
}
