namespace BiblioMonolitica.web.Models
{
    public class PrestamosUpdateModel
    {
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaConfirmacionDevolucion { get; set; }
        public string? EstadoEntregado { get; set; }
        public string? EstadoRecibido { get; set; }
        public new bool Estado { get; set; }
        public int usermod { get; set; }
    }
}
