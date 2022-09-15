using L052_CodeFirstSqliteDB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L052_CodeFirstSqliteDB.Infrastructure.Interfaces
{
    public interface IBloggingRepository
    {
        void AddPerson(Person person);

        void AddPerson(string firstName, string lastName, DateTime birthDate, string email, double height);

        public void PrintAllPersons();

        public void PrintAllPersonsSorted();

        void AddAnimal(Animal animal);

        void AddAnimal(string name, string type, DateTime birthDate);

        public void PrintAllAnimals();

        public void PrintAllAnimalsByType(string type);

        public void PrintAllAnimalsSorted();
    }
}
