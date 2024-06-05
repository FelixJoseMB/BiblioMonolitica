using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.CategoriaModels;
using BiblioMonolitica.web.Mappeo;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class CategoriaDb : ICategoria
    {
        private readonly BibliotecaContext context;
        public CategoriaDb(BibliotecaContext context)
        {
            this.context = context;
        }
        public void Create(CreateCategoriaModels createCategoria)
        {
            Categoria categoria = new Categoria()
            {
                Descripcion = createCategoria.Descripcion,
                Estado = createCategoria.Estado,
                FechaCreacion = createCategoria.FechaCreacion
            };
            this.context.categoria.Add(categoria);
            this.context.SaveChanges();

        }

        public void Delete(DeleteCategoriaModels deleteCategoria)
        {
            throw new NotImplementedException();
        }
        public List<CategoriaModel> GetCategoria()
        {
            return this.context.categoria.Select(categoria => new CategoriaModel()
            {
                idCategoria = categoria.idCategoria,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado,
                FechaCreacion = categoria.FechaCreacion
                

            }).ToList();
        }


        public CategoriaModel GetCategoriaModel(int idcategoria)
        {
            var categoria = this.context.categoria.Find(idcategoria);

            CategoriaModel categoriamodel = new CategoriaModel()
            {
                idCategoria = categoria.idCategoria,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado,
                FechaCreacion = categoria.FechaCreacion
            };
            return categoriamodel;
        }

        public List<CategoriaModel> GetCategoriaModels()
        {
            return this.context.categoria.Select(CategoriaMapper.ToModel).ToList();
        }

        public void update(UpdateCategoriaModels updateCategoria)
        {
            Categoria categoriaToUpdate = this.context.categoria.Find(updateCategoria.idCategoria);
            categoriaToUpdate.idCategoria = updateCategoria.idCategoria;
            categoriaToUpdate.Descripcion = updateCategoria.Descripcion;
            categoriaToUpdate.Estado = updateCategoria.Estado;
            categoriaToUpdate.FechaCreacion = updateCategoria.FechaCreacion;

            this.context.Update(categoriaToUpdate);
            this.context.SaveChanges();
        }
    }
}
