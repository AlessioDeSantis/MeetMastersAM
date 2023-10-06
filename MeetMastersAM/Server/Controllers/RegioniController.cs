using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class RegioniController : ControllerBase
    {
        private readonly IRegioniService _regioniService;
        public RegioniController(IRegioniService regioniService)
        {
            _regioniService = regioniService;
        }
    }
}
