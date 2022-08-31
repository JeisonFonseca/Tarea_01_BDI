using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ManagerSoftware
    {
        public int CodigoDepartamento { get; set; }
        public int CodigoSoftware { get; set; }

        public virtual Departamento CodigoDepartamentoNavigation { get; set; } = null!;
        public virtual Software CodigoSoftwareNavigation { get; set; } = null!;
    }
}
