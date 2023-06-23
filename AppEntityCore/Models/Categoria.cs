using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    [Table (name : "Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Requeried]
        [StringLength(50)]
        public string? NombreCategoria { get; set; }

        public ICollection <Producto>? Productos { get; set; }
    }
}
