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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>().HasKey(e => e.idCategoria);
            modelBuilder.Entity<NumeroCorrelativo>().HasKey(e => e.idNumeroCorrelativo);

            modelBuilder.Entity<Categoria>()
                .Ignore(u => u.Prefijo)
                .Ignore(u => u.Tipo)
                .Ignore(u => u.UltimoNumero)
                .Ignore(u => u.FechaRegistro);

            modelBuilder.Entity<NumeroCorrelativo>()
                 .Ignore(u => u.Descripcion)
                 .Ignore(u => u.Estado)
                 .Ignore(u => u.FechaCreacion);


        }
    }
}
