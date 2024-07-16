using BiblioMonolitica.web.BLogin.Dtos;
using BiblioMonolitica.web.Data.Context;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiblioMonolitica.web.Controllers
{
public class Pestamocontroller : Controller
{
    private PrestamosContext context;

    private readonly IPrestamoDb Prestamodb;

    public Pestamocontroller(IPrestamoDb prestamosDb)
    {
        this.Prestamodb = prestamosDb;
    }

    // GET: Prestamo controlller
    public ActionResult Index()
    {
        var prestamos = this.Prestamodb.GetPrestamos();
        return View(prestamos);
    }

    // GET: PrestamoController/Details/5
    public ActionResult Details(int id)
    {
        var prestamos = this.Prestamodb.GetPrestamos(id);

        var DetailPrestamo = new PrestamosModel
        {
        IdPrestamo = prestamos.IdPrestamo,
        Estado = prestamos.Estado,
        FechaDevolucion = prestamos.FechaDevolucion
        };
        return View(DetailPrestamo);

    }

    // GET: EstadoPrestamoController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: EstadoPrestamoController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(CreatePrestamosModel createPrestamosModel)
    {
        try
        {
            this.Prestamodb.Create(createPrestamosModel);
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
        var estadoPrestamo = this.Prestamodb.GetPrestamos(id);
        return View(estadoPrestamo);
    }

    // POST: EstadoPrestamoController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(UpdatePrestamomodel updatePrestamomodel)
    {
        try
        {
           
            this.Prestamodb.Update(updatePrestamomodel);
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
    public ActionResult Delete(DeletePrestamosModel deletePrestamosModel)
    {
        try
        {

            this.Prestamodb.Delete(deletePrestamosModel);
            return RedirectToAction(nameof(Index));
        }
        catch (ArgumentException ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return View(deletePrestamosModel);
        }
        catch
        {
            return View(deletePrestamosModel);
        }
    }
}
}