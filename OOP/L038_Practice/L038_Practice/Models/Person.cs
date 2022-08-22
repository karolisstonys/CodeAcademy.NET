using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice
{
    public class Person
    {
        public int Id { get; set; }

        private string firstName = "";
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NameChanges();
            }
        }

        private string lastName = "";
        public string LastName { 
            get { return lastName; }
            set 
            { 
                lastName = value;
                NameChanges();
            }
        }

        public string? nameChanges;

        public string FullName => FirstName + " " + LastName;

        public EGender Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public int? Age { 
            get
            {
                return GetAge();
            }
        }

        public Person()
        {

        }

        public Person(string firstName, string lastName, EGender gender, decimal height, decimal weight)
        {
            FirstName=firstName;
            LastName=lastName;
            Gender=gender;
            Height=height;
            Weight=weight;
        }

        public void ChangeGender(EGender gender)
        {
            Gender = gender;
        }

        private int? GetAge()
        {
            if (BirthDate == null)
                return null;
            return DateTime.Now.Year - BirthDate.Value.Year;
        }

        public string NameChanges()
        {
            nameChanges += FirstName + " " + LastName + ", ";
            return nameChanges;
        }


    }
}
