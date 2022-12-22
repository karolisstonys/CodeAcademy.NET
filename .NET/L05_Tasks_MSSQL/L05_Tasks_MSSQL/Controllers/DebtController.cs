using L05_Tasks_MSSQL.Data;
using L05_Tasks_MSSQL.Helpers.IHelpers;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.DebtDto;
using L05_Tasks_MSSQL.Models.DTO.UserDto;
using L05_Tasks_MSSQL.Repository.IRepository;
using L05_Tasks_MSSQL.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DebtController : ControllerBase
    {
        private readonly BookStoreContext _db;
        private readonly IUserRepository _userRepo;
        private readonly ILibraryBookRepository _libraryBookRepo;
        private readonly IUserBookRepository _userBookRepo;
        private readonly IUserBookAdapter _adapter;
        private readonly IDebtHelper _debt;

        public DebtController(BookStoreContext db, 
                              IUserBookRepository userBookRepo, 
                              IUserBookAdapter adapter, 
                              ILibraryBookRepository libraryBookRepo, 
                              IUserRepository userRepo,
                              IDebtHelper debt)
        {
            _db = db;
            _userBookRepo = userBookRepo;
            _adapter = adapter;
            _libraryBookRepo = libraryBookRepo;
            _userRepo = userRepo;
            _debt = debt;
        }

        /// <summary>
        /// Paskaiciuoja visas skolas, atnaujina duombaze ir grazina skolininku sarasa 
        /// </summary>
        /// <returns></returns>
        [HttpGet("CalculateAllDebts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<UserDebtDto>> CalculateAllDebts()
        {
            return Ok(_debt.UpdateAndGetAllDebtForEveryone());
        }
    }
}
