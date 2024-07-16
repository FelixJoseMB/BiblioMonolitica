using System.Linq.Expressions;
using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Exeptions;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Mappeo;
namespace BiblioMonolitica.web.Data.DbObjects
{

    public class PrestamoDB : IPrestamoDb
    {

        private readonly BibliotecaContext context;

        public PrestamoDB(BibliotecaContext context)
        {
            this.context = context;
        }

        internal static dynamic Getdepartments()
        {
            throw new NotImplementedException();
        }

        public void Create(CreatePrestamosModel createPrestamos)
        {

            var Prestamo = PrestamoMapper.ToEntity(createPrestamos);
            Prestamo.Estado = true;
            this.context.Prestamos.Add(Prestamo);
            this.context.SaveChanges();
        }

        public void Delete(DeletePrestamosModel deletePrestamos)
        {
            Prestamos prestamostodelete = this.context.Prestamos.Find(deletePrestamos.idPrestamo);

            if (prestamostodelete == null)
            {
                throw new ArgumentException("Prestamo no encontrado");
            }


            PrestamoMapper.DeleteEntityPrestamo(deletePrestamos, prestamostodelete);

            prestamostodelete.Estado = false;
            this.context.Prestamos.Remove(prestamostodelete);
            this.context.SaveChanges();

        }

        

        public List<PrestamosModel> GetPrestamos()
        {
            return this.context.Prestamos.Select(PrestamoMapper.ToModel).ToList();
        }

        public PrestamosModel GetPrestamos(int idprestamo)
        {
            var prestamos = this.context.Prestamos.Find(idprestamo);

            return PrestamoMapper.ToModel(prestamos);
        }

        public void Update(UpdatePrestamomodel updateprestamo)
        {
            Prestamos Prestamotoupdate = this.context.Prestamos.Find(updateprestamo.idPrestamo);
            PrestamoMapper.UpdateentityPrestamo(updateprestamo, Prestamotoupdate);
            this.context.Prestamos.Update(Prestamotoupdate);
            this.context.SaveChanges();

        }
    }
}
