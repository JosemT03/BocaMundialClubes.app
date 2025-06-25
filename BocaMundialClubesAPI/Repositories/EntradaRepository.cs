using BocaMundialClubesAPI.Models;
using BocaMundialClubesAPI.Interfaces;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        // Lista simulada de entradas (actúa como base de datos en memoria)
        private readonly List<Entrada> _entradas = new List<Entrada>
        {
            new Entrada { Id = 1, PartidoId = 1, Tipo = "General", Precio = 5000 },
            new Entrada { Id = 2, PartidoId = 1, Tipo = "Platea", Precio = 9000 },
            new Entrada { Id = 3, PartidoId = 2, Tipo = "VIP", Precio = 15000 },
            new Entrada { Id = 4, PartidoId = 3, Tipo = "General", Precio = 6000 }
        };

        // Obtener todas las entradas
        public IEnumerable<Entrada> ObtenerTodas()
        {
            return _entradas;
        }

        // Agregar una nueva entrada (simula una venta)
        public void Agregar(Entrada nuevaEntrada)
        {
            _entradas.Add(nuevaEntrada);
        }
    }
}

