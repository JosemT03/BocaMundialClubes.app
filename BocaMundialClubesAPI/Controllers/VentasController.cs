using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly IVentaService _service;

        public VentasController(IVentaService service)
        {
            _service = service;
        }

        // POST: api/ventas
        [HttpPost]
        public IActionResult Post([FromBody] Venta venta)
        {
            if (venta == null)
                return BadRequest("Datos incompletos.");

            _service.RegistrarVenta(venta);
            return Ok(new { mensaje = "Venta registrada con éxito." });
        }

        // GET: api/ventas
        [HttpGet]
        public ActionResult<IEnumerable<Venta>> Get()
        {
            var ventas = _service.ObtenerVentas();
            return Ok(ventas);
        }
    }
}
