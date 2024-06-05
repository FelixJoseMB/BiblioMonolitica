namespace BiblioMonolitica.web.Models
{
    public class PrestamosSaveModel
    {
        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaConfirmacionDevolucion { get; set; }
        public string? EstadoEntregado { get; set; }
        public string? EstadoRecibido { get; set; }
        public new bool Estado { get; set; }
        public int creationUser { get; set; }
    }
}
