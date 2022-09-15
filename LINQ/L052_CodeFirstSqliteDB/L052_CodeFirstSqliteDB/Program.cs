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
                Console.WriteLine("\n1. Add new user\n2. Print users\n3. Print users (Sorted by name)");
                Console.WriteLine("\n4. Add new animal\n5. Print animals\n6. Print animals by type\n7. Print animals (Sorted by name)");
                Console.WriteLine("\nq. Quit");

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
                    case '4':
                        Console.WriteLine();
                        Console.Write("Name: ");
                        var animalName = Console.ReadLine();
                        Console.Write("Type: ");
                        var animalType = Console.ReadLine();
                        Console.Write("Birth date: ");
                        var animalBirthDate = Convert.ToDateTime(Console.ReadLine());
                        _bloggingRepository.AddAnimal(animalName, animalType, animalBirthDate);
                        break;
                    case '5':
                        Console.WriteLine();
                        _bloggingRepository.PrintAllAnimals();
                        break;
                    case '6':
                        Console.WriteLine();
                        Console.Write("Name: ");
                        var animalTypeToFind = Console.ReadLine();
                        _bloggingRepository.PrintAllAnimalsByType(animalTypeToFind);
                        break;
                    case '7':
                        Console.WriteLine();
                        _bloggingRepository.PrintAllAnimalsSorted();
                        break;
                    case 'q':
                        return;
                        break;
                    default:
                        Console.WriteLine("Input incorrect.");
                        break;
                }
            }



            /* Uzduotis 1:
            Atnaujinkit Person, kad turetu Weight(double), Biography(string:nullable) atributus  
            (Nauja migracija turetu tureti tik siuos atnaujinimus). 

            Sukurkite nauja klase Animal, kuri turetu AnimalId(Primary Key), Name, Type, BirthDate atributus. 
            Pridekit animal i DbContext ir sukurkite nauja migracija. */


            /* Uzduotis 2:
            Sukurkite metodus, kurie leistu prideti nauja gyvuna, atspausdintu visus gyvunus, isgautu gyvunus kurie yra paduoto tipo, 
            atspausdintu visus gyvunus surikiuotus pagal varda. Pridekite sias funkcijas I main programos pasirinkimu menu. */




        }


    }




    

}