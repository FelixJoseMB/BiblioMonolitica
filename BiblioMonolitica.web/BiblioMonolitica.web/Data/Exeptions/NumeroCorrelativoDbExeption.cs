using System;

namespace BiblioMonolitica.web.Data.Exeptions
{
    public class NumeroCorrelativoDbExeption : Exception
    {
        public NumeroCorrelativoDbExeption(string message) : base(message)
        {
        }
    }
}
