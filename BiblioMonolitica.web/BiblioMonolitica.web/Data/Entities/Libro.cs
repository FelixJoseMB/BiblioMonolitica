﻿using BiblioMonolitica.web.Data.Core;
using BiblioMonolitica.web.Data.Core.BiblioMonolitica.web.Data.Core;
using BiblioMonolitica.web.Data.Models;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Libro : BaseEntity
    {
        public int IdLibro { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public int? IdCategoria { get; set; }
        public string? Editorial { get; set; }
        public string? Ubicacion { get; set; }
        public byte[]? Portada { get; set; }
        public int? Ejemplares { get; set; }

        public LibroModels ToModel()
        {
            return new LibroModels
            {
                IdLibro = this.IdLibro,
                Titulo = this.Titulo,
                Autor = this.Autor,
                IdCategoria = this.IdCategoria,
                Editorial = this.Editorial,
                Ubicacion = this.Ubicacion,
                Estado = this.Estado,
                FechaCreacion = this.FechaCreacion,
                Portada = this.Portada,
                Ejemplares = this.Ejemplares
            };
        }
    }
}
