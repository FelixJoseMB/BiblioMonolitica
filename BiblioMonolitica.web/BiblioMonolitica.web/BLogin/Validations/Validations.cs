using BiblioMonolitica.web.BLogin.Service;
using BiblioMonolitica.web.Data.Models;
using BiblioMonolitica.web.Data.Models.EstadoPrestamo;

namespace BiblioMonolitica.web.BLogin
{
    public class PrestamoValidations
    {

        public static void Validar(CreatePrestamosModel createPrestamosModel)
        {
            if (createPrestamosModel is null)
                throw new PrestamosServiceExeption("Este campo no puede ser nulo");


            if (createPrestamosModel.Descripcion.Length > 50)
                throw new PrestamosServiceExeption("La descripcion de este prestamo no puede exceder 50 caracteres");


        }
        public static void Validar(DeletePrestamosModel deletePrestamosModel)
        {
            if (deletePrestamosModel is null)
                throw new PrestamosServiceExeption("El usuario no puede ser nulo");


        }
        public static void Validar(UpdatePrestamomodel updatePrestamomodel)
        {
            if (updatePrestamomodel.Descripcion.Length > 50)
                throw new PrestamosServiceExeption("La descripcion de este prestamo no puede exceder 50 caracteres  ");
        }
    }
}
    

