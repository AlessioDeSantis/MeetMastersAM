using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class SediController : ControllerBase
    {
        private readonly ISediService _Sediservice;
        public SediController(ISediService sediService)
        {
            _Sediservice = sediService;
        }
    }
}
