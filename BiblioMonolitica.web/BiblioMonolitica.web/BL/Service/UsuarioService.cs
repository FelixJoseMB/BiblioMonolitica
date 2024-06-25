using BiblioMonolitica.web.BL.Core;
using BiblioMonolitica.web.BL.Logger;
using BiblioMonolitica.web.BL.Exeptions;
using BiblioMonolitica.web.BL.Interfaces;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.Usuario;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Mappeo;
using BiblioMonolitica.web.BL.Validaciones;


namespace BiblioMonolitica.web.BL.Service
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuario UsuarioDB;
        private readonly ILog log;


        public UsuarioService(IUsuario UsuarioDB, ILog log)
        {
            this.UsuarioDB = UsuarioDB;
            this.log = log;
        }
        private ServiceResult ExecuteOperation<T>(T model, Action<T> operation) where T : class
        {
            var result = new ServiceResult();
            return result.ExecuteWithHandling(() =>
            {
                operation(model); // Ejecutar la operación específica (Create, Update, Delete)
            }, log);
        }

        public ServiceResult CreateUsuarioModel(CreateUsuarioModel createUsuarioModel)
        {
            
            UsuarioValidaciones.Validar(createUsuarioModel);
            return ExecuteOperation(createUsuarioModel, UsuarioDB.Create);
        }

        public ServiceResult DeleteUsuarioModel(DeleteUsuarioModel deleteUsuarioModel)
        {
            UsuarioValidaciones.Validar(deleteUsuarioModel);
            return ExecuteOperation(deleteUsuarioModel, UsuarioDB.Delete);
        }

        public ServiceResult GetUsuario()
        {
            ServiceResult result = new ServiceResult();

            try 
            {
                result.Data = UsuarioDB.GetUsuario();

            }
            catch(Exception ex) 
            { 
               result.Success = false;
               result.Message = "Ocurrio un error al obtener los usuarios";
            }
           return result;
        }

        public ServiceResult GetUsuarioByID(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                return UsuarioMapper.ToModel(result.Data = this.UsuarioDB.GetUsuario(id));
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo el usuario por el ID";
            }
            return result;
        }

        public ServiceResult UpdateModelUsuario(UpdateUsuarioModel updateUsuarioModel)
        {
            UsuarioValidaciones.Validar(updateUsuarioModel); 
            return ExecuteOperation(updateUsuarioModel, UsuarioDB.Update);
        }

       
    }
}
