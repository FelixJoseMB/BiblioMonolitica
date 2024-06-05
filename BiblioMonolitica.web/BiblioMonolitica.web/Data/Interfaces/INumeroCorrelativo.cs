using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;
using BiblioMonolitica.web.Models;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface INumeroCorrelativo
    {
        void Create(CreateNumeroCorrelativoModels createNumeroCorrelativo);
        void Update(UpdateNumeroCorrelativoModels updateNumeroCorrelativo);
        void Delete(DeleteNumeroCorrelativoModels deleteNumeroCorrelativo);

        List<NumeroCorrelativoModel> GetNumeroCorrelativo();
        NumeroCorrelativoModel GetNumeroCorrelativo(int idNumeroCorrelativo);
    }
}
