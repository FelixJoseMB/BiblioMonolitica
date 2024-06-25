using BiblioMonolitica.web.BL.Core;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Data.Models.Usuario;

namespace BiblioMonolitica.web.BL.Interfaces
{
    public interface IEstadoPrestamoService
    {
        ServiceResult GetEstadoPrestamo();
        ServiceResult GetEstadoPrestamoByID(int id);
        ServiceResult UpdateModelEstadoPrestamo(UpdateEstadoPrestamoModel updateEstadoPrestamoModel);
        ServiceResult DeleteEstadoPrestamoModel(DeleteEstadoPrestamoModel deleteEstadoPrestamoModel);
        ServiceResult CreateEstadoPrestamoModel(CreateEstadoPrestamoModel createEstadoPrestamoModel);
    }
}
