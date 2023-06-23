using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    [Table (name: "Articulos")]
    public class Articulo
    {
        public int ArticuloId { get; set; }
        public string? TituloArticulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha { get; set; }

        [ForeignKey("Cateogria")]   
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<ArticuloEtiqueta> ArticuloEtiqueta { get; set; }
    }
}
