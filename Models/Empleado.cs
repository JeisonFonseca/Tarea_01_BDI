using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            ManagerDepartamentos = new HashSet<ManagerDepartamento>();
            NumeroProyectos = new HashSet<ProyectoCorreción>();
        }

        public string Cedula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public string Apelllido2 { get; set; } = null!;
        public string Rol { get; set; } = null!;

        public virtual EmpleadoDepartamento EmpleadoDepartamento { get; set; } = null!;
        public virtual ICollection<ManagerDepartamento> ManagerDepartamentos { get; set; }

        public virtual ICollection<ProyectoCorreción> NumeroProyectos { get; set; }
    }
}
