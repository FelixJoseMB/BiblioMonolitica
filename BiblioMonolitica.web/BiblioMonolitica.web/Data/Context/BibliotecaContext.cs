using BiblioMonolitica.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiblioMonolitica.web.Data.Content
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options): base(options) { }

        #region"DbSet"
        public DbSet<Usuario> Usuario {  get; set; }
        public DbSet<EstadoPrestamo> EstadoPrestamo { get; set; }

        #endregion
    }
}
