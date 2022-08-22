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
            Hobbies = new List<Hobby>();
        }

        Profession Profession { get; set; }

        public List<Hobby> Hobbies { get; set; }

        public void SetUpto4Hobies()
        {
            var hobbyData = HobbyInitialData.DataSeedCsv.ToList();

            Random rnd = new Random();
            int numberOfHobbies = rnd.Next(0, 5);

            for (int i = 0; i <= numberOfHobbies; i++)
            {
                var hobby = new Hobby();

                string selectedHobby = hobbyData[rnd.Next(hobbyData.Count)];
                hobbyData.Remove(selectedHobby);
                
                hobby.HobbyExtractor(selectedHobby);
                Hobbies.Add(hobby);
            }
        }

    }
}
