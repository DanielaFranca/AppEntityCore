using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set;}

        // 3 ejemplos distintos de como guardar la fecha y la hora 
        [Column(TypeName = "datetime")]
        public DateTime FechaPedido { get; set;}

        [Column(TypeName = "date")]
        public DateTime FechaEntrega { get; set;}

        [Column(TypeName = "time")]
        public TimeSpan HoraEntrega { get; set;}


    }
}
