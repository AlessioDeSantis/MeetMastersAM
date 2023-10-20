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
}


