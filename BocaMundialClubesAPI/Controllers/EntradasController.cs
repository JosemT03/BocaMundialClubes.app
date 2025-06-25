using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntradasController : ControllerBase
    {
        private readonly IEntradaService _service;

        public EntradasController(IEntradaService service)
        {
            _service = service;
        }

        // GET: api/entradas
        [HttpGet]
        public ActionResult<IEnumerable<Entrada>> Get()
        {
            var entradas = _service.ObtenerEntradas();
            return Ok(entradas);
        }

        // POST: api/entradas
        [HttpPost]
        public IActionResult Post([FromBody] Entrada entrada)
        {
            if (entrada == null)
                return BadRequest("Entrada inválida.");

            _service.AgregarEntrada(entrada);
            return Ok(new { mensaje = "Entrada registrada con éxito." });
        }
    }
}


