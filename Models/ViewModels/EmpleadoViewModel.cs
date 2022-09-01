using System.ComponentModel.DataAnnotations;

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
