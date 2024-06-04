namespace BiblioMonolitica.web.Data.Models
{
    public class UsuarioModel
    {
        /*Atributos que el usuario puede ver*/
        public int idUsuario { get; set; }
        public string? NombreApellidos { get; set; }
        public string? Correo { get; set; }
        public bool? esActivo { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
