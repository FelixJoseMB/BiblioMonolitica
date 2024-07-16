
using BiblioMonolitica.web.BLogin.Core;
using BiblioMonolitica.web.BLogin.Loggin;


namespace BiblioMonolitica.web.BL.Exeptions
{
    public static class ServiceResultExceptions
    {
        public static ServiceResult ExecuteWithHandling(this ServiceResult result, Action action, ILog log)
        {
            try
            {
                action();
                result.succes = true;
            }
            catch (PrestamosServiceExeption ex)
            {
                log.LogError(ex.Message);
                result.succes = false;
                result.message = ex.Message;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                result.succes = false;
                result.message = "error procesando la solicitud";
            }
            return result;
        }
    }
}