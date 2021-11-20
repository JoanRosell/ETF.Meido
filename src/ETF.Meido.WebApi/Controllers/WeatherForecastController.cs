using ETF.Meido.CrossCutting.Errors.Implementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorType = ETF.Meido.CrossCutting.Errors.Contracts.ErrorType;

namespace ETF.Meido.WebApi.Controllers
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
        private readonly ErrorService _errorService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ErrorService errorService)
        {
            _logger = logger;
            _errorService = errorService;
        }

        [HttpGet]
        public IEnumerable<Error> Get()
        {
            yield return _errorService.GetError(ErrorType.GenericError);
        }
    }
}
