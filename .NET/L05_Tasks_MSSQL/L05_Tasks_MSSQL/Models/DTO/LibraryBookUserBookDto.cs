﻿namespace L05_Tasks_MSSQL.Models.DTO
{
    public class LibraryBookUserBookDto
    {
        public string Name { get; set; }
        public DateTime BookTaken { get; set; }
        public DateTime? BookReturned { get; set; }

    }
}
