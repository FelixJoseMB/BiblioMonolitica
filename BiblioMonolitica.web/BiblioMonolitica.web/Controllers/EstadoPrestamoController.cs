using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Data.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class EstadoPrestamoController : Controller
    {
        private readonly IEstadoPrestamo estadoPrestamoDb;

        public EstadoPrestamoController(IEstadoPrestamo estadoPrestamoDb)
        {
            this.estadoPrestamoDb = estadoPrestamoDb;
        }

        // GET: EstadoPrestamoController
        public ActionResult Index()
        {
            var estadoPrestamo = this.estadoPrestamoDb.GetEstadoPrestamo();
            return View(estadoPrestamo);
        }

        // GET: EstadoPrestamoController/Details/5
        public ActionResult Details(int id)
        {
            var EstadoPrestamo = this.estadoPrestamoDb.GetEstadoPrestamo(id);

            var detailsEstadoPrestamo = new EstadoPrestamoModel
            {
                idEstadoPrestamo = EstadoPrestamo.idEstadoPrestamo,
                Estado = EstadoPrestamo.Estado,
                Descripcion = EstadoPrestamo.Descripcion
                
            };
            return View(detailsEstadoPrestamo);
            
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
                this.estadoPrestamoDb.Create(createEstadoPrestamoModel);
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
            var estadoPrestamo = this.estadoPrestamoDb.GetEstadoPrestamo(id);
            return View(estadoPrestamo);
        }

        // POST: EstadoPrestamoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateEstadoPrestamoModel updateEstadoPrestamoModel)
        {
            try
            {
                this.estadoPrestamoDb.Update(updateEstadoPrestamoModel);
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

                this.estadoPrestamoDb.Delete(deleteEstadoPrestamoModel);
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
