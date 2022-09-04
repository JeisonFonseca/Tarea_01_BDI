using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

namespace Tarea_1.Controllers
{
    public class ProyectoCorrecionController : Controller
    {
        private readonly Tarea_1Context _context;

        public ProyectoCorrecionController(Tarea_1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ProyectoCorrecións.ToListAsync());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProyectoCorrecionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var proyectoCorreccion = new ProyectoCorreción()
                {
                    Identificador = model.Identificador,
                    Error = model.Error,
                    Nombre = model.Nombre,
                    Descripcion = model.Descripcion,
                    FechaInicio = model.FechaInicio,
                    FechaFinalización = model.FechaFinalización,
                    EsfuerzoEstimado = model.EsfuerzoEstimado,
                    EsfuerzoReal = model.EsfuerzoReal
                };
                _context.Add(proyectoCorreccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

    }
}
