using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models.CategoriaModels;

namespace BiblioMonolitica.web.Mappeo
{
        public static class CategoriaMapper
        {   
            public static Categoria ToEntity(CreateCategoriaModels modelCategoria)
            {
                return new Categoria
                {
                    idCategoria = modelCategoria.idCategoria,
                    Descripcion = modelCategoria.Descripcion,
                    Estado = modelCategoria.Estado,
                    FechaCreacion = modelCategoria.FechaCreacion
                    
                };
            }

            public static CategoriaModel ToModel(Categoria entityCategoria)
            {
                return new CategoriaModel
                {
                 idCategoria = entityCategoria.idCategoria,
                 Descripcion = entityCategoria.Descripcion,
                 Estado = entityCategoria.Estado,
                 FechaCreacion = entityCategoria.FechaCreacion

                };
            }

            public static void UpdateEntityCategoria(UpdateCategoriaModels modelcategoria, Categoria entityCategoria)
            {
                entityCategoria.idCategoria = modelcategoria.idCategoria;
                entityCategoria.Descripcion = modelcategoria.Descripcion;
                entityCategoria.Estado = modelcategoria.Estado;
                entityCategoria.FechaCreacion = modelcategoria.FechaCreacion;

            }

            public static void DeleteEntityCategoria(DeleteCategoriaModels deleteModel, Categoria deleteEntity)
            {
                deleteEntity.idCategoria = deleteModel.idCategoria;
                deleteEntity.Descripcion = deleteModel.Descripcion;
                deleteEntity.Estado = deleteModel.Estado;
                deleteEntity.FechaCreacion = deleteModel.FechaCreacion;

            }

    }
    
}
