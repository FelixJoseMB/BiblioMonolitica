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
            return lector?.ToModel();
        }

        public List<LectorModels> GetLectors()
        {
            return this.context.Lectors.Select(lector => lector.ToModel()).ToList();
        }

        public void RemoveLector(LectorRemoveModel lectorRemove)
        {
            Lector lectorToDelete = this.context.Lectors.Find(lectorRemove.IdLector);

            lectorToDelete.IdLector = lectorRemove.IdLector;
            lectorToDelete.Nombre = lectorRemove.Nombre;
            lectorToDelete.Apellido = lectorRemove.Apellido;

            this.context.Lectors.Remove(lectorToDelete);
            this.context.SaveChanges();
        }

        public void SaveLector(LectorSaveModel lectorSave)
        {
            Lector lector = lectorSave.ToEntity();
            this.context.Lectors.Add(lector);
            this.context.SaveChanges();
        }

        public void UpdateLector(LectorUpdateModel updateModel)
        {
            Lector lectorToUpdate = this.context.Lectors.Find(updateModel.IdLector);

            if (lectorToUpdate == null)
            {
                return;
            }

            updateModel.UpdateEntity(lectorToUpdate);

            this.context.Lectors.Update(lectorToUpdate);
            this.context.SaveChanges();
        }
    }
}


