using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoSofwareTp1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProyectController : ControllerBase
    {
        private readonly IProyectServices _services;

        public ProyectController(IProyectServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _services.GetAllProyects();
            if (result == null || !result.Any())
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
