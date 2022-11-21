﻿using L03_Tasks.Data;
using L03_Tasks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace L03_Tasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookSet _mySet;

        public BookController(IBookSet mySet)
        {
            _mySet = mySet;
        }

        [HttpGet("all")]
        public List<Book> GetAllBooks()
        {
            return _mySet.Books;
        }

        [HttpGet("{id}")]
        public Book? GetBookById(int id)
        {
            return _mySet.Books.Where(b => b.Id == id).FirstOrDefault();
        }
    }
}
