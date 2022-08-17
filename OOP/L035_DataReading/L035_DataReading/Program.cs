using L035_DataReading.Models;

namespace L035_DataReading
{
    public class Program
    {
        static void Main(string[] args)
        {

            //string path = Environment.CurrentDirectory;
            //SakninioFolderioSuradimas(path);

            //SkaitymasIsIvesties();

            //SkaitymasIsTxtFailo();

            SkaitymasIsTxtFailoEilutemisAtskirai();
        }

        public static void SakninioFolderioSuradimas(string path)
        {
            string rootDirPath = new DirectoryInfo(path).Parent.Parent.FullName;
            Console.WriteLine($"Skaninis katalogas yra {path}");
        }

        public static void SkaitymasIsIvesties()
        {
            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas; 2, Ieva;");

            string[] usersInText = Console.ReadLine().Replace(" ", "").Split(';');

            List<User> users = new List<User>();

            foreach (string user in usersInText)
            {
                string[] userData = user.Split(',');
                if (user.Length < 2) break;

                User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus: ");
            foreach (User user in users)
            {
                Console.Write($"ID: {user.Id} Vardas: {user.Name}");
                Console.WriteLine();
            }
        }


        public static void SkaitymasIsStaticKlases()
        {
            //List<L034_Practice.Person> persons = new List<User>();

        }

        // + Greitas sprendimas reikalaujantis nedaug laiko ir mazai ziniu
        // - Reikalauja papildomu split operaciju
        // - Uzkrauna visa texta i atminti
        // - Kol skaito teksta nieko kito aplikacijoje negali vykti su veikianciu thread
        // - Nesiples darbas su dideliais failais
        public static void SkaitymasIsTxtFailo()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();
            
            string path1 = "I:\\CODING\\GitHub_CodeAcademy.NET\\OOP\\L035_DataReading\\L035_DataReading\\Data\\AnimaData.txt";

            // Animals.txt → Properties → Copy To Output Directory → Copy always
            string path2 = new DirectoryInfo(Environment.CurrentDirectory)/*.Parent.Parent.Parent.FullName*/ + "\\Data\\AnimaData.txt";
            
            Console.WriteLine(path1);
            Console.WriteLine(path2);

            //string text = File.ReadAllText(path1);
            string text = File.ReadAllText(path2);
            string[] animalStringData = text.Split(Environment.NewLine);

            Console.WriteLine(text);

            foreach (string animal in animalStringData)
            {
                string[] animalData = animal.Split(',');

                if (animalData.Length != animalColCount) break;

                Animal newAnimal = new Animal();
                animals.Add(newAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.Write($"Gyvunas: {animal.Name}");
            }
        }

        // + Greitas sprendimas reikalaujantis nedaug laiko ir mazai ziniu
        // - Uzkrauna visa texta i atminti
        // - Kol skaito teksta nieko kito aplikacijoje negali vykti su veikianciu thread
        // - Nesiples darbas su dideliais failais
        public static void SkaitymasIsTxtFailoEilutemis()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Data\\AnimaData.txt";

            string[] animalStringData = File.ReadAllLines(path);    // ←-----------------------------------------

            foreach (string animal in animalStringData)
            {
                string[] animalData = animal.Split(',');

                if (animalData.Length != animalColCount) break;

                Animal newAnimal = new Animal();
                animals.Add(newAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.Write($"Gyvunas: {animal.Name}");
            }
        }

        public static void SkaitymasIsTxtFailoEilutemisAtskirai()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Data\\AnimaData.txt";

            // IDisposable resurasai butu elementai kaip: Streamai, Listeneriai, db komunikacijos repozitorijos, webiniai iskvietimai ir t.t.
            // Gali uztrukti neaisku kiek laiko, del begales priezasciu!
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            Console.WriteLine(line);
            string line2 = sr.ReadLine();
            Console.WriteLine(line2);

            // su .Close() mes pasakome GarbageCollector, kad reikia isvalyti duomenis priklausiancius siam objetrui
            sr.Close(); 

            //while ((line = sr.ReadLine()) != null)
            //{

            //}


            //foreach (Animal animal in animals)
            //{
            //    Console.Write($"Gyvunas: {animal.Name}");
            //}

        }



    }
}