using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Models;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class LectorDB : ILector
    {
        private readonly BibliotecaContext context;

        public LectorDB(BibliotecaContext context)
        {
            this.context = context;
        }

        public LectorModels GetLector(int IdLector)
        {
           var lector = this.context.Lectors.Find(IdLector);

            LectorModels lectorModels = new LectorModels()
            {
                IdLector = lector.IdLector, 
                Nombre = lector.Nombre,
                Apellido = lector.Apellido,
                Clave = lector.Clave,
                FechaCreacion = lector.FechaCreacion
            };

           return lectorModels;
        }

        public List<LectorModels> GetLectors()
        {
            return this.context.Lectors.Select(lector => new LectorModels()
            {
                IdLector = lector.IdLector,
                Nombre = lector.Nombre,
                Apellido = lector.Apellido,
                Clave = lector.Clave,
                FechaCreacion = lector.FechaCreacion

            }).ToList();
        }

        public void RemoveLector(LectorRemoveModel lectorRemove)
        {
            Lector lectorToDelete = this.context.Lectors.Find(lectorRemove.IdLector);

            if (lectorToDelete is null)
            {
            }

            lectorToDelete.IdLector = lectorRemove.IdLector;
            lectorToDelete.Nombre = lectorRemove.Nombre;
            lectorToDelete.Codigo = lectorRemove.Codigo;
            lectorToDelete.Apellido = lectorRemove.Apellido;

            this.context.Lectors.Update(lectorToDelete);
            this.context.SaveChanges();
        }

        public void SaveLector(LectorSaveModel lectorSave)
        {
            Lector lector = new Lector()
            {
                IdLector = lectorSave.IdLector,
                Nombre = lectorSave.Nombre,
                Apellido = lectorSave.Apellido,
                Clave = lectorSave.Clave,
                FechaCreacion = lectorSave.FechaCreacion
            };
            this.context.Lectors.Add(lector);
            this.context.SaveChanges();
        }

        public void UpdateLector(LectorUpdateModel updateModel)
        {
            Lector lectorToUpdate = this.context.Lectors.Find(updateModel.IdLector);
            {
                lectorToUpdate.IdLector = lectorToUpdate.IdLector;
                lectorToUpdate.Nombre = lectorToUpdate.Nombre;
                lectorToUpdate.Apellido = lectorToUpdate.Apellido;
                lectorToUpdate.Clave = lectorToUpdate.Clave;
            };
            this.context.Lectors.Update(lectorToUpdate);
            this.context.SaveChanges();
        }
    }
}
