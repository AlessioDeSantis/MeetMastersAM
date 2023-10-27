using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SediController : ControllerBase
{
    private readonly ISediService _sediService;

    public SediController(ISediService sediService)
    {
        _sediService = sediService;
    }

    [HttpGet("lista")]
    public async Task<IActionResult> GetSedi()
    {
        var items = await _sediService.GetDetailsSedi();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var item = await _sediService.GetElementById(id);
        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpPost("aggiungi")]
    public async Task<ActionResult<Sedi>> Post(Sedi sedi)
    {
        await _sediService.CreateElement(sedi);
        return CreatedAtAction("Indice", new { id = sedi.SedeId }, sedi);
    }

    [HttpPut("modifica/{id}")]
    public async Task<IActionResult> Put(int id, Sedi sedi)
    {

        if (id != sedi.SedeId)
        {
            return BadRequest();
        }

        await _sediService.UpdateElement(sedi);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _sediService.GetElementById(id);
        if (item == null)
        {
            return NotFound();
        }

        await _sediService.DeleteElement(id);

        return NoContent();
    }
}


