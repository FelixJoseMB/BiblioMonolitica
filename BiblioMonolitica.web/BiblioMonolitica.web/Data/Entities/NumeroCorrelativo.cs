using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class NumeroCorrelativo : BaseEntity
    {
        public int? idNumeroCorrelativo { get; set; }

        public string? Prefijo { get; set; }

        public string? Tipo { get; set; }

        public int? UltimoNumero { get; set; }

        public DateTime? FechaRegistro { get; set; }

    }
}
