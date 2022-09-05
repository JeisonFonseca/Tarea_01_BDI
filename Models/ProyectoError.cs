using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ProyectoError
    {
        public int Proyecto { get; set; }
        public int Error { get; set; }
        public string? Nota { get; set; }

        public virtual ErrorDeProducción ErrorNavigation { get; set; } = null!;
        public virtual ProyectoCorreción ProyectoNavigation { get; set; } = null!;
    }
}
