using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Services
{
    public class PartidoService : IPartidoService
    {
        private readonly IPartidoRepository _repo;

        public PartidoService(IPartidoRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Partido> ObtenerPartidos()
        {
            return _repo.ObtenerTodos();
        }
    }
}

