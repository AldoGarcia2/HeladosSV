using System.ComponentModel.DataAnnotations;

namespace HeladosSV.Models
{
    //precio comentado por el cambio que tendra en las demas fiunciones y por que seria de modificar 
    //en el backEnd

    public class Recipientes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Estado { get; set; } = null!;
        [Required(ErrorMessage = "El Tamaño es obligatorio")]
        public string Tamaño { get; set; } = null!;
        [Required(ErrorMessage = "El Imagen es obligatorio")]
        public string Imagen { get; set; }  = null!;

        //[Required(ErrorMessage = "El Nombre es obligatorio")]
        //public byte Precio { get; set; }
    }
}