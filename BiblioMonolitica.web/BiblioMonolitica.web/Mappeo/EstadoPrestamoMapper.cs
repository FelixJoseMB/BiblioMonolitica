using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Exeptions;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;

namespace BiblioMonolitica.web.Mappeo
{
    public static class EstadoPrestamoMapper
    {
        /*ToEntity(CreateEstadoPrestamoModel modelEstadoPrestamo)
        Convierte un modelo CreateEstadoPrestamoModel a una entidad EstadoPrestamo*/
        public static EstadoPrestamo ToEntity(CreateEstadoPrestamoModel modelEstadoPrestamo)
        {
            return new EstadoPrestamo
            {
               Descripcion = modelEstadoPrestamo.Descripcion,
               Estado = modelEstadoPrestamo.Estado,
               FechaCreacion = modelEstadoPrestamo.FechaCreacion,
                   
            };
        }

        /*ToModel(EstadoPrestamo entityEstadoPrestamo)
         Convierte una entidad EstadoPrestamo a un modelo EstadoPrestamoModel*/
        public static EstadoPrestamoModel ToModel(EstadoPrestamo entityEstadoPrestamo)
        {
            return new EstadoPrestamoModel
            {
               idEstadoPrestamo = entityEstadoPrestamo.idEstadoPrestamo,
               Descripcion = entityEstadoPrestamo.Descripcion,
               Estado = entityEstadoPrestamo.Estado,
               FechaCreacion = entityEstadoPrestamo.FechaCreacion
            };
        }

        /*UpdateEntityEstadoPrestamo(UpdateEstadoPrestamoModel updateModel, EstadoPrestamo updateEntity)
         Actualiza una entidad EstadoPrestamo existente con los datos 
         proporcionados en un UpdateEstadoPrestamoModel*/
        public static void UpdateEntityEstadoPrestamo(UpdateEstadoPrestamoModel updateModel, EstadoPrestamo updateEntity)
            {
            updateEntity.Descripcion = updateModel.Descripcion;
            updateEntity.Estado = updateModel.Estado;
            updateEntity.UserMod = updateModel.userMod;
            updateEntity.FechaModificacion = updateModel.FechaModificacion;
            }

        /*DeleteEntityEstadoPrestamo(DeleteEstadoPrestamoModel deleteModel, EstadoPrestamo deleteEntity)
         Elimina una entidad EstadoPrestamo existente con los datos 
         proporcionados en un DeleteEstadoPrestamoModel */
        public static void DeleteEntityEstadoPrestamo(DeleteEstadoPrestamoModel deleteModel, EstadoPrestamo deleteEntity)
        {
            deleteEntity.FechaEliminacion = deleteModel.FechaEliminacion;
            deleteEntity.userDeleted = deleteModel.userDeleted;


        }
    }

    
}
