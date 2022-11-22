using L03_Tasks.Models;
using L03_Tasks.Models.DTO;

namespace L03_Tasks.Services
{
    public interface IBookWrapper
    {
        GetBookDto Bind(Book book);

        Book Bind(CreateBookDto book);

        Book Bind(UpdateBookDto book);
    }
}
