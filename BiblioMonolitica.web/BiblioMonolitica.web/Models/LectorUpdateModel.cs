namespace BiblioMonolitica.web.Models
{
    public class LectorUpdateModel
    {
        public int IdLector { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Clave { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
