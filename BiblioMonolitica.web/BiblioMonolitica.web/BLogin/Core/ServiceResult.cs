using BiblioMonolitica.web.BLogin.Loggin;

namespace BiblioMonolitica.web.BLogin.Core
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            this.succes = true;
        }
        public bool succes { get; set; }
        public string message { get; set; }
        public dynamic Data { get; set; }


    }
}
