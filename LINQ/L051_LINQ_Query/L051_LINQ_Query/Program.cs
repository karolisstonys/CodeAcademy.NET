using L051_LINQ_Query.Models;

namespace L051_LINQ_Query
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ Query!");

            List<Person> students = new List<Person>
            {
                new Person { Id = 1, Name = "Jonas", Age = 30, ProfessionId = 1 },
                new Person { Id = 1, Name = "Petras", Age = 51, ProfessionId = 2 },
                new Person { Id = 1, Name = "Aluizas", Age = 22, ProfessionId = 1 },
                new Person { Id = 1, Name = "Antanas", Age = 19, ProfessionId = 4 },
                new Person { Id = 1, Name = "Daiva", Age = 26, ProfessionId = 2 },
                new Person { Id = 1, Name = "Rasa", Age = 33, ProfessionId = 3 },
                new Person { Id = 1, Name = "Agne", Age = 18, ProfessionId = 1 },
            };

            List<Profession> profesions = new List<Profession>
            {
                new Profession { ProfessionId = 1, TextLt = "Mokytojas"},
                new Profession { ProfessionId = 2, TextLt = "Vairuotojas"},
                new Profession { ProfessionId = 3, TextLt = "Daktaras"},
                new Profession { ProfessionId = 4, TextLt = "Programuotojas"},
            };

            List<Hobby> hobbies = new List<Hobby>
            {
                new Hobby { HobbyId = 1, TextLt = "Daile"},
                new Hobby { HobbyId = 1, TextLt = "Muzika"},
                new Hobby { HobbyId = 1, TextLt = "Sokis"},
                new Hobby { HobbyId = 1, TextLt = "Programavimas"},
            };


            // filtruojame studentus kuriems yra maziau nei 20 metu
            var jauniStudentai = from s in students
                                 where s.Age < 20
                                 select s;



            var surikiuotiStudentai = from s in students
                                      orderby s.Age
                                      select s;



            var evenNumbersFromList = Task1(new List<int> { 0,1,2,3,4,5,6,7,8,9 });
            
            foreach (var number in evenNumbersFromList)
            {
                Console.Write(number + " ");
            }


        }

        public static IEnumerable<int> Task1(List<int> list)
        {
             var evenNumbersFromList = from l in list
                                      where l % 2 == 0
                                      select l;
            return evenNumbersFromList;
        }


        public static List<int> Task2(List<int> list)
        {
            var possitiveNumbersFromList = from l in list
                                      where l > 0
                                      select l;
            return possitiveNumbersFromList.ToList();
        }

        public static List<int> Task3(List<int> list)
        {
            var possitiveNumbersFromList = from l in list
                                           select l * l;
            return possitiveNumbersFromList.ToList();
        }

        public static List<int> Task4(List<int> list)
        {
            var possitiveNumbersFromList = from l in list
                                           select l;
            return possitiveNumbersFromList.ToList();
        }

    }
}