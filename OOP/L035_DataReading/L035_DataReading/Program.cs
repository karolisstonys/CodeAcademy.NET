using L035_DataReading.Models;
using L035_DataReading.Services;

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
            //SkaitymasIsTxtFailoEilutemisAtskirai();
            //SkaitymasIsTxtFailoEilutemisAtskiraiSuUsing();

            //FileServices animalFileServices = new FileServices(Environment.CurrentDirectory + "\\Data\\AnimaData.txt");
            //animalFileServices.ReadStreamSymbolsFromFile();

            FileServices basicUserFileService = new FileServices(Environment.CurrentDirectory + "\\Data\\UserFirstNameBaseData1.csv");
            Console.WriteLine(basicUserFileService.ExtractBasicUserCsvHeaders());
            PrintAllBasicUsers(basicUserFileService.FetchBasicUserCsvRecords());


        }

        public static void PrintAllBasicUsers(List<BasicUser> basicUsers)
        {
            foreach (BasicUser basicUser in basicUsers)
            {
                Console.WriteLine($"{basicUser.Id} {basicUser.Name}");
            }
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

            List<BasicUser> basicUsers = new List<BasicUser>();

            foreach (string user in usersInText)
            {
                string[] userData = user.Split(',');
                if (user.Length < 2) break;

                BasicUser newUser = new BasicUser(Convert.ToInt32(userData[0]), userData[1]);
                basicUsers.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus: ");
            foreach (BasicUser basicUser in basicUsers)
            {
                Console.Write($"ID: {basicUser.Id} Vardas: {basicUser.Name}");
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

        // dingsta minusai bet ir pliusai irgi dingsta
        public static void SkaitymasIsTxtFailoEilutemisAtskirai()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Data\\AnimaData.txt";

            // IDisposable resurasai butu elementai kaip: Streamai, Listeneriai, db komunikacijos repozitorijos, webiniai iskvietimai ir t.t.
            // Gali uztrukti neaisku kiek laiko, del begales priezasciu!
            StreamReader sr = new StreamReader(path);

            string animalLine;

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            // su .Close() mes pasakome GarbageCollector, kad reikia isvalyti duomenis priklausiancius siam objetrui
            sr.Close();

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Gyvunas: ({animal.Id}) {animal.Name}");
            }

        }


        public static void SkaitymasIsTxtFailoEilutemisAtskiraiSuUsing()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Data\\AnimaData.txt";

            //using StreamReader sr = new StreamReader(path) { }        // Senesnis variantas, jei dirbama su senesne .NET versija

            using StreamReader sr = new StreamReader(path);

            string animalLine;

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }


            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Gyvunas: ({animal.Id}) {animal.Name}");
            }

        }

    }

    /*
    1. Uzduotis 1
    – Sukurkite programa, kuri moketu nuskaityti UserData1.csv failą. UserData1.csv galite pasiimti iš Teams pamokos Files sekcijos. 
    Atvaizduokite kiekvieno naudotojo duomenis tokiu formatu:”55. Petras Petraitis (Vyras) – petras@petramail.lt”.
    Headeri turetu atspausdinti pirmoje eiluteje.
    */


    /*
    2. Uzduotis 2 
    – Sukurkite nauja <Hotel> klase, kuri savyje gali laikyti sarasa <User> (Hoteliu data importuokite is HotelData1.csv). 
    Sukurkite nauja <HotelManager> klase, kuri savyje laiko sarasa hoteliu. 
    Naujai sukurtai klasei <HotelManager> sukurkite metoda [AllocateUsersToHotels(users)], kuris priskirs kiekviena vartotoja atsitiktiniam (Random) hoteliui. 
    Sukurkite atskleidziama <Hotel> property, AverageClientSalary, kuris grazintu besilankanciu klientu vidutine sumuota alga. Turi buti Unit Test Coverage.
    */


    /*
    3. Uzduotis 3
    - Sukurkite isskleista property <HotelManager> AverageRating, kuris grazintu vidutini hoteliu ivertinima + unit test.
    Sukurkite <HotelManager> klasei isskleidziama property NewHotels, kuris grazintu sarasa visu hoteliu, kurie buvo pastatyti veliau nei 2010-01-01.
    Sukurkite <HotelManager> klasei metoda [AllocateUsersToLuxHotels(users)], kuris turetu naudotojus priskirti tik i hotelius, 
        kuriu ivertinimas yra auksciau 3 ir yra NewHotels sarase.
    Sukurkite <Hotel> klasei [MenVisitors] ir [WomenVisitors] isskleidziamus property, kurie turetu grazinti besilankancius vyrus ir moteris individualiai.
    */
}