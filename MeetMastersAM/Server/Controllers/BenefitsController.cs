using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitsController : ControllerBase
    {
        private readonly IBenefitsServices _benefitsService;

        public BenefitsController(IBenefitsServices benefitsServices)
        {
            _benefitsService = benefitsServices;
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetDetails()
        {
            var items = await _benefitsService.GetDetailsBenefits();
            return Ok(items);
        }

        [HttpGet]
        public async Task<IActionResult> BenefitsIndex()
        {
            var item = await _benefitsService.GetAllElements();
            return Ok(item);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _benefitsService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost("aggiungi")]
        public async Task<ActionResult<Benefits>> Post(Benefits benefits)
        {
            await _benefitsService.CreateElement(benefits);
            return CreatedAtAction("Indice", new { id = benefits.BenefitId }, benefits);
        }

        [HttpPut("modifica/{id}")]
        public async Task<IActionResult> Put(int id, Benefits benefits)
        {
            if (id != benefits.BenefitId)
            {
                return BadRequest();
            }

            await _benefitsService.UpdateElement(benefits);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _benefitsService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }

            await _benefitsService.DeleteElement(id);

            return NoContent();
        }
    }
}
