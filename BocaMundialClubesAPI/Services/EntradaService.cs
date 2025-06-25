using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Services
{
    public class EntradaService : IEntradaService
    {
        private readonly IEntradaRepository _repo;

        public EntradaService(IEntradaRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Entrada> ObtenerEntradas()
        {
            return _repo.ObtenerTodas();
        }

        public void AgregarEntrada(Entrada entrada)
        {
            _repo.Agregar(entrada);
        }
    }
}


