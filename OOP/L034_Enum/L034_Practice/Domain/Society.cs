using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L034_Practice.Domain
{
    public class Society
    {
        public List<Person> People { get; set; }

        public void FillPeople()
        {
            People = new List<Person>();
            var dataSeed = PersonInitialData.DataSeed;
            foreach (var data in dataSeed)
            {
                var person = new Person();
                person.Id = data.Id;
                person.FirstName = data.FirstName;
                person.LastName = data.LastName;
                person.Gender = data.Gender;
                person.Height = data.Height;
                person.Weight = data.Weight;
                person.BirthDate = data.BirthDate;
                People.Add(person);
            }
        }

        public List<Person> OldPeople
        {
            get
            {
                if (People == null) {
                    return null;
                }
                var oldPeople = new List<Person>();
                foreach (var person in People)
                {
                    if (person.BirthDate < new DateTime(2001, 01, 01))
                        oldPeople.Add(person);
                }
                return oldPeople;
            }
        }

        public List<Person> Men { get; set; } 

        public List<Person> Women { get; set; }

        public void FillMen()
        {
            Men = new List<Person>();
            var dataSeed = PersonInitialData.DataSeed;
            foreach (var data in dataSeed)
            {
                if (data.Gender == EGender.MALE)
                {
                    var person = new Person();
                    person.Id = data.Id;
                    person.FirstName = data.FirstName;
                    person.LastName = data.LastName;
                    person.Gender = data.Gender;
                    person.Height = data.Height;
                    person.Weight = data.Weight;
                    person.BirthDate = data.BirthDate;
                    Men.Add(person);
                }
            }
        }

        public void FillWomen()
        {
            Women = new List<Person>();
            var dataSeed = PersonInitialData.DataSeed;
            foreach (var data in dataSeed)
            {
                if (data.Gender == EGender.FEMALE)
                {
                    var person = new Person();
                    person.Id = data.Id;
                    person.FirstName = data.FirstName;
                    person.LastName = data.LastName;
                    person.Gender = data.Gender;
                    person.Height = data.Height;
                    person.Weight = data.Weight;
                    person.BirthDate = data.BirthDate;
                    Women.Add(person);
                }
            }
        }

        public void SortByAge()
        {
            Person tempPerson;
            for (int j = 0; j <= Men.Count; j++)
            {
                for (int i = 0; i <= Men.Count; i++)
                {
                    if (Men[i].Age > Men[i + 1].Age)
                    {
                        tempPerson= Men[i + 1];
                        Men[i + 1] = Men[i];
                        Men[i] = tempPerson;
                    }
                }

            }

        }
    }
}
