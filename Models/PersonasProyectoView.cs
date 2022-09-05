using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class PersonasProyectoView
    {
        public string Cedula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public int NumeroProyecto { get; set; }
        public string NombreProyecto { get; set; } = null!;
        public int Horas { get; set; }
        public string Rol { get; set; } = null!;
    }
}
