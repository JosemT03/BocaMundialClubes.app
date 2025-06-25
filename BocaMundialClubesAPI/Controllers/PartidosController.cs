using Microsoft.AspNetCore.Mvc;
using BocaMundialClubesAPI.Interfaces;
using BocaMundialClubesAPI.Models;

namespace BocaMundialClubesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartidosController : ControllerBase
    {
        private readonly IPartidoService _service;

        public PartidosController(IPartidoService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Partido>> Get()
        {
            return Ok(_service.ObtenerPartidos());
        }
    }
}



