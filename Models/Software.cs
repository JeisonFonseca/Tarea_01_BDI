using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class Software
    {
        public Software()
        {
            ErrorDeProduccións = new HashSet<ErrorDeProducción>();
            ServidorProyectos = new HashSet<ServidorProyecto>();
        }

        public int CodigoSoftware { get; set; }
        public int NumeroPatente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripción { get; set; } = null!;
        public string TipoSoftware { get; set; } = null!;
        public DateTime FechaPuestaProducción { get; set; }
        public DateTime FechaExpiraciónLicencia { get; set; }

        public virtual ManagerSoftware ManagerSoftware { get; set; } = null!;
        public virtual ICollection<ErrorDeProducción> ErrorDeProduccións { get; set; }
        public virtual ICollection<ServidorProyecto> ServidorProyectos { get; set; }
    }
}
