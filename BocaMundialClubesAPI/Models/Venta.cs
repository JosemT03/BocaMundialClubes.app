namespace BocaMundialClubesAPI.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int PartidoId { get; set; }        
        public string TipoEntrada { get; set; }   
        public string NombreComprador { get; set; }
        public string TelefonoComprador { get; set; }
        public decimal Precio { get; set; }
    }
}
