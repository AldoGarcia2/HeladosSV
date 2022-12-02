using System.ComponentModel.DataAnnotations;

namespace HeladosSV.Models
{
    public class EditUsuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Rol es obligatorio")]
        public int IdRol { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; } = null!;

        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; } = null!;

        [Required(ErrorMessage = "Estatus es obligatorio")]
        public int Estatus { get; set; }
    }
}
