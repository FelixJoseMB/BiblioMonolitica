using BiblioMonolitica.web.BLogin.Service;
using BiblioMonolitica.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiblioMonolitica.web.Data.Content
{
    public class BibliotecaContext :DbContext
    {
        #region"constuctor"
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) :base(options)
        {

        }
        #endregion

        #region"Db sets"
        public DbSet<Entities.NumeroCorrelativo> NumeroCorrelativo {  get; set; }
        public DbSet<Categoria> categoria { get; set; }
        #endregion
    }
}
