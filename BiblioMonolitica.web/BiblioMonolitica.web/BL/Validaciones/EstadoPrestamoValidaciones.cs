using BiblioMonolitica.web.BL.Exeptions;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;

namespace BiblioMonolitica.web.BL.Validaciones
{
    public static class EstadoPrestamoValidaciones
    {
        public static void Validar(CreateEstadoPrestamoModel createEstadoPrestamoModel) 
        {
            if (createEstadoPrestamoModel is null)           
                throw new EstadoPrestamoServiceException("El Estado Prestamo no puede ser nulo");

            
            if (createEstadoPrestamoModel.Descripcion.Length > 50)
                throw new EstadoPrestamoServiceException("La descripcion del EstadoPrestamo no puede exceder los 50 caracteres");
        }

        public static void Validar(UpdateEstadoPrestamoModel updateEstadoPrestamoModel) 
        {
            if (updateEstadoPrestamoModel.Descripcion.Length > 50)
                throw new UsuarioServiceException("La descripcion del EstadoPrestamo no puede exceder los 50 caracteres");
        }

        public static void Validar(DeleteEstadoPrestamoModel deleteEstadoPrestamoModel) 
        {
            if (deleteEstadoPrestamoModel is null)
                throw new EstadoPrestamoServiceException("El usuario no puede ser nulo");

        }

    }
}
