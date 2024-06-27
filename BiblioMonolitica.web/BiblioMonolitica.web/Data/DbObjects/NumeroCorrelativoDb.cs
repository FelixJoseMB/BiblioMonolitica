using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;
using BiblioMonolitica.web.Mappeo;
using BiblioMonolitica.web.Models;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class NumeroCorrelativoDb : INumeroCorrelativo
    {
        private readonly BibliotecaContext context;

        public NumeroCorrelativoDb(BibliotecaContext context)
        {
            this.context = context;
        }

        public void Create(CreateNumeroCorrelativoModels createNumeroCorrelativo)
        {
            var numerocorrelativo = NumeroCorrelativoMapper.ToEntity(createNumeroCorrelativo);
            this.context.NumeroCorrelativo.Add(numerocorrelativo);
            this.context.SaveChanges();
        }

        public void Delete(DeleteNumeroCorrelativoModels deleteNumeroCorrelativo)
        {
            NumeroCorrelativo numeroCorrelativoToDelete = this.context.NumeroCorrelativo.Find(deleteNumeroCorrelativo.idNumeroCorrelativo);

            if (numeroCorrelativoToDelete == null)
            {
                throw new ArgumentException("Numero Correlativo no encontrado");
            }

            NumeroCorrelativoMapper.DeleteEntityNumeroCorrelativo(deleteNumeroCorrelativo, numeroCorrelativoToDelete);
            this.context.NumeroCorrelativo.Remove(numeroCorrelativoToDelete);
            this.context.SaveChanges();
        }

        public List<NumeroCorrelativoModel> GetNumeroCorrelativo()
        {
            return this.context.NumeroCorrelativo.Select(NumeroCorrelativoMapper.ToModel).ToList();
        }

        public NumeroCorrelativoModel GetNumeroCorrelativo(int idNumeroCorrelativo)
        {
            var numerocorrelativo = this.context.NumeroCorrelativo.Find(idNumeroCorrelativo);
            return NumeroCorrelativoMapper.ToModel(numerocorrelativo);
        }

        public void Update(UpdateNumeroCorrelativoModels updateNumeroCorrelativo)
        {
            NumeroCorrelativo numeroCorrelativoToUpdate = this.context.NumeroCorrelativo.Find(updateNumeroCorrelativo.idNumeroCorrelativo);
            NumeroCorrelativoMapper.UpdateEntityNumeroCorrelativo(updateNumeroCorrelativo, numeroCorrelativoToUpdate);

            this.context.NumeroCorrelativo.Update(numeroCorrelativoToUpdate);
            this.context.SaveChanges();
        }
    }
}
