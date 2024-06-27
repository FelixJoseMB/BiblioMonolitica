using BiblioMonolitica.web.BLogin.Interfaces;
using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Models.CategoriaModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService categoriaService;
        
        public CategoriaController(ICategoriaService categoriaService)
        {
           
            this.categoriaService = categoriaService;
        }
        // GET: CategoriaController
        public ActionResult Index()
        {
            var result = this.categoriaService.GetCategoria();
            var categoria = (List<CategoriaModel>)result.Data;
            return View(categoria);
        }

        // GET: CategoriaController/Details/5
        public ActionResult Details(int id)
        {
            var Categoria = this.categoriaService.GetCategoriaByID(id).Data;
            return View(Categoria);
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCategoriaModels createCategoriaModels)
        {
            try
            {
                this.categoriaService.CreateCategoriaModels(createCategoriaModels);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = this.categoriaService.GetCategoriaByID(id).Data; 
            return View(categoria);
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateCategoriaModels updateCategoriaModels)
        {
            try
            {
                var result = this.categoriaService.UpdateCategoriaModel(updateCategoriaModels); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DeleteCategoriaModels deleteCategoriaModels)
        {
            try
            {
                this.categoriaService.DeleteCategoriaModel(deleteCategoriaModels);
                return RedirectToAction(nameof(Index));
            }
            catch(ArgumentException ex) 
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(deleteCategoriaModels);
            }
            catch
            {
                return View(deleteCategoriaModels);
            }
        }
    }
}
