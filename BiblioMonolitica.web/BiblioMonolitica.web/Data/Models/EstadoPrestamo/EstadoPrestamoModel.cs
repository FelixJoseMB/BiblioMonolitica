using System.Security.Principal;

namespace BiblioMonolitica.web.Data.Models.EstadoPrestamo
{
    public  class EstadoPrestamoModel
    {
        /*Atributos que el usuario puede ver*/

        public int idEstadoPrestamo { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
