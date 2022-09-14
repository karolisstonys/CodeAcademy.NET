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
                Console.WriteLine("\n1.Add new User\nq. Quit");

                char selector = Console.ReadKey().KeyChar;

                switch (selector)
                {
                    case '1':
                        Console.WriteLine();
                        Console.Write("Name: ");
                        var firstName = Console.ReadLine();
                        Console.Write("Surname: ");
                        var lastName = Console.ReadLine();
                        Console.Write("Age: ");
                        var age = Convert.ToInt32(Console.ReadLine());
                        _bloggingRepository.AddPerson(firstName, lastName, age);
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