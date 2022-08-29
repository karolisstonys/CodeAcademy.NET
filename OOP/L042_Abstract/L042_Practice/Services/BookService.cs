using L042_Practice.Enums;
using L042_Practice.Interfaces;
using L042_Practice.Models.Abstract;

namespace L042_Practice.Services
{
    public class BookService : IBookHtmlService
    {
        public Dictionary<BookType, List<Book>> Decode(string dataSeed)
        {
            var dict = new Dictionary<BookType, List<Book>>();
            dict.Add(BookType.AudioBook, new List<Book>());
            dict.Add(BookType.Ebook, new List<Book>());
            dict.Add(BookType.HardCoverBook, new List<Book>());
            dict.Add(BookType.PaperBackBook, new List<Book>());

            string[] bookDataSeed = dataSeed.Split("<tr>");
            int i = -1;

            foreach (var data in bookDataSeed)
            {
                i++;
                if (i <= 2) continue;
                data.Trim();

                //Console.Write($"{data}");

                string[] lines = data.Split("<td>");

                int j = -1;
                foreach (var line in lines)
                {
                    j++;
                    if (j <= 0) continue;

                    int index = line.IndexOf("</td>");
                    string newLine = line.Substring(0, index);

                    Console.WriteLine($"{newLine}");

                }


            }


            return null;
        }

        public string Encode(Dictionary<BookType, List<Book>> books)
        {
            throw new NotImplementedException();
        }
    }
}
