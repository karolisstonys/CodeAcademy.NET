﻿namespace L05_Tasks_MSSQL.Models
{
    public class Author
    {
        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
