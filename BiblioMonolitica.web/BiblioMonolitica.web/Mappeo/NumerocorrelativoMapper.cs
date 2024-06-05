using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;

namespace BiblioMonolitica.web.Mappeo
{
    public static class NumerocorrelativoMapper
    {
        public static NumeroCorrelativo ToEntity(CreateNumeroCorrelativoModels modelNumeroCorrelativo)
        {
            return new NumeroCorrelativo
            {
               
                idNumeroCorrelativo = modelNumeroCorrelativo.idNumeroCorrelativo,
                Prefijo = modelNumeroCorrelativo.Prefijo,
                Tipo = modelNumeroCorrelativo.Tipo,
                UltimoNumero = modelNumeroCorrelativo?.UltimoNumero,
                FechaCreacion = modelNumeroCorrelativo.FechaCreacion

            };

        }

        public static NumeroCorrelativo ToModel(NumeroCorrelativo entityNumeroCorrelativo)
        {
            return new NumeroCorrelativo
            {
                idNumeroCorrelativo = entityNumeroCorrelativo.idNumeroCorrelativo,
                Prefijo = entityNumeroCorrelativo?.Prefijo,
                Tipo = entityNumeroCorrelativo.Tipo,
                UltimoNumero =  entityNumeroCorrelativo .UltimoNumero,
                FechaCreacion = entityNumeroCorrelativo.FechaCreacion
            };
        }

        public static void UpdateEntityNumeroCorrelativo(UpdateNumeroCorrelativoModels updateModel, NumeroCorrelativo updateEntity)
        {
           updateEntity.idNumeroCorrelativo = updateEntity.idNumeroCorrelativo;
           updateEntity.Prefijo = updateEntity.Prefijo; 
           updateEntity.Tipo = updateEntity.Tipo;
           updateEntity.UltimoNumero = updateEntity.UltimoNumero;
           updateEntity.FechaCreacion= updateEntity.FechaCreacion;
        }

        public static void DeleteEntityEstadoPrestamo(DeleteNumeroCorrelativoModels deleteModel, NumeroCorrelativo deleteEntity)
        {
            deleteEntity.FechaEliminacion = deleteModel.FechaEliminacion;
            deleteEntity.NumeroCorrelativoDeleted = deleteModel.NumeroCorrelativoDeleted;


        }
    }
}
