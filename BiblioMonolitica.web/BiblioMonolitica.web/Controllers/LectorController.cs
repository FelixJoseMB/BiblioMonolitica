﻿using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
    public class LectorController : Controller
    {
        private readonly ILector lector;
        public LectorController(ILector lector) 
        {
            this.lector = lector;
        }

        // GET: LectorController
        public ActionResult Index()
        {
            var lector = this.lector.GetLectors(); 
            return View(lector);
        }

        // GET: LectorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LectorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LectorController/Create
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

        // GET: LectorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LectorController/Edit/5
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

        // GET: LectorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LectorController/Delete/5
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
