using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de empleado
 * @params: Identificador 
 * @params: Software
 * @params: Descripcion
 * @params: FechaHora
 * @params: Impacto
 * */
namespace Tarea_1.Models.ViewModels
{
    public class ErrorProduccionViewModel
    {
        [Required]
        public int Identificador { get; set; }

        [Required]
        public int Software { get; set; } 

        [Required]
        public string? Descripcion { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        public String? Impacto { get; set; }
    }    
}
