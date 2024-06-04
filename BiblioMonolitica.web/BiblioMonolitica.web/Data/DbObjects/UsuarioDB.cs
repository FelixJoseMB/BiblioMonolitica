using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Data.Models.Usuario;

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
            Usuario usuario = new Usuario()
            {
               NombreApellidos = createUsuario.NombreApellidos,
               Correo = createUsuario.Correo,
               Clave = createUsuario.Clave,
               FechaCreacion = createUsuario.FechaCreacion


            };

            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public void Delete(DeleteUsuarioModel deleteUsuario)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioModel> GetUsuario()
        {
            return this.context.Usuario.Select(usuario => new UsuarioModel()
            {

                NombreApellidos = usuario.NombreApellidos,
                esActivo = usuario.esActivo,
                Correo = usuario.Correo,
                idUsuario = usuario.idUsuario,
                FechaCreacion = usuario.FechaCreacion

            }).ToList();
        }

        public UsuarioModel GetUsuario(int idUsuario)
        {
            var usuario = this.context.Usuario.Find(idUsuario);

            UsuarioModel usuarioModel = new UsuarioModel()
            {
                NombreApellidos = usuario.NombreApellidos,
                esActivo = usuario.esActivo,
                Correo = usuario.Correo,
                idUsuario = usuario.idUsuario,
                FechaCreacion = usuario.FechaCreacion
            };
            return usuarioModel;
        }

        

        public void Update(UpdateUsuarioModel updateUsuario)
        {
            Usuario usuarioToUpdate = this.context.Usuario.Find(updateUsuario.idUsuario);

            usuarioToUpdate.NombreApellidos = updateUsuario.NombreApellidos;
            usuarioToUpdate.Correo = updateUsuario.Correo;
            usuarioToUpdate.Clave = updateUsuario.Clave;
            usuarioToUpdate.UserMod = updateUsuario.userMod;
            usuarioToUpdate.FechaModificacion = updateUsuario.FechaModificacion;

            this.context.Usuario.Update(usuarioToUpdate);
            this.context.SaveChanges();
        }
    }
}
