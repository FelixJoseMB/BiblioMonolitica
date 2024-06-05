using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
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
            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public void Delete(DeleteUsuarioModel deleteUsuario)
        {
            Usuario usuarioToDelete = this.context.Usuario.Find(deleteUsuario.idUsuario);


            // Utilizar el método DeleteEntityEstadoPrestamo para eliminar la entidad con los datos de eliminación
            UsuarioMapper.DeleteEntityUsuario(deleteUsuario, usuarioToDelete);

            // Actualizar la entidad en el contexto y guardar los cambios en la base de datos
            this.context.Usuario.Remove(usuarioToDelete);
            this.context.SaveChanges();
        }

        public List<UsuarioModel> GetUsuario()
        {
            return this.context.Usuario.Select(UsuarioMapper.ToModel).ToList();
        }

        public UsuarioModel GetUsuario(int idUsuario)
        {
            var estadoPrestamo = this.context.Usuario.Find(idUsuario);

            return UsuarioMapper.ToModel(estadoPrestamo);
        }

        

        public void Update(UpdateUsuarioModel updateUsuario)
        {
            Usuario usuarioToUpdate = this.context.Usuario.Find(updateUsuario.idEstadoPrestamo);
            UsuarioMapper.UpdateEntityUsuario(updateUsuario, usuarioToUpdate);

            this.context.Usuario.Update(usuarioToUpdate);
            this.context.SaveChanges();
        }
    }
}
