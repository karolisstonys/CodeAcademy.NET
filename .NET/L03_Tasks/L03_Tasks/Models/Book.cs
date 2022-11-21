﻿namespace L03_Tasks.Models
{
    public class Book
    {
        public Book() { }

        public Book(int id, string title, string author, ECoverType coverType, int publishYear)
        {
            Id = id;
            Title = title;
            Author = author;
            ECoverType = coverType;
            PublishYear = publishYear;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ECoverType ECoverType { get; set; }
        public int PublishYear { get; set; }

    }
}
