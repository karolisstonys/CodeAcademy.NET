using System.ComponentModel.DataAnnotations;

namespace L052_CodeFirstSqliteDB.Domain.Models
{
    public class Animal
    {
        public Animal() { }

        public Animal(string name, string type, DateTime birthDate)
        {
            Name = name;
            Type = type;
            BirthDate = birthDate;
        }

        // PrimaryKey
        [Key]
        public int AnimalId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
