using System.ComponentModel.DataAnnotations;

namespace Tarea_1.Models.ViewModels
{
	public class DepartamentoViewModel
	{
		[Required]
		public int CodigoDepartamento { get; set; }

		[Required]
		public string Nombre { get; set; }
	}
}
