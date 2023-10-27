using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillsService _skillsService;
        public SkillController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetDetails()
        {
            var items = await _skillsService.GetDetailsSkills();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _skillsService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost("aggiungi")]
        public async Task<ActionResult<Benefits>> Post(Skills skill)
        {
            await _skillsService.CreateElement(skill);
            return CreatedAtAction("Indice", new { id = skill.SkillId }, skill);
        }

        [HttpPut("modifica/{id}")]
        public async Task<IActionResult> Put(int id, Skills skill)
        {
            if (id != skill.SkillId)
            {
                return BadRequest();
            }

            await _skillsService.UpdateElement(skill);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _skillsService.GetElementById(id);
            if (item == null)
            {
                return NotFound();
            }

            await _skillsService.DeleteElement(id);

            return NoContent();
        }
    }
}
