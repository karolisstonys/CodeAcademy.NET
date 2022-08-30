﻿using L042_Practice.Enums;
using L042_Practice.Interfaces;
using L042_Practice.Models.Abstract;
using L042_Practice.Models.Concrete;

namespace L042_Practice.Services
{
    public class BookService : IBookHtmlService
    {
        public Dictionary<BookType, List<Book>> Decode(string dataSeed)
        {
            throw new NotImplementedException();
            Dictionary<BookType, List<Book>> res = new Dictionary<BookType, List<Book>>();
            res.Add(BookType.Ebook, new List<Book>());
            res.Add(BookType.AudioBook, new List<Book>());
            res.Add(BookType.HardCoverBook, new List<Book>());
            res.Add(BookType.PaperBackBook, new List<Book>());

            string[] arr = dataSeed.Split("<tbody>");
            if (arr.Length < 2)
                return res;

            string[] rows = arr[1]
                .Replace("</tbody>", "")
                .Replace("</table>", "")
                .Replace("</table>", "")
                .Replace(Environment.NewLine, "")
                .Replace("</html>", "")
                .Replace("</td>", "")
                .Replace("</tr>", "")
                .Split("<tr>");

            foreach (var row in rows)
            {
                string[] cells = row.Split("<td>");
                if (cells.Length < 9)
                    continue;
                string genre = cells[1].Trim();
                string title = cells[2].Trim();
                string author = cells[3].Trim();
                int booksSold = GetBookSold(cells[4].Trim().Replace(".", ","));
                _ = int.TryParse(cells[5].Trim(), out int qtty);

                var ebookPrice = GetPrice(cells[6].Trim().Replace(".", ","));
                var audioPrice = GetPrice(cells[7].Trim().Replace(".", ","));
                var hardcoverPrice = GetPrice(cells[8].Trim().Replace(".", ","));
                var paperbackPrice = GetPrice(cells[9].Trim().Replace(".", ","));

                if (ebookPrice != null)
                {
                    res[BookType.Ebook].Add(new EBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = ebookPrice
                    });
                }
                if (audioPrice != null)
                {
                    res[BookType.AudioBook].Add(new AudioBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = audioPrice
                    });
                }
                if (hardcoverPrice != null)
                {
                    res[BookType.HardCoverBook].Add(new HardCoverBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = hardcoverPrice
                    });
                }
                if (paperbackPrice != null)
                {
                    res[BookType.PaperBackBook].Add(new PaperBackBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = paperbackPrice
                    });
                }

            }


            return res;


        }

        private double? GetPrice(string v)
        {
            if (v.Contains("$"))
                return double.Parse(v.Replace("$", "")) * 0.95;
            else if (v.Contains("PLN"))
                return double.Parse(v.Replace(" PLN", "")) * 0.21;
            else if (v.Contains("EUR"))
                return double.Parse(v.Replace(" EUR", ""));
            else
                return null;
        }

        private int GetBookSold(string v)
        {
            if (v.Contains("million"))
                return (int)(double.Parse(v.Replace(" million", "")) * 1000000);
            if (v.Contains("billion"))
                return (int)(double.Parse(v.Replace(" billion", "")) * 1000000000);

            _ = int.TryParse(v, out int bs);
            return bs;
        }

        public string Encode(List<Book> books)
        {
            List<BookHtml> res = new List<BookHtml>();
            books.Sort((x, y) => x.Title.CompareTo(y.Title));
            string lastTitle = "";
            foreach (var book in books)
            {
                if (lastTitle != book.Title)
                {
                    res.Add(new BookHtml());
                }
                
                //book.SetDataTo(res[res.Count - 1]);
                lastTitle = book.Title;
            }

            //return res.ToHtml();
            return "";
        }

    }
}
