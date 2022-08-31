using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ErrorDeProducción
    {
        public ErrorDeProducción()
        {
            ProyectoCorrecións = new HashSet<ProyectoCorreción>();
        }

        public int Identificador { get; set; }
        public int Software { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public string Impacto { get; set; } = null!;

        public virtual Software SoftwareNavigation { get; set; } = null!;
        public virtual ICollection<ProyectoCorreción> ProyectoCorrecións { get; set; }
    }
}
