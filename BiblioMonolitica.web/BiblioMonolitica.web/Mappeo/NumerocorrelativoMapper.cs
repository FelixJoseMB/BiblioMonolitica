using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;



namespace BiblioMonolitica.web.Mappeo
{
    public class NumeroCorrelativoMapper
    {
        public static NumeroCorrelativo ToEntity(CreateNumeroCorrelativoModels modelNumeroCorrelativo)
        {
            return new NumeroCorrelativo
            {
                idNumeroCorrelativo = modelNumeroCorrelativo.idNumeroCorrelativo,
                Prefijo = modelNumeroCorrelativo.Prefijo,
                Tipo = modelNumeroCorrelativo.Tipo,
                UltimoNumero = modelNumeroCorrelativo.UltimoNumero,
                FechaRegistro = modelNumeroCorrelativo.FechaRegistro

            };
        }

        public static NumeroCorrelativoModel ToModel(NumeroCorrelativo entityNumeroCorrelativo)
        {
            return new NumeroCorrelativoModel
            {
                idNumeroCorrelativo = entityNumeroCorrelativo.idNumeroCorrelativo,
                Prefijo = entityNumeroCorrelativo.Prefijo,
                UltimoNumero = entityNumeroCorrelativo.UltimoNumero,
                FechaRegistro = entityNumeroCorrelativo.FechaRegistro

            };
        }

        public static void UpdateEntityNumeroCorrelativo(UpdateNumeroCorrelativoModels updateModel, NumeroCorrelativo updateEntity )
        {
            updateEntity.Prefijo = updateModel.Prefijo;
            updateEntity.Tipo = updateModel.Tipo;
            updateEntity.UltimoNumero = updateModel.UltimoNumero;
        }

        public static void DeleteEntityNumeroCorrelativo(DeleteNumeroCorrelativoModels deleteModel, NumeroCorrelativo deleteEntity )
        {
            deleteEntity.idNumeroCorrelativo = deleteModel.idNumeroCorrelativo;
            deleteEntity.Prefijo = deleteModel.Prefijo;
            deleteEntity.UltimoNumero = deleteModel.UltimoNumero;
        }
    }
}
