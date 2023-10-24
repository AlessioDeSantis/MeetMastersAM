using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.AspNetCore.Mvc;


namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MansioniController : ControllerBase
    {
        private readonly IMansioniService _mansioniService;
        public MansioniController(IMansioniService mansioniService)
        {
            _mansioniService = mansioniService;
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetDetails()
        {
            var items = await _mansioniService.GetDetailsMansioni();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _mansioniService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost("aggiungi")]
        public async Task<ActionResult<Mansioni>> Post(Mansioni mansioni)
        {
            await _mansioniService.CreateElement(mansioni);
            return CreatedAtAction("Indice", new { id = mansioni.MansioneId }, mansioni);
        }

        [HttpPut("modifica/{id}")]
        public async Task<IActionResult> Put(int id, Mansioni mansione)
        {
            if (id != mansione.MansioneId)
            {
                return BadRequest();
            }

            await _mansioniService.UpdateElement(mansione);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _mansioniService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }

            await _mansioniService.DeleteElement(id);

            return NoContent();
        }
    }

}
