namespace BiblioMonolitica.web.Data.Core
{
    public abstract class BaseEntity
    {
        public bool? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public required string? Descripcion { get; set; }

        public int? Codigo { get; set; }

        public required string? Clave { get; set; }

        public required string? Correo { get; set; }

        protected BaseEntity() 
        {
            this.FechaCreacion = DateTime.Now;
        }
    }
}
