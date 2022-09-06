using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de empleado
 * @params: Cedula 
 * @params: Nombre
 * @params: Apellido1
 * @params: Apellido2
 * @params: Rol
 * */
namespace Tarea_1.Models.ViewModels
{
    public class EmpleadoViewModel
    {
        [Required]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido1 { get; set; }

        [Required]
        public string Apellido2 { get; set; }

        [Required]
        public string Rol { get; set; } 

    }

}
