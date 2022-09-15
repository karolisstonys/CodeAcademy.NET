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
        public BloggingRepository()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }
        public void AddPerson(Person person)
        {
            using var context = new BloggingContext();

            context.Persons.Add(person);

            context.SaveChanges();
        }

        public void AddPerson(string firstName, string lastName, DateTime birthDate, string email, double height)
        {
            using var context = new BloggingContext();

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

        public void AddAnimal(Animal animal)
        {
            using var context = new BloggingContext();

            context.Animals.Add(animal);

            context.SaveChanges();
        }

        public void AddAnimal(string name, string type, DateTime birthDate)
        {
            using var context = new BloggingContext();

            var animal = new Animal()
            {
                Name = name,
                Type = type,
                BirthDate = birthDate
            };

            context.Animals.Add(animal);

            context.SaveChanges();
        }
        public void PrintAllAnimals()
        {
            using var context = new BloggingContext();

            var animals = context.Animals;

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId} {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }

        public void PrintAllAnimalsByType(string type)
        {
            using var context = new BloggingContext();

            var animals = context.Animals.Where(a => a.Type == type);

            Console.WriteLine($"All {type} animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId} {animal.Name} {animal.BirthDate}");
            }
        }

        public void PrintAllAnimalsSorted()
        {
            using var context = new BloggingContext();

            var animals = context.Animals
                .OrderBy(a => a.Name);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId} {animal.Name} {animal.Type} {animal.BirthDate}");
            }
        }

    }
}
