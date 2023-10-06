using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipiDiDocumentiController : ControllerBase
    {
        private readonly ITipiDiDocumentiService _tipiDiDocumentiService;

        public TipiDiDocumentiController(ITipiDiDocumentiService tipiDiDocumentiService)
        {
            _tipiDiDocumentiService = tipiDiDocumentiService;
        }
    }
}
