using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de empleado
 * @params: CodigoSoftware 
 * @params: NumeroPatente
 * @params: Nombre
 * @params: Descripción
 * @params: TipoSoftware
 * @params: FechaPuestaProducción
 * @params: FechaExpiraciónLicencia
 * @params: DepartamentoEncargado
 * @params: NumeroSerieServidor
 * @params: Rol
 * */
namespace Tarea_1.Models.ViewModels
{
    public class SoftwareViewModel
    {
        [Required]
        public int CodigoSoftware { get; set; }

        [Required]
        public int NumeroPatente { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public string Descripción { get; set; } = null!;

        [Required]
        public string TipoSoftware { get; set; } = null!;

        [Required]
        public DateTime FechaPuestaProducción { get; set; }

        [Required]
        public DateTime FechaExpiraciónLicencia { get; set; }

        [Required]
        public int DepartamentoEncargado { get; set; }

        [Required]
        public int NumeroSerieServidor { get; set; }

        [Required]
        public string Rol { get; set; }

        public virtual ICollection<ErrorDeProducción>? ErrorDeProduccións { get; set; }
        
        public virtual ICollection<ServidorProyecto>? ServidorProyectos { get; set; }

    }
}
  
