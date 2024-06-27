using BiblioMonolitica.web.BLogin.Service;
namespace BiblioMonolitica.web.BLogin.Logger
{
    public interface ILog
    {
      public void LogError(string message);
      public void LogInformation(string message);
    }
}
