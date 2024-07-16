using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;

namespace BiblioMonolitica.web.Mappeo
{
    public static class PrestamoMapper
    {

        public static Prestamos ToEntity(CreatePrestamosModel ModelPrestamo)
        {
            return new Prestamos
            {
                Descripcion = ModelPrestamo.Descripcion,
                Estado = (bool)ModelPrestamo.Estado,
                FechaCreacion = ModelPrestamo.FechaCreacion,

            };
        }


        public static PrestamosModel ToModel(Prestamos entityPrestamo)
        {
            return new PrestamosModel
            {
                IdPrestamo = entityPrestamo.idprestamo,
                FechaDevolucion = entityPrestamo.FechaCreacion,
                Estado = (bool)entityPrestamo.Estado,
                Descripcion = entityPrestamo.Descripcion
            };
        }


        public static void UpdateentityPrestamo(UpdatePrestamomodel updateModel, Prestamos updateEntity)
        {
            updateEntity.Descripcion = updateModel.Descripcion;
            updateEntity.Estado = updateModel.Estado;

        }


        public static void DeleteEntityPrestamo(DeletePrestamosModel deleteModel, Prestamos deleteEntity)
        {
            deleteEntity.idPrestamo = deleteModel.idPrestamo;
            deleteEntity.Descripcion = deleteModel.Descripcion;
            deleteEntity.Estado = deleteModel.Estado;

        }


    }


}

