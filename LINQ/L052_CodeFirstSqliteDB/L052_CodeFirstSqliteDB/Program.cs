using L052_CodeFirstSqliteDB.Infrastructure.Database;
using L052_CodeFirstSqliteDB.Infrastructure.Interfaces;

namespace L052_CodeFirstSqliteDB
{
    public class Program
    {

        private static IBloggingRepository _bloggingRepository = new BloggingRepository();

        static void Main(string[] args)
        {
            // Trys priejimai kaip galima aktyvuoti db naudojima kode:
            // 1. Database First
            // 2. Model First
            // 3. Code First

            Console.WriteLine("Hello, SQLite!");

            while (true)
            {
                Console.WriteLine("\n1.Add new user\n2. Print users\n3. Print users (Sorted by name)\nq. Quit");

                char selector = Console.ReadKey().KeyChar;

                switch (selector)
                {
                    case '1':
                        Console.WriteLine();
                        Console.Write("Name: ");
                        var firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        var lastName = Console.ReadLine();
                        Console.Write("Birth date: ");
                        var birthDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Email: ");
                        var email = Console.ReadLine();
                        Console.Write("Height: ");
                        var height = Convert.ToDouble(Console.ReadLine());
                        _bloggingRepository.AddPerson(firstName, lastName, birthDate, email, height);
                        break;
                    case '2':
                        Console.WriteLine();
                        _bloggingRepository.PrintAllPersons();
                        break;
                    case '3':
                        Console.WriteLine();
                        _bloggingRepository.PrintAllPersonsSorted();
                        break;
                    case 'q':
                        return;
                        break;
                    default:
                        Console.WriteLine("Input incorrect.");
                        break;
                }
            }









        }


    }




    

}