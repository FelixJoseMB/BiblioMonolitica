using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Models;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface IPrestamosDb
    {
        void savePrestamos(PrestamosSaveModel prestamos);
        void UpdatePrestamos(PrestamosUpdateModel updateModel);
        void removePrestamos();
        List<PrestamosModel> Prestamos { get; }

        PrestamosModel GetPrestamos(int idPrestamos);

    }
}
