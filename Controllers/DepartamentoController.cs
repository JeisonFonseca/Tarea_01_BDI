using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

namespace Tarea_1.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly Tarea_1Context _context;

        public DepartamentoController(Tarea_1Context context)
        {
            _context = context;
        }

        /**
         * Funcion encargada de mostrar la informacion de los departamentos
         */
		public async Task<IActionResult> Index()
        {
            return View(await _context.DepartamentoManagerViews.ToListAsync()); // Aqui quiero meter el encargadoDepartamento para mostrarlo en la vista
        }

        /**
          * Funcion encargada de crear los departamentos
         */
        public async Task<IActionResult> Create(DepartamentoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var departamento = new Departamento()
                {
                    CodigoDepartamento = model.CodigoDepartamento,
                    Nombre = model.Nombre,
                };

                var managerDepartamento = new ManagerDepartamento()
                {
                    CodigoDepartamento = model.CodigoDepartamento,
                    CedulaEmpleadoManager = model.Encargado
                };
                _context.Add(departamento);
                _context.Add(managerDepartamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
