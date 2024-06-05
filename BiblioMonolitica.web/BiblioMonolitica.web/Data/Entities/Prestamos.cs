using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Prestamos: BaseEntity
    {
        public int IdPrestamo { get; set; }
        public int? IdEstadoPrestamo { get; set; }
        public int? IdLector { get; set; }
        public int? IdLibro { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaConfirmacionDevolucion { get; set; }
        public string? EstadoEntregado { get; set; }
        public string? EstadoRecibido { get; set; }
        public new bool Estado { get; set; }
    }
}
