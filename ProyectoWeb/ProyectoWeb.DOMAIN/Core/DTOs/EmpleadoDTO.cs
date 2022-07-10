using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Core.DTOs
{
    public class EmpleadoDTO
    {

        public int IdEmpleado { get; set; }
        public int? IdPersona { get; set; }
        public string? Sueldo { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
    }

    public class EmpleadosDTO
    {
        public int? IdPersona { get; set; }
       
        public string? Usuario { get; set; }
        

        }
}
