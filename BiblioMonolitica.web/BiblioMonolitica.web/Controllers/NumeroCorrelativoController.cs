using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class NumeroCorrelativoController : Controller
    {

   
        // GET: NumeroCorrelativoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NumeroCorrelativoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NumeroCorrelativoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NumeroCorrelativoController/Create
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

        // GET: NumeroCorrelativoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NumeroCorrelativoController/Edit/5
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

        // GET: NumeroCorrelativoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NumeroCorrelativoController/Delete/5
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
