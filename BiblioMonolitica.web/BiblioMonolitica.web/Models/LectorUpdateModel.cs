using BiblioMonolitica.web.Data.Entities;

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

        public void UpdateEntity(Lector lector)
        {
            lector.Nombre = this.Nombre;
            lector.Apellido = this.Apellido;
            lector.Clave = this.Clave;
        }
    }
}
