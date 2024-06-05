using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Models;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface ILector
    {
         void SaveLector(LectorSaveModel lector);
        void UpdateLector(LectorUpdateModel updateModel);
        void RemoveLector(LectorRemoveModel removeModel);
        List<LectorModels> GetLectors();
        LectorModels GetLector(int IdLector);
    }

}
