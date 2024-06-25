using BiblioMonolitica.web.BL.Core;
using BiblioMonolitica.web.BL.Exeptions;
using BiblioMonolitica.web.BL.Interfaces;
using BiblioMonolitica.web.BL.Logger;
using BiblioMonolitica.web.BL.Validaciones;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Data.Models.Usuario;
using BiblioMonolitica.web.Mappeo;

namespace BiblioMonolitica.web.BL.Service
{

    public class EstadoPrestamoService : IEstadoPrestamoService
    {

        private readonly IEstadoPrestamo estadoPrestamoService;
        private readonly ILog log;

        public EstadoPrestamoService(IEstadoPrestamo estadoPrestamoService, ILog log)
        {
            this.estadoPrestamoService = estadoPrestamoService;
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

        public ServiceResult CreateEstadoPrestamoModel(CreateEstadoPrestamoModel createEstadoPrestamoModel)
        {
            EstadoPrestamoValidaciones.Validar(createEstadoPrestamoModel);
            return ExecuteOperation(createEstadoPrestamoModel, estadoPrestamoService.Create);
        }

        public ServiceResult DeleteEstadoPrestamoModel(DeleteEstadoPrestamoModel deleteEstadoPrestamoModel)
        {
            EstadoPrestamoValidaciones.Validar(deleteEstadoPrestamoModel);
            return ExecuteOperation(deleteEstadoPrestamoModel, estadoPrestamoService.Delete);
        }

        public ServiceResult GetEstadoPrestamo()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = estadoPrestamoService.GetEstadoPrestamo();

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error al obtener los Estados Prestamos";
            }
            return result;
        }

        public ServiceResult GetEstadoPrestamoByID(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                return EstadoPrestamoMapper.ToModel(result.Data = this.estadoPrestamoService.GetEstadoPrestamo(id));
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo el Estado Prestamo por el ID";
            }
            return result;
        }

        public ServiceResult UpdateModelEstadoPrestamo(UpdateEstadoPrestamoModel updateEstadoPrestamoModel)
        {
            EstadoPrestamoValidaciones.Validar(updateEstadoPrestamoModel);
            return ExecuteOperation(updateEstadoPrestamoModel, estadoPrestamoService.Update);
        }
    }

}
   
