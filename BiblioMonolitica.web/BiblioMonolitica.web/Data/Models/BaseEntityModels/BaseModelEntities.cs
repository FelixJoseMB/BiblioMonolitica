namespace BiblioMonolitica.web.Data.Models.BaseEntityModels
{
    public abstract class BaseModelEntities
    {
        public int idEstadoPrestamo { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? CreationUser { get; set; }
        public int idUsuario { get; set; }
        public string NombreApellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string? userMod { get; set; }
        public string? userDeleted { get; set; }

    }
}
