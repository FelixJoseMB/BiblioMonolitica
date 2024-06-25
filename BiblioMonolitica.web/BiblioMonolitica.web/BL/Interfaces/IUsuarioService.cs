using BiblioMonolitica.web.BL.Core;
using BiblioMonolitica.web.Data.Models.Usuario;

namespace BiblioMonolitica.web.BL.Interfaces
{
    public interface IUsuarioService
    {
        ServiceResult GetUsuario();
        ServiceResult GetUsuarioByID(int id);
        ServiceResult UpdateModelUsuario (UpdateUsuarioModel updateUsuarioModel);
        ServiceResult DeleteUsuarioModel (DeleteUsuarioModel deleteUsuarioModel);
        ServiceResult CreateUsuarioModel(CreateUsuarioModel createUsuarioModel);

    }
}
