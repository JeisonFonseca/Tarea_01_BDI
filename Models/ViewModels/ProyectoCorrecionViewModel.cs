using System.ComponentModel.DataAnnotations;

namespace Tarea_1.Models.ViewModels
{
    public class ProyectoCorrecionViewModel
    {
        [Required]
        public int Identificador { get; set; }

        [Required]
        public int Error { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Descripcion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFinalización { get; set; }

        [Required]
        public float EsfuerzoEstimado { get; set; }

        [Required]
        public float EsfuerzoReal { get; set; }
    }
}
