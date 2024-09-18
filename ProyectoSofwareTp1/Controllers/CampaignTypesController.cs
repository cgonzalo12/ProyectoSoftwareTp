using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoSofwareTp1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CampaignTypesController : ControllerBase
    {
        private readonly ICampaignTypeServices _services;
        public CampaignTypesController(ICampaignTypeServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _services.GetAllCampaingTypes();
            if (result == null || !result.Any())
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
