
namespace BiblioMonolitica.web.BLogin.Logger
{
    public class Log : ILog
    {
        private readonly ILogger<Log> logger;

        public Log(ILogger<Log> logger)
        {
            this.logger = logger;
        }

        public void LogError(string message)
        {
            logger.LogError(message);
        }


        public void LogInformation(string message)
        {
            logger.LogInformation(message);
        }
    }
}
