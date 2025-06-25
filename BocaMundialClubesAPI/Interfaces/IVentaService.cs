using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Interfaces
{
    public interface IVentaService
    {
        void RegistrarVenta(Venta venta);
        IEnumerable<Venta> ObtenerVentas();
    }
}
