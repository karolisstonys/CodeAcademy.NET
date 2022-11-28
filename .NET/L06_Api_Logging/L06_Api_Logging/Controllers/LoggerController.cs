using L06_Api_Logging.Models.Dto;
using L06_Api_Logging.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace L06_Api_Logging.Controllers
{
    /// <summary>
    /// 6 Paskaita: logging funkcionalumas
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        private readonly ILogger<LoggerController> _logger;
        private readonly IBadService _badService;
        private readonly IDivisionService _divisionService;

        public LoggerController(ILogger<LoggerController> logger, IBadService badService, IDivisionService divisionService)
        {
            _logger = logger;
            _badService = badService;
            _divisionService=divisionService;
        }

        /// <summary>
        /// Demonstruojamas bazinis visu loginiu lygiu funkcionalumas
        /// </summary>
        /// <returns>Rezultatu masyvas</returns>
        /// <response code="200">Teisingai ivykdomas loginimo logika ir gauname informacija</response>
        /// <response code="500">Baisi klaida!</response>
        [HttpGet("Get")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetLoggingResult>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult Get()
        {
            _logger.LogTrace("Trace tekstas");
            _logger.LogDebug("Debug tekstas");
            _logger.LogInformation("Betkokia informacija is loggerio.");
            _logger.LogWarning("Kazkokia ispejimas");
            _logger.LogError("Klaida!");
            _logger.LogCritical("Kazkokia kritine klaida!!!");

            return Ok();
        }

        /// <summary>
        /// Demonstruojamas serviso 'luzimo' situacijos loginimas
        /// </summary>
        /// <returns></returns>
        [HttpGet("BadService")]
        [ProducesResponseType(typeof(GetServiceResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetBadService()
        {
            _logger.LogInformation("BadService buvo iskvietas {0} ", DateTime.Now);
            try
            {
                _badService.DoSomeWork();
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Blogas servisas nuluzo {0}", DateTime.Now);
            }
            return Ok(new GetServiceResult(555555));
        }



        /// <summary>
        /// Dalyba paduotu dvieju sveikuju skaiciu
        /// </summary>
        /// <param name="a">Sveikas skaicius kuri daliname</param>
        /// <param name="b">Sveikas skaicius is kurio daliname</param>
        /// <returns></returns>
        [HttpGet("Division")]
        [ProducesResponseType(typeof(GetServiceResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Division(int a, int b)
        {
            double res = 0;
            _logger.LogInformation("Division service buvo iskvietas {0}, su parametrais a={1} ir b={2} ", DateTime.Now, a, b);
            try
            {
                res = _divisionService.DivideTwoInts(a, b);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Division servisas nuluzo {0}, su parametrais a={1} ir b={2} ", DateTime.Now, a, b);
            }
            return Ok(res);
        }

    }
}
