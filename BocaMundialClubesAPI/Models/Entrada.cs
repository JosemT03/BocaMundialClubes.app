namespace BocaMundialClubesAPI.Models
{
    public class Entrada
    {
        public int Id { get; set; }
        public int PartidoId { get; set; }
        public string Tipo { get; set; } 
        public decimal Precio { get; set; }
    }
}
