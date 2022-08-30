using L042_Practice.Enums;
using L042_Practice.Models.Abstract;

namespace L042_Practice.Interfaces
{
    public interface IBookHtmlService
    {
        Dictionary<BookType, List<Book>> Decode(string dataSeed);
        string Encode(List<Book> books);
    }
}
