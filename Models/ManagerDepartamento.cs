using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ManagerDepartamento
    {
        public string CedulaEmpleadoManager { get; set; } = null!;
        public int CodigoDepartamento { get; set; }

        public virtual Empleado CedulaEmpleadoManagerNavigation { get; set; } = null!;
        public virtual Departamento CodigoDepartamentoNavigation { get; set; } = null!;
    }
}
