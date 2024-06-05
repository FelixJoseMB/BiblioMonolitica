using BiblioMonolitica.web.Data.Core;
using BiblioMonolitica.web.Data.Models.BaseEntityModels;

namespace BiblioMonolitica.web.Data.Models.CategoriaModels
{
    public class DeleteCategoriaModels : BaseEntity
    {
        public object FechaEliminacion { get; internal set; }
        public object CategoriaDeleted { get; internal set; }
    }
}
