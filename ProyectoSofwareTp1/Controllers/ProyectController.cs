using Application.DTOs;
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

        [HttpPost]
        public async Task<IActionResult> CreateProyect(CreateProyectDTO proyectDTO)
        {
            var result = await _services.CrearProyect(proyectDTO);
            return new JsonResult(result) { StatusCode = 201 };
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _services.GetById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }



    }
}
