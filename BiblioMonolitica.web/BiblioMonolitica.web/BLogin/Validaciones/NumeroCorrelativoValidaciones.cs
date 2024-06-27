using BiblioMonolitica.web.BLogin.Exeptions;

using BiblioMonolitica.web.Data.Models.NumeroCorrelativoModels;

namespace BiblioMonolitica.web.BLogin.Validaciones
{
    public class NumeroCorrelativoValidaciones
    {
        public static void Validar(CreateNumeroCorrelativoModels createNumeroCorrelativoModels )
        {
            if (createNumeroCorrelativoModels is null)
            {
                throw new CategoriaExeption(" Numero Correlativo no puede ser nula");
            }

            if (createNumeroCorrelativoModels.Prefijo.Length <= 20 && createNumeroCorrelativoModels is null)
            {
                throw new CategoriaExeption("el prefijo no puede ser mayor a 20 caracteres y no puede ser nulo");
            }

        }

        public static void Validar(UpdateNumeroCorrelativoModels updateNumeroCorrelativoModels)
        {
            if (string.IsNullOrEmpty(updateNumeroCorrelativoModels.Prefijo))
            {
                throw new CategoriaExeption(" el prefijo no puede ser nulo");
            }

            if (updateNumeroCorrelativoModels.Prefijo.Length > 20)
            {
                throw new CategoriaExeption("el prefijo no puede ser mayor a 20 caracteres y no puede ser nulo");
            }


        }

        public static void Validar(DeleteNumeroCorrelativoModels deleteNumeroCorrelativoModels)
        {
            if (deleteNumeroCorrelativoModels is null)
            {
                throw new CategoriaExeption(" el prefijo no puede ser nulo");
            }
        }
    }
}
