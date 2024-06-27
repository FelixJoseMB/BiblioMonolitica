using BiblioMonolitica.web.BLogin.core;
using BiblioMonolitica.web.BLogin.Interfaces;
using BiblioMonolitica.web.BLogin.Logger;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.CategoriaModels;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.BLogin.Validaciones;
using BiblioMonolitica.web.Mappeo;
using BiblioMonolitica.web.BLogin.Exeptions;

namespace BiblioMonolitica.web.BLogin.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoria CategoriaDb;
        private readonly ILog log;


        public CategoriaService(ICategoria CategoriaDb, ILog log)
        {
            this.CategoriaDb = CategoriaDb;
            this.log = log;
        }
        private ServiceResult ExecuteOperation<T>(T model, Action<T> operation) where T : class
        {
            var result = new ServiceResult();
            return result.ExecuteWithHandling(()=>
            {
                operation(model); // Ejecutar la operación específica (Create, Update, Delete)
            }, log);
        }

        public ServiceResult CreateCategoriaModels(CreateCategoriaModels  createCategoriaModels)
        {

            CategoriaValidaciones.Validar(createCategoriaModels);
            return ExecuteOperation(createCategoriaModels, CategoriaDb.Create);
        }

        public ServiceResult DeleteCategoriaModel(DeleteCategoriaModels deleteCategoriaModels)
        {
            CategoriaValidaciones.Validar(deleteCategoriaModels);
            return ExecuteOperation(deleteCategoriaModels, CategoriaDb.Delete);
        }

        public ServiceResult GetCategoria()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = CategoriaDb.GetCategoria();

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error al obtener las categorias";
            }
            return result;
        }

        public ServiceResult GetCategoriaByID(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                return CategoriaMapper.ToModel(result.Data = this.CategoriaDb.GetCategoria(id));
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo la categoria por el ID";
            }
            return result;
        }

        public ServiceResult UpdateCategoriaModel(UpdateCategoriaModels updateCategoriaModels)
        {
            CategoriaValidaciones.Validar(updateCategoriaModels);
            return ExecuteOperation( updateCategoriaModels, CategoriaDb.Update);
        }

       
    }
}
