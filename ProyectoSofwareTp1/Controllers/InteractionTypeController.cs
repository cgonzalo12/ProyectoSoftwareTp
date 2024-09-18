using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoSofwareTp1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InteractionTypeController : ControllerBase
    {
        private readonly IInteractionTypeServices _services;

        public InteractionTypeController(IInteractionTypeServices interactionTypeServices)
        {
            _services = interactionTypeServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _services.GetAllInteractionType();
            if (result == null || !result.Any())
            {
                return NoContent();
            }

            return Ok(result);
        }


    }
}
