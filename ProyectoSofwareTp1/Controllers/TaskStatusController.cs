using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoSofwareTp1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaskStatusController : ControllerBase
    {
        
        private readonly ITaskStatusServices _services;

        public TaskStatusController(ITaskStatusServices services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _services.GetAllTaskStatus();
            return new JsonResult(result);
        }
    }
}
