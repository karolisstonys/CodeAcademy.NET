using L05_Tasks_MSSQL.Helpers.IHelpers;
using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO.UserStatsDto;

namespace L05_Tasks_MSSQL.Helpers
{
    public class StatsHelper : IStatsHelper
    {
        public List<FavoriteAuthorDto> GetFavoriteAutorsForUser(int id, List<UserBook> allBooks)
        {
            var favoriteAuthors = new List<FavoriteAuthorDto>();

            var groupByLastNamesQuery = from book in allBooks
                                        group book by book.LibraryBook.Book.Author into newBookGroup
                                        orderby newBookGroup.Key
                                        select newBookGroup;








            return favoriteAuthors;
        }
    }
}
