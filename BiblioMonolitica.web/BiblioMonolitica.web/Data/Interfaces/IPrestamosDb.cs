using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using Microsoft.Identity.Client;
using System.Linq.Expressions;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface IPrestamoDb
    {
        void Create(CreatePrestamosModel createPrestamosModel);
        void Update(UpdatePrestamomodel updatePrestamo);
        void Delete(DeletePrestamosModel DeletePrestamo);

        List<PrestamosModel> GetPrestamos();
        PrestamosModel GetPrestamos(int IdPrestamo);


    }
}