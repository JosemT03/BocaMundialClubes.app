using BocaMundialClubesAPI.Data;
using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BocaMundialClubesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly IVentaService _service;
        private readonly AppDbContext _context;

        public VentasController(AppDbContext context, IVentaService service)
        {
            _service = service;
            _context = context;
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
        [HttpPut("{id}")]
        public IActionResult ActualizarVenta(int id, [FromBody] Venta ventaActualizada)
        {
            var venta = _context.Ventas.FirstOrDefault(v => v.Id == id);
            if (venta == null)
                return NotFound();

            
            venta.NombreComprador = ventaActualizada.NombreComprador;
            venta.TelefonoComprador = ventaActualizada.TelefonoComprador;

            _context.SaveChanges();
            return Ok(venta);
        }
        [HttpDelete("{id}")]
        public IActionResult BorrarVenta(int id)
        {
            var venta = _context.Ventas.FirstOrDefault(v => v.Id == id);
            if (venta == null)
                return NotFound();

            _context.Ventas.Remove(venta);
            _context.SaveChanges();

            return NoContent(); // o return Ok();
        }

    }
}
