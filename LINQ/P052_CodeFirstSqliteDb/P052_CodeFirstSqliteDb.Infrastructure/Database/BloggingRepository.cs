using P052_CodeFirstSqliteDb.Domain.Models;
using P052_CodeFirstSqliteDb.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Infrastructure.Database
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

        public void AddPerson(string firstName, string lastName, DateTime birthDate)
        {
            using var context = new BloggingContext();

            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };

            context.Persons.Add(person);
            context.SaveChanges();
        }

        public void PrintAllPersons()
        {
            using var context = new BloggingContext();

            var persons = context.Persons;

            foreach(var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.LastName}");
            }
        }

        public void PrintAllPersonsSorted()
        {
            using var context = new BloggingContext();

            var persons = context.Persons
                .OrderBy(p => p.FirstName);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.LastName}");
            }
        }

        public void AddAnimal(Animal animal)
        {
            using var context = new BloggingContext();
            // Sitoje vietoje duombaze dar neturi naujo iraso
            context.Animals.Add(animal);
            // Irasas atsiranda po to kada buna iskvieciama SaveChanges()
            context.SaveChanges();
        }

        public void PrintAllAnimals()
        {
            using var context = new BloggingContext();

            var animals = context.Animals;

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId}. {animal.Name} {animal.Type}");
            }
        }

        public List<Animal> FetchAnimalsOfType(string type)
        {
            using var context = new BloggingContext();

            var animals = context.Animals
                .Where(a => a.Type == type)
                .ToList();
            var animalsQuerySyntax = (from animal in animals
                                      where animal.Type == type
                                      select animal)
                                      .ToList();

            return animals;
        }

        public void PrintAllAnimalsSorted()
        {
            using var context = new BloggingContext();

            var animals = context.Animals
                .OrderBy(p => p.Name);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.AnimalId}. {animal.Name} {animal.Type}");
            }
        }
    }
}
