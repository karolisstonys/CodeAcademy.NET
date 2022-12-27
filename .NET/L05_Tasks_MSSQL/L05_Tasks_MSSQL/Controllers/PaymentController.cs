using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IPaymentRepository _paymentRepo;
        private readonly IPaymentService _paymentService;

        public PaymentController(IUserRepository userRepo, IPaymentRepository paymentRepo, IPaymentService paymentService)
        {
            _userRepo = userRepo;
            _paymentRepo = paymentRepo;
            _paymentService = paymentService;
        }

        /// <summary>
        /// Parodo vartotojo sukauptus "Taškus"
        /// </summary>
        /// <param name="userId">Vartotojo id, kurio sukauptus "Taškus" norime gauti</param>
        /// <returns></returns>
        [HttpGet("GetUserPoints")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(long))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserPoints([FromQuery] int userId)
        {
            var getUserDto = _userRepo.Get(b => b.Id == userId);
            if (getUserDto == null) return NotFound("getUserDto = null");

            return Ok(getUserDto.Points);
        }

        /// <summary>
        /// Vartotojas susimoka skolą. Gali naudoti "Taškus".
        /// </summary>
        /// <param name="userId">Vartotojo id, kurio skola yra apmokama</param>
        /// <param name="amount">Suma kuri yra apmokama</param>
        /// <param name="pointsUsed">Pataudoti "Taškai". Jais galima apmokėti iki 99% skolos sumos.</param>
        /// <returns></returns>
        [HttpPut("PayUserDebt")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PayUserDebt([FromBody] int userId, double amount, long pointsUsed)
        {
            var getUserDto = _userRepo.Get(b => b.Id == userId);
            if (getUserDto == null) return NotFound("getUserDto == null");
            if (getUserDto.TotalDebt == 0) return NotFound("Vartotojas neturi skolos.");
            if (getUserDto.TotalDebt > amount) return NotFound("Mokama suma viršija skolą!");
            if (getUserDto.Points < pointsUsed) return NotFound("Vartotojas neturi tiek \"Taškų\"!");

            double amountPaidInPoints = _paymentService.CalculatePointsUsedInPayment(pointsUsed);
            if (amountPaidInPoints > amount) return NotFound("Naudojamų \"Taškų\" kiekis viršija apmokamą sumą!");

            getUserDto.Points -= pointsUsed;
            getUserDto.TotalDebt -= amount;
            await _userRepo.Update(getUserDto);

            var payment = new Payment()
            {
                UserId = getUserDto.UserId,
                Time = DateTime.UtcNow,
                Amount = amount,
                PointsUsed = pointsUsed
            };

            _paymentRepo.Create(payment); // NEED await → NEED fix async in GENERIC REPO

            return NoContent();
        }


    }
}
