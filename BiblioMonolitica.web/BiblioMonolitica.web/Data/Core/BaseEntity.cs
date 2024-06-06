namespace BiblioMonolitica.web.Data.Core
{
    using System;

    namespace BiblioMonolitica.web.Data.Core
    {
        public abstract class BaseEntity
        {
            public bool? Estado { get; set; }
            public DateTime? FechaCreacion { get; set; }

            protected BaseEntity()
            {
                this.FechaCreacion = DateTime.Now;
            }
        }

        public class Libro : BaseEntity
        {
            public int IdLibro { get; set; }
            public string? Titulo { get; set; }
            public string? Autor { get; set; }
            public int? IdCategoria { get; set; }
            public string? Editorial { get; set; }
            public string? Ubicacion { get; set; }
            public byte[]? Portada { get; set; }
            public int? Ejemplares { get; set; }
        }
    }

}