using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace HeladosSV.Models
{
    public class Usuario
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
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; } = null!;
    }

    public class UserLogin
    {
        [Required(ErrorMessage = "El Login es obligatorio")]
        public string Login { get; set; } = null!;
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; } = null!;
    }
}

