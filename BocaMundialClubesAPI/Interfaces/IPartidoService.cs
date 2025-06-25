using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Interfaces
{
    public interface IPartidoService
    {
        IEnumerable<Partido> ObtenerPartidos();
    }
}
