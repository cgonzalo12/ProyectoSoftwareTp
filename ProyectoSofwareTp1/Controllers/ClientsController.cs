using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ProyectoSofwareTp1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientServices _services;
        public ClientsController(IClientServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result=await _services.GetAllClients();
            if (result == null || !result.Any())
            {
                return NoContent();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientDTO clientDto)
        {
            var result = await _services.CrearClient(clientDto);
            return new JsonResult(result) {StatusCode=201};
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
