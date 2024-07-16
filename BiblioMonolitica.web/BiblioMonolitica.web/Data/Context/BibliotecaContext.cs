

using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiblioMonolitica.web.Data.Content
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        #region"DbSet"
        public DbSet<Prestamos> Prestamos { get; set; }


        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Prestamos>().HasKey(e => e.idprestamo);


            modelBuilder.Entity<Prestamos>()
                .Ignore(u => u.Codigo)
                .Ignore(u => u.Descripcion)
                .Ignore(u => u.Estado);




        }
    }
}