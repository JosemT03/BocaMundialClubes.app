using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocaMundialClubesForms
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
