using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ProyectoCorreción
    {
        public ProyectoCorreción()
        {
            EmpleadoProyectos = new HashSet<EmpleadoProyecto>();
            ProyectoErrors = new HashSet<ProyectoError>();
        }

        public int Identificador { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalización { get; set; }
        public float EsfuerzoEstimado { get; set; }
        public float EsfuerzoReal { get; set; }
        public int? Error { get; set; }

        public virtual ErrorDeProducción? ErrorNavigation { get; set; }
        public virtual ICollection<EmpleadoProyecto> EmpleadoProyectos { get; set; }
        public virtual ICollection<ProyectoError> ProyectoErrors { get; set; }
    }
}
