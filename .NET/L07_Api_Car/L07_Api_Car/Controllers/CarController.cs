using L07_Api_Car.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace L07_Api_Car.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger=logger;
        }


        /// <summary>
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCarResult))]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<GetCarResult> Get(int id)
        {
            return Ok(new GetCarResult());
        }


        /// <summary>
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<IEnumerable<GetCarResult>> Get()
        {   

            return Ok(new List<GetCarResult>());
        }

        /// <summary>
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas pagal pateiktus filtrus
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<IEnumerable<GetCarResult>> Get([FromQuery]FilterCarRequest req)
        {
            return Ok(new List<GetCarResult>());
        }


        /// <summary>
        /// Irasomas automobilis i duomenu baze
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult<PostCarRequest> Post([FromBody]PostCarRequest req)
        {
            return CreatedAtAction(nameof(Get), new { id = 0 }, new PostCarRequest());
        }


        /// <summary>
        /// Modifikuojamas automobilis duomenu baze
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult Put([FromBody] PutCarRequest req)
        {
            return NoContent();
        }

        /// <summary>
        /// Modifikuojamas automobilis duomenu baze
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }




    }
}
