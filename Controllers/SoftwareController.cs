using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;

namespace Tarea_1.Controllers
{
    public class SoftwareController : Controller
    {
        private readonly Tarea_1Context _context;

        public SoftwareController(Tarea_1Context context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var encargadoDepartamento = _context.ManagerDepartamentos.Include(e=>e.CodigoDepartamento);
            return View(await _context.Softwares.ToListAsync()); // Aqui quiero meter el encargadoDepartamento para mostrarlo en la vista
        }

        public IActionResult Create()
        {
           // ViewData["Message"] =
            return View();
        }
    }
}
