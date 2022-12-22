using L05_Tasks_MSSQL.Models.DTO.Delivery;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;
        private readonly ILogger<DeliveryController> _logger;

        public DeliveryController(IDeliveryService deliveryService, ILogger<DeliveryController> logger)
        {
            _deliveryService = deliveryService;
            _logger = logger;
        }

        /// <summary>
        /// Count how much it will cost to deliver to your desired city.
        /// </summary>
        /// <param name="city">City name you want to deliver to</param>
        /// <returns></returns>
        [HttpGet("GetDeliveryPrice")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DeliveryDataDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<DeliveryDataDto>> GetDeliveryPriceToEnteredCity([FromQuery] string city)
        {
            try
            {
                var deliveryCoordinates = await _deliveryService.GetCityLocation(city);
                if (deliveryCoordinates == "") {
                    _logger.LogWarning("Miesto pavadinimu - {0}, rasti nepavyko!", city);
                    return NotFound($"Miesto pavadinimu - {city}, rasti nepavyko!"); 
                }

                var distanceInKm = await _deliveryService.GetDistanceForDelivery(deliveryCoordinates);
                if (distanceInKm == null)
                {
                    _logger.LogWarning("Nepavyko apskaičiuoti atstumo iki koordinačių - {0}", deliveryCoordinates);
                    return NotFound($"Nepavyko apskaičiuoti atstumo iki koordinačių - {deliveryCoordinates}");
                }

                var deliveryPrice = _deliveryService.CalculateDeliveryPrice(distanceInKm);
                if (deliveryPrice == null)
                {
                    _logger.LogWarning("Del atstumo ({0}km) iki pasirinkto miesto, pristatymas negalimas", distanceInKm);
                    return Ok($"Viršytas maksimalus pristatymo atstumas. Iki pasirinkto miesto yra {distanceInKm}km.");
                }

                DeliveryDataDto deliveryDataDto = _deliveryService.BuildDeliveryInfo(city, deliveryCoordinates, distanceInKm, deliveryPrice);
                if (deliveryDataDto == null)
                {
                    _logger.LogWarning("DeliveryDto sukurti nepavyko");
                    return NotFound("DeliveryDto sukurti nepavyko");
                }

                return Ok(deliveryDataDto);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ivyko kazkas blogo");
                throw;
            }
        }
    }
}
