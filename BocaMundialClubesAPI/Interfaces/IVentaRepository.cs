using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Interfaces
{
    public interface IVentaRepository
    {
        void RegistrarVenta(Venta venta);
        IEnumerable<Venta> ObtenerTodas();
    }
}
