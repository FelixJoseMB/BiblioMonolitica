using BiblioMonolitica.web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BiblioMonolitica.web.Data.Content
{
    public class BibliotecaContext : DbContext
    {
        #region Constructor
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }
        #endregion

        #region DB Sets
        public DbSet<Libro> Libros { get; set; }
        #endregion
    }
}

