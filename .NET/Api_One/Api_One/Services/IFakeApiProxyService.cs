using Api_One.Models.ApiModels;

namespace Api_One.Services
{
    public interface IFakeApiProxyService
    {
        Task<IEnumerable<BookApiResult>> GetBooks();
    }
}
