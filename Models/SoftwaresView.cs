using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class SoftwaresView
    {
        public int CodigoSoftware { get; set; }
        public int NumeroPatente { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripción { get; set; } = null!;
        public string TipoSoftware { get; set; } = null!;
        public DateTime FechaPuestaProducción { get; set; }
        public DateTime FechaExpiraciónLicencia { get; set; }
        public int NumeroSerieServidor { get; set; }
        public string Rol { get; set; } = null!;
        public string NombreDepartamento { get; set; } = null!;
    }
}
