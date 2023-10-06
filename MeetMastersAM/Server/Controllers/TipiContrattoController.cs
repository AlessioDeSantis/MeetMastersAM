using MeetMastersAM.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipiContrattoController : ControllerBase
    {
        private readonly ITipiContrattoRepository _tipiContrattoRepository;

        public TipiContrattoController(ITipiContrattoRepository tipiContrattoRepository)
        {
            _tipiContrattoRepository = tipiContrattoRepository;
        }
    }
}
