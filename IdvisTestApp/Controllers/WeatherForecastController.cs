using IdvisTestApp.Entities;
using IdvisTestApp.Entities.Tile;
using Microsoft.AspNetCore.Mvc;

namespace IdvisTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly Repository<Tile> _repo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, Repository<Tile> repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Tile> Get()
        {
            /*return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();*/

            return _repo.Find().Where(a => true).ToList();
        }
    }
}