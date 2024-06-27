namespace BiblioMonolitica.web.Data.Core
{
    public abstract class BaseEntity
    {
        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }


        public string? Descripcion { get; set; }

        public string? Prefijo { get; set; }
        public string? Tipo { get; set; }

        public int? UltimoNumero { get; set; }

        public DateTime FechaRegistro { get; set; }

     


    }
}
