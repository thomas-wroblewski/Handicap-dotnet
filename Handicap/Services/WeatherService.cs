using Handicap.Entities;
using Microsoft.EntityFrameworkCore;

namespace Handicap.Services;

public interface IWeatherService
{
    public IEnumerable<WeatherForecast> getAllWeather();
    public void generateWeather(WeatherForecast weatherForecast);
}
public class WeatherService : IWeatherService
{
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    private readonly ILogger<WeatherService> _logger;
    private AppDbContext _context;

    public WeatherService(ILogger<WeatherService> logger, AppDbContext appDbContext)
    {
        this._context = appDbContext;
        this._logger = logger;
    }

    public IEnumerable<WeatherForecast> getAllWeather()
    {
        return _context.Forecasts.AsEnumerable();
    }

    public void generateWeather(WeatherForecast weatherForecast)
    {
        this._context.Forecasts.Add(weatherForecast);
        this._context.SaveChangesAsync();
    }

    // public IEnumerable<WeatherForecast> generateWeather()
    // {
    //     WeatherForecast[] forecasts =  Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //         {
    //             Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //             TemperatureC = Random.Shared.Next(-20, 55),
    //             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //         })
    //         .ToArray();
    //
    //
    //     return forecasts;
    // }
}