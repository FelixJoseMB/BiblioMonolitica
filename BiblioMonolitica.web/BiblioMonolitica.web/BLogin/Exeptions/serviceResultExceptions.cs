using BiblioMonolitica.web.BLogin.core;
using BiblioMonolitica.web.BLogin.Logger;

namespace BiblioMonolitica.web.BLogin.Exeptions
{
    public static class serviceResultExceptions
    {
        public static ServiceResult ExecuteWithHandling(this ServiceResult result, Action action, ILog log)
        {
            try
            {
                action();
                result.Success = true;
            }
            catch (CategoriaExeption ex)
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
