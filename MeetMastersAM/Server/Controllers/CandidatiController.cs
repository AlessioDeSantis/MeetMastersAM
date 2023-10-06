using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatiController : ControllerBase
    {
        private readonly ICandidatiService _candidatiService;

        public CandidatiController(ICandidatiService candidatiService)
        {
            _candidatiService = candidatiService;
        }
    }
}
