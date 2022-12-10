﻿using L05_Tasks_MSSQL.Models;
using L05_Tasks_MSSQL.Models.DTO;
using L05_Tasks_MSSQL.Models.Enums;
using L05_Tasks_MSSQL.Services.IServices;

namespace L05_Tasks_MSSQL.Services
{

    public class BookWrapper : IBookWrapper
    {
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto
            {
                ISBN = book.ISBN,
                LeidybosMetai = book.PublishYear,
                PavadinimasIrAutorius = book.Title + " " + book.Author
            };
        }

        public Book Bind(CreateBookDto book)
        {
            return new Book
            {
                ISBN = book.ISBN,
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
        }

        public Book Bind(UpdateBookDto book)
        {
            return new Book
            {
                ISBN = book.ISBN,
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas)
            };
        }


    }
}
