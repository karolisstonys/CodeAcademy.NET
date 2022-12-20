using Api_One.Models.ApiModels;
using Api_One.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_One.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeApiController : ControllerBase
    {
        private readonly IFakeApiProxyService _service;
        private readonly ILogger<FakeApiProxyService> _logger;

        public FakeApiController(IFakeApiProxyService service, ILogger<FakeApiProxyService> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookApiResult>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await _service.GetBooks();
                return Ok(res);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ivyko kazkas blogo");
                throw;
            }
        }

    }
}
