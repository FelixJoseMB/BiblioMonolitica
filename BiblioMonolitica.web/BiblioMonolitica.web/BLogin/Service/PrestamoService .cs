
using BiblioMonolitica.web.BL.Exeptions;
using BiblioMonolitica.web.BLogin.Core;
using BiblioMonolitica.web.BLogin.Interfaces;
using BiblioMonolitica.web.BLogin.Loggin;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Mappeo;
//service
namespace BiblioMonolitica.web.BLogin.Service
{
    public class PrestamoService 
    {
       

        private readonly IPrestamoDb prestamoService;
        private readonly ILog log;

        public PrestamoService(IPrestamoDb prestamoService, ILog log)
        {
            this.prestamoService = prestamoService;
            this.log = log;
        }

        private ServiceResult ExecuteOperation<T>(T model, Action<T> operation) where T : class
        {
            var result = new ServiceResult();
            return result.ExecuteWithHandling(() =>
            {
                operation(model); 
            }, log);
        }

        public ServiceResult CreatePrestamoModel(CreatePrestamosModel createPrestamoModel)
        {
            PrestamoValidations.Validar(createPrestamoModel);
            return ExecuteOperation(createPrestamoModel, prestamoService.Create);
        }

        public ServiceResult DeletePrestamoModel(DeletePrestamosModel deletePrestamoModel)
        {
            PrestamoValidations.Validar(deletePrestamoModel);
            return ExecuteOperation(deletePrestamoModel, prestamoService.Delete);
        }

        public ServiceResult GetPrestamo()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = prestamoService.GetPrestamos();

            }
            catch (Exception ex)
            {
                result.succes = false;
                result.message = "Error al obtener prestamos";
            }
            return result;
        }

        public ServiceResult GetPrestamo(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                return PrestamoMapper.ToModel(result.Data = this.prestamoService.GetPrestamos(id));
            }
            catch (Exception ex)
            {
                result.succes = false;
                result.message = "Ocurrio un error obteniendo el Prestamo por el ID";
            }
            return result;
        }

        public ServiceResult UpdateModelPrestamo(UpdatePrestamomodel updatePrestamoModel)
        {
            PrestamoValidations.Validar(updatePrestamoModel);
            return ExecuteOperation(updatePrestamoModel, prestamoService.Update);
        }


    }

}