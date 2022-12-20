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
        public async Task<ActionResult<double>> GetDeliveryPriceToEnteredCity([FromQuery] string city)
        {
            try
            {
                var deliveryCoordinates = await _deliveryService.GetCityLocation(city);
                if (deliveryCoordinates == "") {
                    _logger.LogInformation("City ({city}) entered by user not found!", city);
                    return NotFound(); 
                }

                var distanceInKm = await _deliveryService.GetDistanceForDelivery(deliveryCoordinates);


                return Ok(distanceInKm);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Ivyko kazkas blogo");
                throw;
            }


        }






    }
}
