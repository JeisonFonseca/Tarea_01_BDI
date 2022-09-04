using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

namespace Tarea_1.Controllers
{
    public class ServidorController : Controller
    {
        private readonly Tarea_1Context _context;

        public ServidorController(Tarea_1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Servidors.ToListAsync()); // Aqui quiero meter el encargadoDepartamento para mostrarlo en la vista
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServidorViewModel model)
        {
            if (ModelState.IsValid)
            {
                var servidor = new Servidor()
                {
                    NumeroSerie = model.NumeroSerie,
                    Marca = model.Marca,
                    Modelo = model.Modelo,
                    FechaCompra=model.FechaCompra,
                    CapacidadProcesamiento = model.CapacidadProcesamiento,
                    CapacidadAlmacenamiento = model.CapacidadAlmacenamiento,
                    MemoriaRam = model.MemoriaRam
                };
                _context.Add(servidor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        

    }
}
