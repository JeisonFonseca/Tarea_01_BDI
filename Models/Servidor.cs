using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class Servidor
    {
        public int NumeroSerie { get; set; }
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public DateTime FechaCompra { get; set; }
        public double CapacidadProcesamiento { get; set; }
        public int CapacidadAlmacenamiento { get; set; }
        public int MemoriaRam { get; set; }
    }
}
