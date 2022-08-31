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
            return View(await _context.Softwares.ToListAsync());
        }
    }
}
