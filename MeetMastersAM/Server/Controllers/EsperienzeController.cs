using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsperienzeController : ControllerBase
    {
        private readonly IEsperienzeService _esperienzeService;

        public EsperienzeController(IEsperienzeService esperienzeService)
        {
            _esperienzeService = esperienzeService;
        }
    }
}
