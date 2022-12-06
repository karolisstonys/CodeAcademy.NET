using L07_Api_Car.Models;
using L07_Api_Car.Models.Dto;
using L07_Api_Car.Models.Enums;
using L07_Api_Car.Repository;
using L07_Api_Car.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace L07_Api_Car.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarRepository _repo;
        private readonly ICarAdapter _adapter;

        public CarController(ILogger<CarController> logger, ICarRepository repo, ICarAdapter adapter)
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
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas pagal pateiktus filtrus
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<IEnumerable<GetCarResult>> Get([FromQuery]FilterCarRequest req)
        {
            _logger.LogInformation("Getting car list with parameters {req}", JsonConvert.SerializeObject(req));

            var cars = _repo.Find(c => c.Make.Contains(req.Make != null ? req.Make : "") &&
                                       c.Model.Contains(req.Model != null ? req.Model : "") /*&&
                                       c.GearBox.ToString().Contains(req.GearBox != null ? req.GearBox : "") &&
                                       c.Fuel.ToString().Contains(req.Fuel != null ? req.Fuel : "")*/);

            var carsResult = cars.Select(c => _adapter.Bind(c));
            return Ok(carsResult);
        }

        /// <summary>
        /// Irasomas automobilis i duomenu baze
        /// </summary>
        /// <returns>grazina kazka</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult<PostCarRequest> Post([FromBody]PostCarRequest req)
        {
            if (!Enum.TryParse(typeof(ECarGearBox), req.GearBox, out _))
            {
                var validValues = Enum.GetNames(typeof(ECarGearBox));
                ModelState.AddModelError(nameof(req.GearBox), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }

            if (!Enum.TryParse(typeof(ECarFuel), req.Fuel, out _))
            {
                var validValues = Enum.GetNames(typeof(ECarFuel));
                ModelState.AddModelError(nameof(req.Fuel), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var car = _adapter.Bind(req);
            var id = _repo.Create(car);

            return CreatedAtAction(nameof(Get), new { Id = id }, car);
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
