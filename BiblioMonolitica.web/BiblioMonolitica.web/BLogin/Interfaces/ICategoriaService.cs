using BiblioMonolitica.web.BLogin.core;
using BiblioMonolitica.web.Data.Models.CategoriaModels;

namespace BiblioMonolitica.web.BLogin.Interfaces
{
    public interface ICategoriaService
    {
        
        ServiceResult GetCategoria();
        ServiceResult GetCategoriaByID(int id);
        ServiceResult UpdateCategoriaModel(UpdateCategoriaModels updateCategoriaModels);
        ServiceResult DeleteCategoriaModel(DeleteCategoriaModels deleteCategoriaModels);
        ServiceResult CreateCategoriaModels(CreateCategoriaModels createCategoriaModels);
        

    }
}
