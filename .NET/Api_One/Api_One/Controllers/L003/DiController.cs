using Api_One.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_One.Controllers.L003
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiController : ControllerBase
    {
        private readonly IMyOperationTransient _perationTransient;
        private readonly IMyOperationScoped _perationScoped;
        private readonly IMyOperationSingleton _perationSingleton;

        public DiController(IMyOperationTransient perationTransient,
            IMyOperationScoped perationScoped,
            IMyOperationSingleton perationSingleton)
        {
            _perationTransient = perationTransient;
            _perationScoped = perationScoped;
            _perationSingleton = perationSingleton;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok( new
            {
                Transient = _perationTransient.GetOperationId(),
                Scoped = _perationScoped.GetOperationId(),
                Singleton = _perationSingleton.GetOperationId()
            });
        }
    }
}
