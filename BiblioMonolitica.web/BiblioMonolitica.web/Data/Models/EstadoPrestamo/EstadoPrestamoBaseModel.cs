using Microsoft.VisualBasic;

namespace BiblioMonolitica.web.Data.Models.EstadoPrestamo
{
    public abstract class EstadoPrestamoBaseModel: ModelBaseEstadoPrestamo
    {
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

    }
}
