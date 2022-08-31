using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class Empleado
    {
        public string Cedula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public string Apelllido2 { get; set; } = null!;
        public string Rol { get; set; } = null!;
    }
}
