using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColloquiController : ControllerBase
    {
        private readonly IColloquiService _colloquiService;

        public ColloquiController(IColloquiService colloquiService)
        {
            _colloquiService = colloquiService;
        }
    }
}
