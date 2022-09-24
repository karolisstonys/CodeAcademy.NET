using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Domain.Models
{
    // CodeFirst approache - Klase yra lentele
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        // PirmaryKey - pirminis raktas
        // Pirminis raktas yra visada unikalus
        // Reliacines duombazes (Relationships between tables)

        /*
         Uzduotis 1:
            Atnaujinkit Person, kad turetu Weight(double), Biography(string:nullable) atributus  (Nauja migracija turetu tureti tik siuos atnaujinimus). Sukurkite nauja klase Animal, kuri turetu AnimalId(Primary Key), Name, Type, BirthDate atributus. Pridekit animal i DbContext ir sukurkite nauja migracija.

        Uzduotis 2:
            Sukurkite metodus, kurie leistu prideti nauja gyvuna+, atspausdintu visus gyvunus+, isgautu gyvunus kurie yra paduoto tipo+, atspausdintu visus gyvunus surikiuotus pagal varda. Pridekite sias funkcijas I main programos pasirinkimu menu.

         */
        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public int Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public double? Height { get; set; }
        public double Weight { get; set; } = 0;
        public string? Biography { get; set; }
    }
}
