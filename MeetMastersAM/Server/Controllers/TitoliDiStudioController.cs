using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitoliDiStudioController : ControllerBase
    {
        private readonly ITitoliDiStudioService _titoliDiStudioService;

        public TitoliDiStudioController(ITitoliDiStudioService titoliDiStudioService)
        {
            _titoliDiStudioService = titoliDiStudioService;
        }
    }
}
