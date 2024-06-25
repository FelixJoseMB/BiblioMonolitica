using System.Linq.Expressions;
using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.Entities;
using BiblioMonolitica.web.Data.Exeptions;
using BiblioMonolitica.web.Data.Interfaces;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;
using BiblioMonolitica.web.Mappeo;

namespace BiblioMonolitica.web.Data.DbObjects
{
    public class EstadoPrestamoDB : IEstadoPrestamo
    {

        private readonly BibliotecaContext context;

        public EstadoPrestamoDB(BibliotecaContext context)
        {
            this.context = context;
        }

        public void Create(CreateEstadoPrestamoModel createEstadoPrestamo)
        {
           
            var estadoPrestamo = EstadoPrestamoMapper.ToEntity(createEstadoPrestamo);
            estadoPrestamo.Estado = true;

            this.context.EstadoPrestamo.Add(estadoPrestamo);
            this.context.SaveChanges();
        }

        public void Delete(DeleteEstadoPrestamoModel deleteEstadoPrestamo)
        {
            EstadoPrestamo estadoPrestamoToDelete = this.context.EstadoPrestamo.Find(deleteEstadoPrestamo.idEstadoPrestamo);

            if (estadoPrestamoToDelete == null)
            {
                throw new ArgumentException("Estado Prestamo no encontrado");
            }

            // Utilizar el método DeleteEntityEstadoPrestamo para eliminar la entidad con los datos de eliminación
            EstadoPrestamoMapper.DeleteEntityEstadoPrestamo(deleteEstadoPrestamo, estadoPrestamoToDelete);

                 estadoPrestamoToDelete.Estado = false;
                // Actualizar la entidad en el contexto y guardar los cambios en la base de datos
                this.context.EstadoPrestamo.Remove(estadoPrestamoToDelete);
                this.context.SaveChanges();

        }

        public List<EstadoPrestamoModel> GetEstadoPrestamo()
        {
            return this.context.EstadoPrestamo.Select(EstadoPrestamoMapper.ToModel).ToList();
        }

        public EstadoPrestamoModel GetEstadoPrestamo(int idEstadoPrestamo)
        {
            var estadoPrestamo = this.context.EstadoPrestamo.Find(idEstadoPrestamo);

            return EstadoPrestamoMapper.ToModel(estadoPrestamo);
        }

        public void Update(UpdateEstadoPrestamoModel updateEstadoPrestamo)
        {
            EstadoPrestamo estadoPrestamoToUpdate = this.context.EstadoPrestamo.Find(updateEstadoPrestamo.idEstadoPrestamo);
            EstadoPrestamoMapper.UpdateEntityEstadoPrestamo(updateEstadoPrestamo, estadoPrestamoToUpdate);

         
           this.context.EstadoPrestamo.Update(estadoPrestamoToUpdate);
           this.context.SaveChanges();

        }
    }
}
