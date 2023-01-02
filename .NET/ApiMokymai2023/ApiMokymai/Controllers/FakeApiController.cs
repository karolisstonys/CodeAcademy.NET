using ApiMokymai.Models.ApiModels;
using ApiMokymai.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers
{

    /*
     3. klientas pasirenka knygos pristatymo adresą (Lietuvoje). Ir suskaiciuojama pristatymo kaina. Bazine kaina yra 5Eur. Sandelio vieta yra Vilnius
        3.1. Jei nuomos vieta yra 50km atsumu kaina sumažėja 2 Eur
        3.2. Jei nuomos vieta yra >50km <100km atsumu kaina nesikeičia
        3.3. Jei nuomos vieta yra >150km <300km atsumu kaina padidėja 2 Eur
        3.4. Jei nuomos vieta yra >300km atsumu - pristatymas negalimas.
    */
    [Route("api/[controller]")]
    [ApiController]
    public class FakeApiController : ControllerBase
    {
        private readonly IFakeApiProxyService _service;
        private readonly ILogger<FakeApiController> _logger;

        public FakeApiController(IFakeApiProxyService service, 
            ILogger<FakeApiController> logger)
        {
            _service = service;
            _logger = logger;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookApiModel>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var res = await _service.GetBooks();
                return Ok(res);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                throw; 
            }
        
        }

        [HttpPost]
        public async Task<IActionResult> Post(BookApiModel data)
        {
            try
            {
                await _service.CreateBook(data);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ivyko kazkas labai baisaus");
                throw;
            }
        }

    }
}
