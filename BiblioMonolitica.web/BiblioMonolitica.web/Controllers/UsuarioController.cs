using BiblioMonolitica.web.BL.Interfaces;
using BiblioMonolitica.web.BL.Service;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            var result = this.usuarioService.GetUsuario();

            var usuario = (List<UsuarioModel>)result.Data;
            return View(usuario);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            var Usuario = this.usuarioService.GetUsuarioByID(id).Data ;

            return View(Usuario);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateUsuarioModel createUsuarioModel)
        {
            try
            {
                this.usuarioService.CreateUsuarioModel(createUsuarioModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {

            var usuario = this.usuarioService.GetUsuarioByID(id).Data ;
            return View(usuario);

        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateUsuarioModel updateUsuarioModel)
        {
            try
            {
                var result = this.usuarioService.UpdateModelUsuario(updateUsuarioModel);
               
                    return RedirectToAction(nameof(Index));
                
               
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DeleteUsuarioModel deleteUsuarioModel)
        {
            try
            {

                this.usuarioService.DeleteUsuarioModel(deleteUsuarioModel);
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(deleteUsuarioModel);
            }
            catch
            {
                return View(deleteUsuarioModel);
            }
        }
    }
}
