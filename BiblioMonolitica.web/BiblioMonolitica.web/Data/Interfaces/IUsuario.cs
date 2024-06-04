using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.Usuario;

namespace BiblioMonolitica.web.Data.Interfaces
{
    public interface IUsuario
    {
        void Create (CreateUsuarioModel createUsuario);
        void Update (UpdateUsuarioModel updateUsuario);
        void Delete (DeleteUsuarioModel deleteUsuario);
      
        List<UsuarioModel> GetUsuario();
        UsuarioModel GetUsuario (int idUsuario);

    }
}
