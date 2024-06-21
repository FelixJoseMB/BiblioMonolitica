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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(e => e.idUsuario);
            modelBuilder.Entity<EstadoPrestamo>().HasKey(e => e.idEstadoPrestamo);

            modelBuilder.Entity<Usuario>()
                .Ignore(u => u.Codigo)
                .Ignore(u => u.Descripcion)
                .Ignore(u => u.Estado);

            modelBuilder.Entity<EstadoPrestamo>()
                .Ignore(u => u.Clave)
                .Ignore(u => u.Correo)
                .Ignore(u => u.Codigo);


        }
    }
}
