using BiblioMonolitica.web.BL.Interfaces;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Data.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class EstadoPrestamoController : Controller
    {
        private readonly IEstadoPrestamoService estadoPrestamoService;

        public EstadoPrestamoController(IEstadoPrestamoService estadoPrestamoService)
        {
            this.estadoPrestamoService = estadoPrestamoService;
        }

        // GET: EstadoPrestamoController
        public ActionResult Index()
        {
            var result = this.estadoPrestamoService.GetEstadoPrestamo();

            var estadoPrestamo = (List<EstadoPrestamoModel>)result.Data;
            return View(estadoPrestamo);
        }

        // GET: EstadoPrestamoController/Details/5
        public ActionResult Details(int id)
        {
            var estadoPrestamo = this.estadoPrestamoService.GetEstadoPrestamoByID(id).Data;

            return View(estadoPrestamo);

        }

        // GET: EstadoPrestamoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoPrestamoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEstadoPrestamoModel createEstadoPrestamoModel)
        {
            try
            {
                this.estadoPrestamoService.CreateEstadoPrestamoModel(createEstadoPrestamoModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstadoPrestamoController/Edit/5
        public ActionResult Edit(int id)
        {
            var estadoPrestamo = this.estadoPrestamoService.GetEstadoPrestamoByID(id).Data;
            return View(estadoPrestamo);
        }

        // POST: EstadoPrestamoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateEstadoPrestamoModel updateEstadoPrestamoModel)
        {
            try
            {
                var result = this.estadoPrestamoService.UpdateModelEstadoPrestamo(updateEstadoPrestamoModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstadoPrestamoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoPrestamoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DeleteEstadoPrestamoModel deleteEstadoPrestamoModel)
        {
            try
            {

                this.estadoPrestamoService.DeleteEstadoPrestamoModel(deleteEstadoPrestamoModel);
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(deleteEstadoPrestamoModel);
            }
            catch
            {
                return View(deleteEstadoPrestamoModel);
            }
        }
    }
}
