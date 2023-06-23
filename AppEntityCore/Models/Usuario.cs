using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class Usuario
    {
        [Key]
        //la base de datos sql va identity, si es otra base de datos va otra cosa.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Nombre { get; set; }

        [NotMapped]
        public int Edad { get; set; }

        [Display(Name ="Correo elctrónico")]
        [EmailAddress(ErrorMessage = "Por favor ingrese un email válido")]
       //regular expression: una anotacion que especifica las caracteristicas que tiene que tener, por ej: +"!?@,
       //en el caso de un mail, que puede haber antes y después del @
       public string? Email { get; set; }

        [ForeignKey("DetalleUsuario")]
        public int DetalleUsuarioId { get; set; }
        public DetalleUsuario DetalleUsuario { get; set; }
    }
}
