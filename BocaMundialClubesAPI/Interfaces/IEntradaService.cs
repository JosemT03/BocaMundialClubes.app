using BocaMundialClubesAPI.Models;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Interfaces
{
    public interface IEntradaService
    {
        IEnumerable<Entrada> ObtenerEntradas();

        void AgregarEntrada(Entrada entrada);
    }
}
