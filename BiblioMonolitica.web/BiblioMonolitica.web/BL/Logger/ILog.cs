using BiblioMonolitica.web.BL.Service;

namespace BiblioMonolitica.web.BL.Logger
{
    public interface ILog
    {
        public void LogError(string message);
        public void LogInformation(string message);
    }
}
