using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ServidorProyecto
    {
        public int NumeroSerieServidor { get; set; }
        public int CodigoSoftware { get; set; }
        public string Rol { get; set; } = null!;

        public virtual Software CodigoSoftwareNavigation { get; set; } = null!;
        public virtual Servidor NumeroSerieServidorNavigation { get; set; } = null!;
    }
}
