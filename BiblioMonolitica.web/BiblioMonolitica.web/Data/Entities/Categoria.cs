﻿using BiblioMonolitica.web.Data.Core;

namespace BiblioMonolitica.web.Data.Entities
{
    public class Categoria : BaseEntity
    {
        public object FechaEliminacion { get; internal set; }
        public object CategoriaDeleted { get; internal set; }
    }
}