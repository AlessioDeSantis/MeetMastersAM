using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class TipiColloquioController : ControllerBase
    {
        private readonly ITipiColloquiService _tipiColloquiService;
        public TipiColloquioController(ITipiColloquiService tipiColloquiService)
        {
            _tipiColloquiService = tipiColloquiService;
        }
    }
}
