using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class LivelliContrattiController : ControllerBase
    {
        private readonly ILivelliContrattiService _livelliContrattiService;

        public LivelliContrattiController(ILivelliContrattiService livelliContrattiService)
        {
            _livelliContrattiService = livelliContrattiService;
        }
    }


}
