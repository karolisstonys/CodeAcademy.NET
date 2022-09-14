using L052_CodeFirstSqliteDB.Domain.Models;
using L052_CodeFirstSqliteDB.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L052_CodeFirstSqliteDB.Infrastructure.Database
{
    public class BloggingRepository : IBloggingRepository
    {
        public void AddPerson(Person person)
        {
            using var context = new BloggingContext();

            context.Database.EnsureCreated();

            context.Persons.Add(person);

            context.SaveChanges();
        }

        public void AddPerson(string firstName, string lastName, int age)
        {
            using var context = new BloggingContext();

            context.Database.EnsureCreated();

            var person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };

            context.Persons.Add(person);

            context.SaveChanges();
        }
    }
}
