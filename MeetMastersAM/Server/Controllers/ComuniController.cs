using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComuniController : ControllerBase
    {
        private readonly IComuniService _comuniService;

        public ComuniController(IComuniService comuniService)
        {
            _comuniService = comuniService;
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetDetails()
        {
            var items = await _comuniService.GetDetailsComuni();
            return Ok(items);
        }
    }
}
