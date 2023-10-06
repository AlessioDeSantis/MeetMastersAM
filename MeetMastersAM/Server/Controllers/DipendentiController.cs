using MeetMastersAM.Server.Repository;
using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DipendentiController : ControllerBase
    {
        private readonly IDipendentiService _dipendentiService;

        public DipendentiController(IDipendentiService dipendentiService)
        {
            _dipendentiService = dipendentiService;
        }
    }
}
