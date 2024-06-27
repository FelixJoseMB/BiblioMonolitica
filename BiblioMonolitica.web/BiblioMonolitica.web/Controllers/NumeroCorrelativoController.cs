using BiblioMonolitica.web.BLogin.Interfaces;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class NumeroCorrelativoController : Controller
    {
        private readonly INumeroCorrelativoService numeroCorrelativoService;

        public NumeroCorrelativoController(INumeroCorrelativoService numeroCorrelativoService)
        {
            this.numeroCorrelativoService = numeroCorrelativoService;
        }



        // GET: NumeroCorrelativoController
        public ActionResult Index()
        {
            var result = this.numeroCorrelativoService.GetNumeroCorrelativo();

            var numerocorrelativo = (List<NumeroCorrelativoModel>)result.Data;
            return View(numerocorrelativo);
        }

        // GET: NumeroCorrelativoController/Details/5
        public ActionResult Details(int id)
        {
            var numerocorrelativo = this.numeroCorrelativoService.GetNumerocorrelativoByID(id).Data;
            return View(numerocorrelativo);
        }

        // GET: NumeroCorrelativoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NumeroCorrelativoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateNumeroCorrelativoModels createNumeroCorrelativoModels)
        {
            try
            {
                this.numeroCorrelativoService.CreateNumeroCorrelativoModels(createNumeroCorrelativoModels); 
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
            var numerocorrelativo = this.numeroCorrelativoService.GetNumerocorrelativoByID(id).Data;
            return View(numerocorrelativo);
        }

        // POST: NumeroCorrelativoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateNumeroCorrelativoModels updateNumeroCorrelativoModels)
        {
            try
            {
                var result = this.numeroCorrelativoService.UpdateNumeroCorrelativoModels(updateNumeroCorrelativoModels);
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
        public ActionResult Delete(DeleteNumeroCorrelativoModels deleteNumeroCorrelativoModels)
        {
            try
            {
                this.numeroCorrelativoService.DeleteNumeroCorrelativoModels(deleteNumeroCorrelativoModels);

                return RedirectToAction(nameof(Index));
            }
            catch(ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(deleteNumeroCorrelativoModels);
            }
            catch 
            {
                return View(deleteNumeroCorrelativoModels);
            }
        }
    }
}
