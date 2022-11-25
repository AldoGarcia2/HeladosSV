namespace HeladosSV.Models
{
    //precio comentado por el cambio que tendra en las demas fiunciones y por que seria de modificar 
    //en el backEnd

    public class SaborH
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Imagen { get; set; } = null!;
        //public byte Precio { get; set; }
    }
}
