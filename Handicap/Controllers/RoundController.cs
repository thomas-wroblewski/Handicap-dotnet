using Handicap.Entities;
using Handicap.Services;
using Microsoft.AspNetCore.Mvc;

namespace Handicap.Controllers;



[ApiController]
[Route("[controller]")]
public class RoundController : ControllerBase
{

    private IRoundService _roundService;
    private ILogger<RoundController> _logger;


    public RoundController(IRoundService roundService, ILogger<RoundController> logger)
    {
        this._roundService = roundService;
        this._logger = logger;
    }


    [HttpPost(Name = "Add a Round")]
    public IActionResult Post([FromBody] Round round)
    {
        _logger.LogInformation("Adding a new round");
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        this._roundService.addRound(round);
        
        return Ok(round);
    }

    [HttpGet(Name = "Get All Rounds")]
    public async Task<ActionResult<Round>> Get([FromQuery] int count)
    {
        List<Round> rounds = null;
        
        if (count == 0)
        {
            rounds = await _roundService.getAllRounds();
            return Ok(rounds);
        }

        rounds = await _roundService.getLastXRounds(count);
        return Ok(rounds);


    }
}