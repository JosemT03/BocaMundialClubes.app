using BocaMundialClubesAPI.Models;
using System.Collections.Generic;
using BocaMundialClubesAPI.Interfaces;


namespace BocaMundialClubesAPI.Repositories
{
    public class PartidoRepository : IPartidoRepository
    {
        public IEnumerable<Partido> ObtenerTodos()
        {
            return new List<Partido>
            {
                new Partido { Id = 1, Rival = "River Plate", Fecha = DateTime.Today.AddDays(5), Estadio = "La Bombonera" },
                new Partido { Id = 2, Rival = "Racing Club", Fecha = DateTime.Today.AddDays(10), Estadio = "La Bombonera" },
                new Partido { Id = 3, Rival = "San Lorenzo", Fecha = DateTime.Today.AddDays(15), Estadio = "La Bombonera" }
            };
        }
    }
}

