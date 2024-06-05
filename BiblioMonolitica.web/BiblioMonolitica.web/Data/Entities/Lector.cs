using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Lector : BaseEntity
    {
        public int IdLector {  get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
    }
}
