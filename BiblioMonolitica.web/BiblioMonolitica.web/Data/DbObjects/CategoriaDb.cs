using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Exeptions;
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
            var categoria = CategoriaMapper.ToEntity(createCategoria);
            categoria.Estado = true;
            this.context.categoria.Add(categoria);
            this.context.SaveChanges();

        }

        public void Delete(DeleteCategoriaModels deleteCategoria)
        {
            Categoria categoriaToDelete = this.context.categoria.Find(deleteCategoria.idCategoria);

            if (categoriaToDelete == null)
            {
                throw new ArgumentException("categoria no encontrada");

            }
            // Utilizar el método DeleteEntityUsuario para eliminar la entidad con los datos de eliminación
            CategoriaMapper.DeleteEntityCategoria(deleteCategoria, categoriaToDelete);

            categoriaToDelete.Estado = false;
            this.context.categoria.Remove(categoriaToDelete);
            this.context.SaveChanges();
        }
        public List<CategoriaModel> GetCategoria()
        {
            return this.context.categoria.Select(CategoriaMapper.ToModel).ToList();
        }


        public CategoriaModel GetCategoria(int idcategoria)
        {
            var categoria = this.context.categoria.Find(idcategoria);
            if (categoria is null)
            {
                throw new CategoriaDbExeption($"no se encontro la categoria con la id {idcategoria}");
            }

            CategoriaModel categoriamodel = new CategoriaModel()
            {
                idCategoria = categoria.idCategoria,
                Descripcion = categoria.Descripcion,
                Estado = categoria.Estado,
                FechaCreacion = categoria.FechaCreacion
            };
            return categoriamodel;
        }

      

        public void Update(UpdateCategoriaModels updateCategoria)
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
