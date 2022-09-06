using System.ComponentModel.DataAnnotations;

/**
 * ViewModel de empleado
 * @params: NumeroSerie 
 * @params: Marca
 * @params: Modelo
 * @params: FechaCompra
 * @params: CapacidadProcesamiento
 * @params: CapacidadAlmacenamiento
 * @params: MemoriaRam
 * */
namespace Tarea_1.Models.ViewModels
{
    public class ServidorViewModel
    {
		[Required]
		public int NumeroSerie { get; set; }

		[Required]
		public string Marca { get; set; }

		[Required]
		public string Modelo { get; set; }

		[Required]
		public DateTime FechaCompra { get; set; }

		[Required]
		public double CapacidadProcesamiento { get; set; }

		[Required]
		public int CapacidadAlmacenamiento { get; set; }

		[Required]
		public int MemoriaRam { get; set; }

	}
}
