namespace BocaMundialClubesAPI.Models
{
    public class Partido
    {
        public int Id { get; set; }
        public string Rival { get; set; }
        public DateTime Fecha { get; set; }
        public string Estadio { get; set; }
    }
}
