using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitsController : ControllerBase
    {
        private readonly IBenefitsServices _benefitservice;

        public BenefitsController(IBenefitsServices benefitsServices)
        {
            _benefitservice = benefitsServices;
        }

        [HttpGet]
        public async Task<IActionResult> BenefitsIndex()
        {
            var item = await _benefitservice.GetAllElements();
            return Ok(item);
        }
    }
}
