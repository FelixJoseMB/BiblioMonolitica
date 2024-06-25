using System.Drawing.Printing;
using BiblioMonolitica.web.BL.Exeptions;
using BiblioMonolitica.web.Data.Models.Usuario;

namespace BiblioMonolitica.web.BL.Validaciones
{
    public static  class UsuarioValidaciones
    {

        public static void Validar(CreateUsuarioModel createUsuarioModel)
        {
            if (createUsuarioModel is null)
                throw new UsuarioServiceException("El usuario no puede ser nulo");


            if (createUsuarioModel.NombreApellidos.Length > 100)
                throw new UsuarioServiceException("El nombre del usuario no puede exceder los 100 caracteres");
        }

        public static void Validar(UpdateUsuarioModel updateUsuarioModel)
        {
            if (string.IsNullOrEmpty(updateUsuarioModel.NombreApellidos))
                throw new UsuarioServiceException("El nombre del usuario no puede ser nulo");


            if (updateUsuarioModel.NombreApellidos.Length > 100)
                throw new UsuarioServiceException("El nombre del usuario no puede exceder los 100 caracteres");
        }

        public static void Validar(DeleteUsuarioModel deleteUsuarioModel)
        {
            if (deleteUsuarioModel is null)
                throw new UsuarioServiceException("El usuario no puede ser nulo");

        }

    }
}
