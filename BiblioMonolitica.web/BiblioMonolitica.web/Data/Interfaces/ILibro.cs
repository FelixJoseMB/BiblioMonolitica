using BiblioMonolitica.web.Models;
using BiblioMonolitica.web.Data.Models;
using System.Collections.Generic;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface ILibro
    {
        void SaveLibro(LibroSaveModel libro);
        void UpdateLibro(LibroUpdateModel updateModel);
        void RemoveLibro(LibroRemoveModel removeModel);
        List<LibroModels> GetLibros();
        LibroModels GetLibro(int IdLibro);
    }
}
