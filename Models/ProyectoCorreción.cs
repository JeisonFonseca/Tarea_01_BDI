﻿using System;
using System.Collections.Generic;

namespace Tarea_1.Models
{
    public partial class ProyectoCorreción
    {
        public ProyectoCorreción()
        {
            EmpleadoProyectos = new HashSet<EmpleadoProyecto>();
        }

        public int Identificador { get; set; }
        public int Error { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalización { get; set; }
        public float EsfuerzoEstimado { get; set; }
        public float EsfuerzoReal { get; set; }

        public virtual ErrorDeProducción ErrorNavigation { get; set; } = null!;
        public virtual ICollection<EmpleadoProyecto> EmpleadoProyectos { get; set; }
    }
}
