using L042_Practice.Enums;
using L042_Practice.Models.Abstract;

namespace L042_Practice.Interfaces
{
    public interface IBookHtmlService
    {
        public Dictionary<BookType, List<Book>> Decode(string dataSeed);

        public string Encode(Dictionary<BookType, List<Book>> books);
    }
}
