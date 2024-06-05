using BiblioMonolitica.web.Data.Entities;

namespace BiblioMonolitica.web.Models
{
    public class LectorSaveModel
    {
        public int IdLector { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Clave { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public Lector ToEntity()
        {
            return new Lector
            {
                IdLector = this.IdLector,
                Nombre = this.Nombre,
                Apellido = this.Apellido,
                Clave = this.Clave,
                FechaCreacion = this.FechaCreacion
            };
        }
    }
}
