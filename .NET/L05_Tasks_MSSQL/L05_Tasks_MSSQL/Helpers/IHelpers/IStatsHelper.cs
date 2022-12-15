using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.UserStatsDto;

namespace L05_Tasks_MSSQL.Helpers.IHelpers
{
    public interface IStatsHelper
    {
        public List<FavoriteAuthorDto> GetFavoriteAutorsForUser(int id, List<UserBook> allBooks);
    }
}
