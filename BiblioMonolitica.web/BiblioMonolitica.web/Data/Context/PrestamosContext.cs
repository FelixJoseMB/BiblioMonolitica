using Microsoft.EntityFrameworkCore;
using BiblioMonolitica.web.Data.Entities;

namespace BiblioMonolitica.web.Data.Context
{
    public class PrestamosContext : DbContext
    {
        #region "Constructor"
        public PrestamosContext(DbContextOptions<PrestamosContext> options) : base(options)
        {
        }
        #endregion

        #region "Db Sets"
        public DbSet<Prestamos> Prestamo { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion
    }
}
