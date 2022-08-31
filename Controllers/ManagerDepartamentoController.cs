using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;

namespace Tarea_1.Controllers
{
    public class ManagerDepartamentoController : Controller
    {
        private readonly Tarea_1Context _context;

        public ManagerDepartamentoController(Tarea_1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ManagerDepartamentos.ToListAsync());
        }
    }
}
