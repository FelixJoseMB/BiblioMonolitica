using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Usuario : BaseEntity
    {
        public int idUsuario { get; set; }
        public string? NombreApellidos { get; set; }
        public bool? esActivo { get; set; }
        
       
    }
}
