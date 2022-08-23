using L038_Practice.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Models
{
    public class Student : UniversityPerson
    {
        private Profession profession;

        public override Profession Profession 
        {
            get => profession;
            set 
            {
                if (value.Id == 10 || value.Id == 13 || value.Id == 16)
                    throw new Exception();
                profession = value;
            }
        }

        public List<Profession> Courses { get; set; }

        public Student() { }

        public Student(Random random) : base(random) { }

        public void SetUpto3Courses()
        {
            Courses = new List<Profession>();
            var coursesData = ProfessionInitialData.DataSeed.ToList();

            Profession teacher = new Profession(10);
            coursesData.Remove(teacher);
            Profession lecturer = new Profession(13);
            coursesData.Remove(lecturer);
            Profession scientist = new Profession(16);
            coursesData.Remove(scientist);

            int max = _random.Next(0, 4);
            for (int i = 0; i < max; i++)
            {
                var profession = new Profession();

                Profession selectedCourse = coursesData[_random.Next(0, coursesData.Count)];
                coursesData.Remove(selectedCourse);

                Courses.Add(selectedCourse);
            }
        }

        public override string GetCsv()
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

            for (int i = 0; i < 3; i++)
            {
                if (universityPerson.Courses.Count > i)
                    csv += universityPerson.Courses[i].Id.ToString() + ",";
                else
                    csv += ",";
            }

            return csv.Remove(csv.Length-1);
        }











    }
}
