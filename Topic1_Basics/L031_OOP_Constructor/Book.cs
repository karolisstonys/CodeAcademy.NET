using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L031_OOP_Constructor
{


    public class Book
    {
        public Book()
        {
            Name = "unknown name";
            Author = "unknown author";
            Genre = "unknown genre";
        }


        public Book(string name, string author, string genre,int pageCount, Release release)
        {
            Name = name;
            Author = author;
            Genre = genre;
            PageCount = pageCount;
            Release = release;
        }

        public Book(Book book) 
        { 
            Name = book.Name;
            Author = book.Author;
            Genre = book.Genre;
            PageCount = book.PageCount;
            Release = book.Release;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private int pageCount;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        private Release release;

        public Release Release
        {
            get { return release; }
            set { release = value; }
        }


    }
}
