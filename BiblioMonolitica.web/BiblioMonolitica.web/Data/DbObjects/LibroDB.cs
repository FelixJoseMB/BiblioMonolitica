﻿using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class LibroDB : ILibro
    {
        private readonly BibliotecaContext context;

        public LibroDB(BibliotecaContext context)
        {
            this.context = context;
        }

        public LibroModels GetLibro(int IdLibro)
        {
            var libro = this.context.Libros.Find(IdLibro);
            return libro?.ToModel();
        }

        public List<LibroModels> GetLibros()
        {
            return this.context.Libros.Select(libro => libro.ToModel()).ToList();
        }

        public void RemoveLibro(LibroRemoveModel libroRemove)
        {
            var libroToDelete = this.context.Libros.Find(libroRemove.IdLibro);

            if (libroToDelete != null)
            {
                this.context.Libros.Remove(libroToDelete);
                this.context.SaveChanges();
            }
        }

        public void SaveLibro(LibroSaveModel libroSave)
        {
            var libro = libroSave.ToEntity();
            this.context.Libros.Add(libro);
            this.context.SaveChanges();
        }

        public void UpdateLibro(LibroUpdateModel updateModel)
        {
            var libroToUpdate = this.context.Libros.Find(updateModel.IdLibro);

            if (libroToUpdate != null)
            {
                updateModel.UpdateEntity(libroToUpdate);
                this.context.Libros.Update(libroToUpdate);
                this.context.SaveChanges();
            }
        }
    }
}
