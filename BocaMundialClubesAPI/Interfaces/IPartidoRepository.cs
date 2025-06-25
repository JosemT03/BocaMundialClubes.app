using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Interfaces
{
    public interface IPartidoRepository
    {
        IEnumerable<Partido> ObtenerTodos();
    }
}
