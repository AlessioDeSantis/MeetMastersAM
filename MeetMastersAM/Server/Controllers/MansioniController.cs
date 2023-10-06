using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class MansioniController : ControllerBase
    {
        private readonly IMansioniService _mansioniService;
        public MansioniController(IMansioniService mansioniService)
        {
            _mansioniService = mansioniService;
        }
    }

}
