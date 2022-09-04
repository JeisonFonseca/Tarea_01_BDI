using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

namespace Tarea_1.Controllers
{
    public class ErrorProduccionController : Controller
    {
        private readonly Tarea_1Context _context;

        public ErrorProduccionController(Tarea_1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ErrorDeProduccións.ToListAsync());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ErrorProduccionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var errorProduccion = new ErrorDeProducción()
                {
                    Identificador = model.Identificador,
                    Software = model.Software,
                    Descripcion = model.Descripcion,
                    FechaHora = model.FechaHora,
                    Impacto = model.Impacto
                };
                _context.Add(errorProduccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

    }
}
