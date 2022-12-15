using L05_Tasks_MSSQL.Helpers.IHelpers;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.UserStatsDto;
using L05_Tasks_MSSQL.Repository;
using L05_Tasks_MSSQL.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L05_Tasks_MSSQL.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserStatsController : ControllerBase
    {
        private readonly IUserBookRepository _userBookRepo;
        private readonly IStatsHelper _statsHelper;

        public UserStatsController(IUserBookRepository userBookRepo, IStatsHelper statsHelper)
        {
            _userBookRepo = userBookRepo;
            _statsHelper = statsHelper;
        }

        [HttpGet("FavoriteAuthors")] // 
        public ActionResult<IOrderedEnumerable<IGrouping<string, UserBook>>?> /*ActionResult<List<FavoriteAuthorDto>>*/ GetFavoriteAutors(int id)
        {
            var userBooks = _userBookRepo.GetAll(ub => ub.UserId == id);
            var favoriteAuthors = _statsHelper.GetFavoriteAutorsForUser(id, userBooks);
            return Ok(favoriteAuthors);
        }

    }
}
