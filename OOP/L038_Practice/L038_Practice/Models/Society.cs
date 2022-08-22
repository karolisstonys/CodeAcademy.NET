using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Domain
{
    public class Society
    {
        public List<Person> People { get; set; } = new List<Person>();

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
                if (People == null)
                    return null;

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
            FillFromDataSeed(Men, EGender.MALE);
        }

        public void FillWomen()
        {
            Women = new List<Person>();
            FillFromDataSeed(Women, EGender.FEMALE);
        }

        public void FillFromDataSeed(List<Person> list, EGender gender)
        {
            var dataSeed = PersonInitialData.DataSeed;
            foreach (var data in dataSeed)
            {
                if (data.Gender == gender)
                {
                    var person = new Person();
                    person.Id = data.Id;
                    person.FirstName = data.FirstName;
                    person.LastName = data.LastName;
                    person.Gender = data.Gender;
                    person.Height = data.Height;
                    person.Weight = data.Weight;
                    person.BirthDate = data.BirthDate;
                    list.Add(person);
                }
            }
        }

        public void SortByAge()
        {
            SortByAge(Men);
            SortByAge(Women);
        }

        public void SortByAge(List<Person> list)
        {
            Person tempPerson;
            for (int j = 0; j <= list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].BirthDate < list[i + 1].BirthDate)
                    {
                        tempPerson = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = tempPerson;
                    }
                }
            }
        }

        public void SortByFirstName(ESortType sortType)
        {
            SortByFirstName(People, sortType);
            SortByFirstName(Men, sortType);
            SortByFirstName(Women, sortType);
        }

        public void SortByLastName(ESortType sortType)
        {
            SortByLastName(People, sortType);
            SortByLastName(Men, sortType);
            SortByLastName(Women, sortType);
        }

        public void SortByFirstName(List<Person> list, ESortType sortType)
        {
            Person tempPerson;
            for (int j = 0; j <= list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].FirstName[0] > list[i + 1].FirstName[0])
                    {
                        tempPerson = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = tempPerson;
                    }
                }
            }
        }

        private void SortByLastName(List<Person> list, ESortType sortType)
        {
            Person tempPerson;
            for (int j = 0; j <= list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].LastName[0] > list[i + 1].LastName[0])
                    {
                        tempPerson = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = tempPerson;
                    }
                }
            }
        }

        public enum ESortType { Asc, Desc }

    }
}
