using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

namespace Tarea_1.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly Tarea_1Context _context;

        public EmpleadoController(Tarea_1Context context)
        {
            _context = context;
        }

        /**
         * Funcion encargada de mostrar la informacion de los Empleados
         */
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleados.ToListAsync()); // Aqui quiero meter el encargadoDepartamento para mostrarlo en la vista
        }


        /**
          * Funcion encargada de crear los empleados
         */
        public async Task<IActionResult> Create(EmpleadoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var empleado = new Empleado()
                {
                    Cedula = model.Cedula,
                    Nombre = model.Nombre,
                    Apellido1 = model.Apellido1,
                    Apelllido2 = model.Apellido2,
                    Rol = model.Rol
                };
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Index));
            }
            
            return View(model);
        }

    }
}
