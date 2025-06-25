using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _repo;

        public VentaService(IVentaRepository repo)
        {
            _repo = repo;
        }

        public void RegistrarVenta(Venta venta)
        {
            _repo.RegistrarVenta(venta);
        }

        public IEnumerable<Venta> ObtenerVentas()
        {
            return _repo.ObtenerTodas();
        }
    }
}
