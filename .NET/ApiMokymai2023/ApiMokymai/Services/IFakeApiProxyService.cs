using ApiMokymai.Models.ApiModels;

namespace ApiMokymai.Services
{
    public interface IFakeApiProxyService
    {
        Task CreateBook(BookApiModel data);
        Task<IEnumerable<BookApiModel>> GetBooks();
    }
}
