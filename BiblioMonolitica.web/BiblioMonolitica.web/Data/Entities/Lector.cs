using BiblioMonolitica.web.Data.Core;
using BiblioMonolitica.web.Data.Models;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Lector : BaseEntity
    {
        public int IdLector {  get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public LectorModels ToModel()
        {
            return new LectorModels
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
