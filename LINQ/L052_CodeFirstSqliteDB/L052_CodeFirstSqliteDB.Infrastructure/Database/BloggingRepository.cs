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

        public void AddPerson(string firstName, string lastName, DateTime birthDate, string email, double height)
        {
            using var context = new BloggingContext();

            context.Database.EnsureCreated();

            var person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Email = email,
                Height = height,
            };

            context.Persons.Add(person);

            context.SaveChanges();
        }

        public void PrintAllPersons()
        {
            using var context = new BloggingContext();

            var persons = context.Persons;

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId} {person.FirstName} {person.LastName} {person.BirthDate} {person.Email} {person.Height}");
            }
        }

        public void PrintAllPersonsSorted()
        {
            using var context = new BloggingContext();

            var persons = context.Persons
                .OrderBy(person => person.FirstName);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId} {person.FirstName} {person.LastName} {person.BirthDate} {person.Email} {person.Height}");
            }
        }
    }
}
