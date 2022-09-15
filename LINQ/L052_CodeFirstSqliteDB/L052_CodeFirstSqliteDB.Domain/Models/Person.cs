using System.ComponentModel.DataAnnotations;

namespace L052_CodeFirstSqliteDB.Domain.Models
{
    public class Person    // Code First approache - Klase yra lentele
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime birthDate, string email, double height)
        {
            FirstName=firstName;
            LastName=lastName;
            BirthDate=birthDate;
            Email=email;
            Height=height;
        }


        // PrimaryKey
        [Key]
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public double Height { get; set; }



        public double Weight { get; set; } = 0;

        public string? Biography { get; set; }

    }
}
