using BiblioMonolitica.web.BLogin.Exeptions;
using BiblioMonolitica.web.Data.Models.CategoriaModels;

namespace BiblioMonolitica.web.BLogin.Validaciones
{
    public class CategoriaValidaciones
    {
        public static void Validar(CreateCategoriaModels createCategoriaModels)
        {
            if (createCategoriaModels is null)
            {
                throw new CategoriaExeption(" la categoria no puede ser nula");
            }

            if (createCategoriaModels.Descripcion.Length <= 200 && createCategoriaModels is null)
            {
                throw new CategoriaExeption("la descripcion no puede ser mayor a 200 caracteres y no puede ser nulo");
            }

        }

        public static void Validar(UpdateCategoriaModels updateCategoriaModels)
        {
            if (string.IsNullOrEmpty(updateCategoriaModels.Descripcion))
            {
                throw new CategoriaExeption(" la categoria no puede ser nula");
            }

            if (updateCategoriaModels.Descripcion.Length > 200)
            {
                throw new CategoriaExeption("la descripcion no puede ser mayor a 200 caracteres y no puede ser nulo");
            }


        }

        public static void Validar (DeleteCategoriaModels deleteCategoriaModels)
        {
            if (deleteCategoriaModels is null)
            {
                throw new CategoriaExeption(" la categoria no puede ser nula");
            }
        }

    }
}
