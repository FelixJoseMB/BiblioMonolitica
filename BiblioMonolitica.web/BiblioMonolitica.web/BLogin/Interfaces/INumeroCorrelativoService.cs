using BiblioMonolitica.web.BLogin.core;
using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;

namespace BiblioMonolitica.web.BLogin.Interfaces
{
    public interface INumeroCorrelativoService
    {

        ServiceResult GetNumeroCorrelativo();
        ServiceResult GetNumerocorrelativoByID(int id);
        ServiceResult UpdateNumeroCorrelativoModels(UpdateNumeroCorrelativoModels updateNumeroCorrelativoModels);
        ServiceResult DeleteNumeroCorrelativoModels(DeleteNumeroCorrelativoModels deleteNumeroCorrelativoModels);
        ServiceResult CreateNumeroCorrelativoModels(CreateNumeroCorrelativoModels createNumeroCorrelativoModels);

    }
}
