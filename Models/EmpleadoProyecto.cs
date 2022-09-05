using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class EmpleadoProyecto
    {
        public string CedulaEmpleado { get; set; } = null!;
        public int NumeroProyecto { get; set; }
        public int Horas { get; set; }

        public virtual Empleado CedulaEmpleadoNavigation { get; set; } = null!;
        public virtual ProyectoCorreción NumeroProyectoNavigation { get; set; } = null!;
    }
}
