using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DipendentiController : ControllerBase
{
    private readonly IDipendentiService _dipendentiService;

    public DipendentiController(IDipendentiService dipendentiService)
    {
        _dipendentiService = dipendentiService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var items = await _dipendentiService.GetAllElements();
        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var item = await _dipendentiService.GetElementById(id);
        if (item == null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    [HttpPost("aggiungi")]
    public async Task<ActionResult<Dipendenti>> Post(Dipendenti dipendenti)
    {
        await _dipendentiService.CreateElement(dipendenti);
        return CreatedAtAction("Indice", new { id = dipendenti.DipendenteId }, dipendenti);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dipendenti dipendenti)
    {
        if (id != dipendenti.DipendenteId)
        {
            return BadRequest();
        }

        await _dipendentiService.UpdateElement(dipendenti);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _dipendentiService.GetElementById(id);
        if (item == null)
        {
            return NotFound();
        }

        await _dipendentiService.DeleteElement(id);

        return NoContent();
    }
}
