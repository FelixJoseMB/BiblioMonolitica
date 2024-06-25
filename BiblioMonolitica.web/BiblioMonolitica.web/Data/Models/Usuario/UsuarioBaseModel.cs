using BiblioMonolitica.web.Data.Models.Usuario.Model;
using BiblioMonolitica.web.BL.Validaciones;
using BiblioMonolitica.web.BL.Exeptions;

namespace BiblioMonolitica.web.Data.Models.Usuario
{
    public abstract class UsuarioBaseModel : ModelBaseUsuario
    {
        public string NombreApellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool? esActivo { get; set; }

       
    }
}
