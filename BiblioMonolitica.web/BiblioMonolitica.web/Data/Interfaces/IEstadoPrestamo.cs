using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface IEstadoPrestamo
    {
        void Create(CreateEstadoPrestamoModel createEstadoPrestamo);
        void Update (UpdateEstadoPrestamoModel updateEstadoPrestamo);
        void Delete(DeleteEstadoPrestamoModel deleteEstadoPrestamo);

        List<EstadoPrestamoModel> GetEstadoPrestamo();
        EstadoPrestamoModel GetEstadoPrestamo(int idEstadoPrestamo);
    }
}
