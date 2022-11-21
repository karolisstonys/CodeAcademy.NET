using L03_Tasks.Models;

namespace L03_Tasks.Data
{
    public interface IBookSet
    {
        List<Book> Books { get; set; }
    }
}