using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class NumeroCorrelativo : BaseEntity
    {
        internal object NumeroCorrelativoDeleted;

        public object FechaEliminacion { get; internal set; }
    }
}
