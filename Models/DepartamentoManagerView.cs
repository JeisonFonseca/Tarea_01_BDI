using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class DepartamentoManagerView
    {
        public int CodigoDepartamento { get; set; }
        public string Nombre { get; set; } = null!;
        public string CedulaEmpleadoManager { get; set; } = null!;
        public string NombreEmpleado { get; set; } = null!;
    }
}
