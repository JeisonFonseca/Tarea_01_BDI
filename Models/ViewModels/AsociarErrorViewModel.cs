using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de asociar error
 * @params: proyecto 
 * @params: error
 * @params: nota
 */

namespace Tarea_1.Models.ViewModels
{
    public class AsociarErrorViewModel
    {

        [Required]
        public int Proyecto { get; set; }

        [Required]
        public int Error { get; set; }

        public string? Nota { get; set; }
    }
}
