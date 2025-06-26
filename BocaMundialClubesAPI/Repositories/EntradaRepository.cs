using BocaMundialClubesAPI.Models;
using BocaMundialClubesAPI.Interfaces;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        
        private readonly List<Entrada> _entradas = new List<Entrada>
        {
            new Entrada { Id = 1, PartidoId = 1, Tipo = "General", Precio = 5000 },
            new Entrada { Id = 2, PartidoId = 1, Tipo = "Platea", Precio = 9000 },
            new Entrada { Id = 3, PartidoId = 2, Tipo = "VIP", Precio = 15000 },
            new Entrada { Id = 4, PartidoId = 3, Tipo = "General", Precio = 6000 }
        };

        
        public IEnumerable<Entrada> ObtenerTodas()
        {
            return _entradas;
        }

        
        public void Agregar(Entrada nuevaEntrada)
        {
            _entradas.Add(nuevaEntrada);
        }
    }
}

