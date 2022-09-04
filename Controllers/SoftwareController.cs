using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea_1.Models;
using Tarea_1.Models.ViewModels;

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
            return View(await _context.SoftwaresViews.ToListAsync());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SoftwareViewModel model)
        {
            if (ModelState.IsValid)
            {

                var software = new Software()
                {
                    CodigoSoftware = model.CodigoSoftware,
                    NumeroPatente = model.NumeroPatente,
                    Nombre = model.Nombre,
                    Descripción =  model.Descripción,
                    TipoSoftware = model.TipoSoftware,
                    FechaPuestaProducción = model.FechaPuestaProducción,
                    FechaExpiraciónLicencia = model.FechaExpiraciónLicencia
                };

         
                var managerSoftware = new ManagerSoftware()
                {
                    CodigoSoftware = model.CodigoSoftware,
                    CodigoDepartamento = model.DepartamentoEncargado
                };

                var servidor_proyecto = new ServidorProyecto()
                {
                    NumeroSerieServidor = model.NumeroSerieServidor,
                    CodigoSoftware = model.CodigoSoftware,
                    Rol = model.Rol
                };
                
                _context.Add(software);
                _context.Add(managerSoftware);
                _context.Add(servidor_proyecto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
