using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace BiblioMonolitica.web.Controllers
{
    public class LibroController : Controller
    {
        private readonly ILibro libro;
        public LibroController(ILibro libro)
        {
            this.libro = libro;
        }

        // GET:     Librocontroller
        public ActionResult Index()
        {
            var Libro = this.libro.GetLibro();
            return View(libro);
        }

        // GET: Librocontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Librocontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Librocontroller/Create
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

        // GET: Librocontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Librocontroller/Edit/5
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

        // GET: Librocontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Librocontroller/Delete/5
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
{
}
