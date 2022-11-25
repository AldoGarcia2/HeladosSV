namespace HeladosSV.Models
{

    //Tabla ventas creada pero no se sabe si 
    //se agregara al´prodcuto final
    //posiblemente si se agrege
    //posiblemente no
    public class Ventas
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdSaborH { get; set; }
        public int  IdRecipientes  { get; set; }
        //public byte  Total { get; set; }
    }
}