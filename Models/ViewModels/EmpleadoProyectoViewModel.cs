using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de empleado proyecto
 * @params: CedulaEmpleado 
 * @params: NumeroProyecto
 * @params: Horas
 */
namespace Tarea_1.Models.ViewModels
{
    public class EmpleadoProyectoViewModel
    {
        [Required]
        public string? CedulaEmpleado { get; set; }

        [Required]
        public int NumeroProyecto { get; set; }

        [Required]
        public int Horas { get; set; }

    }
}
