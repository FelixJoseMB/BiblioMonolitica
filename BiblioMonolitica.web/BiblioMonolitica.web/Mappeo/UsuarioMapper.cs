using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Data.Models.Usuario;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BiblioMonolitica.web.Mappeo
{
    public static class UsuarioMapper
    {
        /* ToEntity(CreateUsuarioModel modelUsuario)
        Convierte un modelo CreateUsuarioModel a una entidad Usuario*/
        public static Usuario ToEntity(CreateUsuarioModel modelUsuario)
        {
            return new Usuario
            {
                idUsuario = modelUsuario.idUsuario,
                NombreApellidos = modelUsuario.NombreApellidos,
                Correo = modelUsuario.Correo,
                Clave = modelUsuario.Clave,
                FechaCreacion = modelUsuario.FechaCreacion

            };
        }


        /* ToModel(Usuario entityUsuario)
       Convierte una entidad Usuario a un modelo CreateUsuarioModel*/
        public static UsuarioModel ToModel(Usuario entityUsuario)
        {
            return new UsuarioModel
            {
                idUsuario = entityUsuario.idUsuario,
                NombreApellidos = entityUsuario.NombreApellidos,
                Correo = entityUsuario.Correo,
                esActivo = entityUsuario.esActivo,
                FechaCreacion = entityUsuario.FechaCreacion

            };
        }

        /*UpdateEntityUsuario(UpdateUsuarioModel modelUsuario,Usuario entityUsuario) 
         Actualiza una entidad EstadoPrestamo existente con los datos 
         proporcionados en un UpdateEstadoPrestamoModel*/
        public static void UpdateEntityUsuario(UpdateUsuarioModel modelUsuario,Usuario entityUsuario) 
        {
            entityUsuario.idUsuario = modelUsuario.idUsuario;
            entityUsuario.NombreApellidos = modelUsuario.NombreApellidos;
            entityUsuario.Correo = modelUsuario.Correo;
            entityUsuario.Clave = modelUsuario.Clave;
            entityUsuario.FechaModificacion = modelUsuario.FechaModificacion;
            entityUsuario.UserMod = modelUsuario.userMod;
        
        }



        /* DeleteEntityUsuario(DeleteUsuarioModel deleteModel, Usuario deleteEntity)
         Elimina una entidad EstadoPrestamo existente con los datos 
         proporcionados en un DeleteEstadoPrestamoModel */
        public static void DeleteEntityUsuario(DeleteUsuarioModel deleteModel, Usuario deleteEntity)
        {
            deleteEntity.FechaEliminacion = deleteModel.FechaEliminacion;
            deleteEntity.userDeleted = deleteModel.userDeleted;


        }
    }
}
