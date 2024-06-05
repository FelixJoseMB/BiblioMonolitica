using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Models;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class PrestamosDb : IPrestamosDb
    {
        private object context;

        public PrestamosDb(BibliotecaContext context)
        {
            
        }
        public List<PrestamosModel> Prestamos => throw new NotImplementedException();

        public PrestamosModel GetPrestamos(int idPrestamos)
        {
        var prestamo = this.context.Prestamo.Find(idPrestamos);

            PrestamosModel prestamosModel = new PrestamosModel() 
            {
             Estado = prestamo.Estado,
             EstadoEntregado = prestamo.EstadoEntregado,
             EstadoRecibido = prestamo.EstadoRecibido,
             IdEstadoPrestamo = prestamo.IdEstadoPrestamo,
             FechaConfirmacionDevolucion = prestamo.FechaConfirmacionDevolucion,
             FechaDevolucion = prestamo.FechaDevolucion,
            

            };

            return prestamosModel;
        }
        public void savePrestamos(PrestamosSaveModel prestamosSave)
        {
            Prestamos prestamos = new Prestamos()
            {
             Estado = prestamosSave.Estado,
             EstadoEntregado = prestamosSave.EstadoEntregado,
             EstadoRecibido = prestamosSave.EstadoRecibido,
             FechaConfirmacionDevolucion = prestamosSave.FechaConfirmacionDevolucion,
             FechaDevolucion = prestamosSave.FechaDevolucion,
             CreationUser  = prestamosSave.creationUser
            };
            this.context.Prestamos.Add(prestamos);
            this.context.SaveChanges();
        }
        public List<PrestamosModel> GetPrestamos() => context.Prestamos.Select();

        public void removePrestamos()
        {
            throw new NotImplementedException();
        }

        public void savePrestamos(PrestamosSaveModel prestamos)
        {
            throw new NotImplementedException();
        }

        public void UpdatePrestamos(PrestamosUpdateModel updateModel)
        {
            Prestamos prestamos = this.context.Prestamos.find(updateModel.Estado)   
        }
    }
}
