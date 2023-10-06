using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContrattiController : ControllerBase
    {
        private readonly IContrattiService _contrattiService;

        public ContrattiController(IContrattiService contrattiService)
        {
            _contrattiService = contrattiService;
        }
    }
}
