using BiblioMonolitica.web.Data.Core;
using BiblioMonolitica.web.Data.Models.BaseEntityModels;

namespace BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels
{
    public class DeleteNumeroCorrelativoModels : BaseEntity
    {
        public object FechaEliminacion { get; internal set; }
        public object NumeroCorrelativoDeleted { get; internal set; }
    }
}
