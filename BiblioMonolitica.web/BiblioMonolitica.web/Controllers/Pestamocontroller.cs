using BiblioMonolitica.web.Data.Context;
using BiblioMonolitica.web.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class Pestamocontroller : Controller
    {
        private PrestamosContext context;

        public IPrestamosDb Prestamodb { get; }

        public Pestamocontroller(IPrestamosDb prestamosDb)
        {
            this.Prestamodb = prestamosDb;  
        }
        // GET: Pestamocontroller
        public ActionResult Index()
        {
            var Prestamo = this.Prestamodb.Prestamos;
            return View();
        }

        // GET: Pestamocontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pestamocontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pestamocontroller/Create
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

        // GET: Pestamocontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pestamocontroller/Edit/5
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

        // GET: Pestamocontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pestamocontroller/Delete/5
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
