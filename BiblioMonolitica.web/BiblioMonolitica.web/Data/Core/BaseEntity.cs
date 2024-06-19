namespace BiblioMonolitica.web.Data.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.FechaCreacion = DateTime.Now;
        }
        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public  string Descripcion { get; set; }

        public int Codigo { get; set; }

        public  string Clave { get; set; }

        public  string Correo { get; set; }


    }
}
