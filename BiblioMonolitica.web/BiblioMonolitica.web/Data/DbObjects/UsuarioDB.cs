using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.Usuario;
using BiblioMonolitica.web.Mappeo;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class UsuarioDB : IUsuario
    {
        private readonly BibliotecaContext context;

        public UsuarioDB(BibliotecaContext context)
        {
            this.context = context;
        }

        public void Create(CreateUsuarioModel createUsuario)
        {

            var usuario = UsuarioMapper.ToEntity(createUsuario);
            usuario.esActivo = true;
            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public void Delete(DeleteUsuarioModel deleteUsuario)
        {

            Usuario usuarioToDelete = this.context.Usuario.Find(deleteUsuario.idUsuario);

            if (usuarioToDelete == null)
            {
                throw new ArgumentException("Usuario no encontrado");
            }

            // Utilizar el método DeleteEntityUsuario para eliminar la entidad con los datos de eliminación
            UsuarioMapper.DeleteEntityUsuario(deleteUsuario, usuarioToDelete);

            // Actualizar la entidad en el contexto y guardar los cambios en la base de datos
            usuarioToDelete.esActivo = false;
            this.context.Usuario.Remove(usuarioToDelete);
            this.context.SaveChanges();
        }

        public List<UsuarioModel> GetUsuario()
        {
            return this.context.Usuario.Select(UsuarioMapper.ToModel).ToList();
        }

        public UsuarioModel GetUsuario(int idUsuario)
        {
            var usuario = this.context.Usuario.Find(idUsuario);

            return UsuarioMapper.ToModel(usuario);
        }

        public void Update(UpdateUsuarioModel updateUsuario)
        {
            Usuario usuarioToUpdate = this.context.Usuario.Find(updateUsuario.idUsuario);
            UsuarioMapper.UpdateEntityUsuario(updateUsuario, usuarioToUpdate);

            this.context.Usuario.Update(usuarioToUpdate);
            this.context.SaveChanges();
        }
    }
}
