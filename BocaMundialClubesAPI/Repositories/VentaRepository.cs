using BocaMundialClubesAPI.Models;
using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Data;
using System.Collections.Generic;
using System.Linq;

namespace BocaMundialClubesAPI.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly AppDbContext _context;

        public VentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void RegistrarVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        public IEnumerable<Venta> ObtenerTodas()
        {
            return _context.Ventas.ToList();
        }
    }
}

