using BiblioMonolitica.web.Data.Entities;

namespace BiblioMonolitica.web.Data.Models
{
    public class LectorModels
    {
        public int IdLector { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Apellido { get; internal set; }
        public string? Clave { get; internal set; }
        public int? Id { get; internal set; }

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
