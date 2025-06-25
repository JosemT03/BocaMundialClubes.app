using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Interfaces
{
    public interface IEntradaRepository
    {
        IEnumerable<Entrada> ObtenerTodas();

        void Agregar(Entrada nuevaEntrada);
    }
}
