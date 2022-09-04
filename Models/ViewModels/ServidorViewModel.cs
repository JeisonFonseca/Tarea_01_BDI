using System.ComponentModel.DataAnnotations;

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
