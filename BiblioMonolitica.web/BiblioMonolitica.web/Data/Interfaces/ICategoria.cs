using BiblioMonolitica.web.Data.Models.CategoriaModels;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface ICategoria
    {
        void Create(CreateCategoriaModels createCategoria);
        void update(UpdateCategoriaModels updateCategoria);
        void Delete(DeleteCategoriaModels deleteCategoria);

        List<CategoriaModel>GetCategoriaModels();
        CategoriaModel GetCategoriaModel(int idcategoria);

    }
}
