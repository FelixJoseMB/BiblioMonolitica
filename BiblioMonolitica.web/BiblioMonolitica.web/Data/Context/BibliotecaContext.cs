using BiblioMonolitica.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiblioMonolitica.web.Data.Content
{
    public class BibliotecaContext : DbContext
    {

        #region"Constructor"
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }
        #endregion

        #region"DB Sets"
        public DbSet<Lector> Lectors { get; set; }
        #endregion

    }
}
