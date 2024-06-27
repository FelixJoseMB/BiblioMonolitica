namespace BiblioMonolitica.web.Data.Models.CategoriaModels
{
    public class CategoriaBaseModel : ModelBaseCategoria
    {
        public String? Descripcion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
