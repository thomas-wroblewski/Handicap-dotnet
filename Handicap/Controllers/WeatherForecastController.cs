using Handicap.Entities;
using Handicap.Services;
using Microsoft.AspNetCore.Mvc;

namespace Handicap.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private IWeatherService _weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService service)
    {
        _weatherService = service;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.Log(LogLevel.Information, "GetWeatherController");
  
        return _weatherService.getAllWeather();
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public IActionResult Post([FromBody] WeatherForecast weatherForecast)
    {
        _logger.LogInformation("Generating Weather");
        _weatherService.generateWeather(weatherForecast);

        return Ok(weatherForecast);
    }
}