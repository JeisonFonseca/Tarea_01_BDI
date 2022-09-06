using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de departamento
 * @params: CodigoDepartamento 
 * @params: Nombre
 * @params: Encargado
 */
namespace Tarea_1.Models.ViewModels
{
	public class DepartamentoViewModel
	{
		[Required]
		public int CodigoDepartamento { get; set; }

		[Required]
		public string Nombre { get; set; }

		[Required]
		public string Encargado { get; set; }
	}
}
