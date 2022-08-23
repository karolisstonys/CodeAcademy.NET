using P038_Praktika.InitalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Models
{
    public class UniversityPerson : Person
    {
        public UniversityPerson()
        {
            _random = new Random();
        }

        public UniversityPerson(Random random)
        {
            _random = random;
        }

        public Profession Profession { get; set; }

        private Random _random;

        public List<Hobby> Hobbies { get; set; }

        public void SetUpto4Hobies()
        {
            Hobbies = new List<Hobby>();
            var hobbyData = HobbyInitialData.DataSeedCsv.ToList();

            int a = _random.Next(0, 5);
            for (int i = 0; i < a; i++)
            {
                var hobby = new Hobby();

                string selectedHobby = hobbyData[_random.Next(0, hobbyData.Count)];
                hobbyData.Remove(selectedHobby);
                
                hobby.HobbyExtractor(selectedHobby);
                Hobbies.Add(hobby);
            }
        }

        public void SetProfession(Profession[] dataSeed)
        {
            Profession = new Profession();
            Profession = dataSeed[_random.Next(0, dataSeed.Length)];
        }

        public void SetProfession(string[] dataSeedCsv, string splitSymbol)
        {
            Profession = new Profession();
            string dataSeedLine = dataSeedCsv[_random.Next(0, dataSeedCsv.Length)];

            var arr = dataSeedLine.Split(splitSymbol);
            if (arr.Length != 3)
                return;
            if (!int.TryParse(arr[0], out int intId))
                return;

            Profession.Id = intId;
            Profession.Text = arr[1];
            Profession.TextLt = arr[2];
        }

        public string GetCsv()
        {
            var universityPerson = this;
            string csv = "";

            csv += universityPerson.Id.ToString() + ",";
            csv += universityPerson.FirstName.ToString() + ",";
            csv += universityPerson.LastName.ToString() + ",";
            csv += universityPerson.Gender.ToString() + ",";
            csv += universityPerson.BirthDate.ToString() + ",";
            csv += universityPerson.Height.ToString() + ",";
            csv += universityPerson.Weight.ToString() + ",";
            csv += universityPerson.Profession.Id.ToString() + ",";

            for (int i = 0; i < 4; i++)
            {
                if (universityPerson.Hobbies.Count > i)
                    csv += universityPerson.Hobbies[i].Id.ToString() + ",";
                else
                    csv += ",";
            }
            return csv.Remove(csv.Length-1);
        }
    }
}
