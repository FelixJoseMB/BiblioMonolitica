namespace BiblioMonolitica.web.Models
{
    public class LibroUpdateModel
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
