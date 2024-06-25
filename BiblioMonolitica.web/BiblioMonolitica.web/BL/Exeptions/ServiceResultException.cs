using BiblioMonolitica.web.BL.Core;
using BiblioMonolitica.web.BL.Logger;


namespace BiblioMonolitica.web.BL.Exeptions
{
    public static class ServiceResultExtensions
    {
        public static ServiceResult ExecuteWithHandling(this ServiceResult result, Action action, ILog log)
        {
            try
            {
                action();
                result.Success = true;
            }
            catch (UsuarioServiceException ex)
            {
                log.LogError(ex.Message);
                result.Success = false;
                result.Message = ex.Message;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                result.Success = false;
                result.Message = "Ocurrió un error procesando la solicitud.";
            }
            return result;
        }
    }
}
