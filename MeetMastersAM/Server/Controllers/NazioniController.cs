using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class NazioniController : ControllerBase
    {
        private readonly INazioniService _nazioniservice;

        public NazioniController(INazioniService nazioniService)
        {
            _nazioniservice = nazioniService;
        }
    }
}
