using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            EmpleadoDepartamentos = new HashSet<EmpleadoDepartamento>();
            ManagerSoftwares = new HashSet<ManagerSoftware>();
        }

        public int CodigoDepartamento { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ManagerDepartamento ManagerDepartamento { get; set; } = null!;
        public virtual ICollection<EmpleadoDepartamento> EmpleadoDepartamentos { get; set; }
        public virtual ICollection<ManagerSoftware> ManagerSoftwares { get; set; }
    }
}
