using L07_Api_Car.Models;
using L07_Api_Car.Models.Dto;
using L07_Api_Car.Repository;
using L07_Api_Car.Services;
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
        private readonly IRepository<Car> _repo;
        private readonly ICarAdapter _adapter;

        public CarController(ILogger<CarController> logger, IRepository<Car> repo, ICarAdapter adapter)
        {
            _logger = logger;
            _repo = repo;
            _adapter = adapter;
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
            if (!_repo.Exists(id)) return NotFound();
            var car = _repo.Get(id);
            var carResult = _adapter.Bind(car);
            return Ok(carResult);
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
            var cars = _repo.All();
            var carsResult = cars.Select(c => _adapter.Bind(c));
            return Ok(carsResult);
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
            var cars = _repo.Find(c => c.Make.Contains(req.Make != null ? req.Make : "") &&
                                       c.Model.Contains(req.Model != null ? req.Model : "") &&
                                       c.GearBox.ToString() == (req.GearBox != null ? req.GearBox : "") &&
                                       c.Fuel.ToString() == (req.Fuel != null ? req.Fuel : ""));

            return Ok(cars);
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
