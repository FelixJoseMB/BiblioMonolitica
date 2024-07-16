using BiblioMonolitica.web.BLogin.Core;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;

namespace BiblioMonolitica.web.BLogin.Interfaces
{
    public interface IPrestamoService
    {
        List<PrestamosModel> GetPrestamos();
        ServiceResult Getprestamo(int id);
        ServiceResult UpdatePrestamo(UpdatePrestamomodel updatePrestamomodel);
        ServiceResult RemovePrestamos(DeletePrestamosModel deletePrestamosModel);
        ServiceResult SavePrestamos(CreatePrestamosModel createPrestamosModel);
    }
}
