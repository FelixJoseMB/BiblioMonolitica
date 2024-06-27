using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Categoria : BaseEntity
    {
        public int? idCategoria { get; set; }

        public string? Descripcion {  get; set; }

        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }



    }
}
