using BiblioMonolitica.web.Data.Interfaces;
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
            return View();
        }

        // GET: EstadoPrestamoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoPrestamoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
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
            return View();
        }

        // POST: EstadoPrestamoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
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
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
