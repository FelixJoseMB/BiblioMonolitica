using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario usuarioDb;

        public UsuarioController(IUsuario usuarioDb)
        {
            this.usuarioDb = usuarioDb;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            var usuario = this.usuarioDb.GetUsuario();
            return View(usuario);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            var Usuario = this.usuarioDb.GetUsuario(id);

            var detailsUsuario = new UsuarioModel
            {
                idUsuario = Usuario.idUsuario,
                NombreApellidos = Usuario.NombreApellidos,
                Correo = Usuario.Correo,
                Clave = Usuario.Clave,
                esActivo = Usuario.esActivo
            };
            return View(detailsUsuario);
            //return View(Usuario);
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
                this.usuarioDb.Create(createUsuarioModel);
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

            var Usuario = this.usuarioDb.GetUsuario(id);
            return View(Usuario);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UpdateUsuarioModel updateUsuarioModel)
        {
            try
            {
                this.usuarioDb.Update(updateUsuarioModel);
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

                this.usuarioDb.Delete(deleteUsuarioModel);
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
