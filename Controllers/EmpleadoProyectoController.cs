using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

namespace Tarea_1.Controllers
{
    public class EmpleadoProyectoController : Controller
    {
        private readonly Tarea_1Context _context;

        public EmpleadoProyectoController(Tarea_1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonasProyectoViews.ToListAsync()); // Aqui quiero meter el encargadoDepartamento para mostrarlo en la vista
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmpleadoProyectoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var empleadoProyecto = new EmpleadoProyecto()
                {
                    CedulaEmpleado = model.CedulaEmpleado,
                    NumeroProyecto = model.NumeroProyecto,
                    Horas = model.Horas
                };
                _context.Add(empleadoProyecto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

    }
}
