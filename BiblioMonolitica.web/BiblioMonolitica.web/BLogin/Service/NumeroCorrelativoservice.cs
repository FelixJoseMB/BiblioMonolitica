using BiblioMonolitica.web.BLogin.core;

using BiblioMonolitica.web.BLogin.Exeptions;
using BiblioMonolitica.web.BLogin.Interfaces;
using BiblioMonolitica.web.BLogin.Logger;
using BiblioMonolitica.web.BLogin.Validaciones;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.CategoriaModels;
using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;
using BiblioMonolitica.web.Mappeo;

namespace BiblioMonolitica.web.BLogin.Service
{
    public class NumeroCorrelativoservice : INumeroCorrelativoService
    {
        private readonly INumeroCorrelativo numeroCorrelativoDb;
        private readonly ILog log;

        public NumeroCorrelativoservice(INumeroCorrelativo numeroCorrelativoDb, ILog log)
        {
            this.numeroCorrelativoDb = numeroCorrelativoDb;
            this.log = log;
        }

        private ServiceResult ExecuteOperation<T>(T model, Action<T> operation) where T : class
        {
            var result = new ServiceResult();
            return result.ExecuteWithHandling(() =>
            {
                operation(model); // Ejecutar la operación específica (Create, Update, Delete)
            }, log);
        }

        public ServiceResult CreateNumeroCorrelativoModels(CreateNumeroCorrelativoModels createNumeroCorrelativoModels)
        {
            NumeroCorrelativoValidaciones.Validar(createNumeroCorrelativoModels);
            return ExecuteOperation(createNumeroCorrelativoModels, numeroCorrelativoDb.Create);
        }

        public ServiceResult DeleteNumeroCorrelativoModels(DeleteNumeroCorrelativoModels deleteNumeroCorrelativoModels)
        {
            NumeroCorrelativoValidaciones.Validar(deleteNumeroCorrelativoModels);
            return ExecuteOperation(deleteNumeroCorrelativoModels, numeroCorrelativoDb.Delete);
        }

        public ServiceResult GetNumeroCorrelativo()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = numeroCorrelativoDb.GetNumeroCorrelativo();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error al obtener los números correlativos.";
            }
            return result;
        }

        

        public ServiceResult UpdateNumeroCorrelativoModels(UpdateNumeroCorrelativoModels updateNumeroCorrelativoModels)
        {
            NumeroCorrelativoValidaciones.Validar(updateNumeroCorrelativoModels);
            return ExecuteOperation(updateNumeroCorrelativoModels, numeroCorrelativoDb.Update);
        }

        ServiceResult INumeroCorrelativoService.GetNumerocorrelativoByID(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                return NumeroCorrelativoMapper.ToModel(result.Data = this.numeroCorrelativoDb.GetNumeroCorrelativo(id));
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrió un error al obtener el número correlativo por ID.";
            }
            return result;
        }
    }
}
