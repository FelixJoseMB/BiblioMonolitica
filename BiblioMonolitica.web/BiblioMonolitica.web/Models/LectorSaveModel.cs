namespace BiblioMonolitica.web.Models
{
    public class LectorSaveModel
    {
        public int IdLector { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Clave { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
