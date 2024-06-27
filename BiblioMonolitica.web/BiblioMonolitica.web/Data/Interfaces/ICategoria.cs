using BiblioMonolitica.web.Data.Models.CategoriaModels;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface ICategoria
    {
        void Create(CreateCategoriaModels createCategoria);
        void Update(UpdateCategoriaModels updateCategoria);
        void Delete(DeleteCategoriaModels deleteCategoria);

        List<CategoriaModel>GetCategoria();
        CategoriaModel GetCategoria(int idcategoria);

    }
}
