using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatiController : ControllerBase
    {
        private readonly ICandidatiService _candidatiService;

        public CandidatiController(ICandidatiService candidatiService)
        {
            _candidatiService = candidatiService;
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetDetails()
        {
            var items = await _candidatiService.GetDetailsCandidati();
            return Ok(items);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await _candidatiService.GetAllElements();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _candidatiService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost("aggiungi")]
        public async Task<ActionResult<Candidati>> Post(Candidati candidati)
        {
            await _candidatiService.CreateElement(candidati);
            return CreatedAtAction("Indice", new { id = candidati.CandidatoId }, candidati);
        }

        [HttpPut("modifica/{id}")]
        public async Task<IActionResult> Put(int id, Candidati candidati)
        {
            if (id != candidati.CandidatoId)
            {
                return BadRequest();
            }

            await _candidatiService.UpdateElement(candidati);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _candidatiService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }

            await _candidatiService.DeleteElement(id);

            return NoContent();
        }
    }
}
