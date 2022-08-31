using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class EmpleadoDepartamento
    {
        public string CedulaEmpleado { get; set; } = null!;
        public int CodigoDepartamento { get; set; }

        public virtual Empleado CedulaEmpleadoNavigation { get; set; } = null!;
        public virtual Departamento CodigoDepartamentoNavigation { get; set; } = null!;
    }
}
