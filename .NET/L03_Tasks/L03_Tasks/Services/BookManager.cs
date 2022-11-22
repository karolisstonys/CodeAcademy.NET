using L03_Tasks.Data;
using L03_Tasks.Models.DTO;

namespace L03_Tasks.Services
{
    public class BookManager : IBookManager
    {
        private readonly IBookSet _context;
        private readonly IBookWrapper _wrapper;

        public BookManager (IBookSet bookSet, IBookWrapper bookWrapper)
        {
            _context = bookSet;
            _wrapper = bookWrapper;
        }

        public List<GetBookDto> Get()
        {
            var listGetBookDto = new List<GetBookDto>();
            foreach(var book in _context.Books)
            {
                listGetBookDto.Add(_wrapper.Bind(book));
            }
            return listGetBookDto;
        }

        public GetBookDto Get(int id) => Exists(id) ? _wrapper.Bind(_context.Books.Where(b => b.Id == id).FirstOrDefault()) : throw new Exception();

        public bool Exists(int id) =>  _context.Books.Where(b => b.Id == id).Any() ? true : false;

        public List<GetBookDto> Filter(Dictionary<string, string> filter)
        {
            throw new NotImplementedException();
        }

        public int Add(CreateBookDto book)
        {
            int maxBookSetId = _context.Books.Max(b => b.Id);
            _context.Books.Add(_wrapper.Bind(book));
            return maxBookSetId + 1;
        }

        public void Update(UpdateBookDto book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            if (Exists(id))
                _context.Books.Remove(_context.Books.Where(b => b.Id == id).FirstOrDefault());
        }


    }
}
