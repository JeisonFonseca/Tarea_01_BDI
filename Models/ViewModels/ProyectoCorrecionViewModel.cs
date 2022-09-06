using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de empleado
 * @params: Identificador 
 * @params: Error
 * @params: Nombre
 * @params: Descripcion
 * @params: FechaInicio
 * @params: FechaFinalización
 * @params: EsfuerzoEstimado
 * @params: EsfuerzoReal
 * */
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
