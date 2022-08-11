using L032_OOP_Methods.Domain;
using System.Text;

namespace L032_OOP_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello OOP Metodai!");
            //var house1 = new House();
            //foreach (var pplNameInHose in house1.PeopleNames)
            //{
            //    Console.WriteLine($"Namo gyventojo vardas: {pplNameInHose}");
            //}

            //Task5();
            Task6();

        }

        /* Uzduotis 4:
        Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus (kontrakta) taip, 
        kad atributu reiksmes galima butu skaityti is isores, 
        bet nustatyti reiksmes butu galima tik klases viduje. */

        /* Uzduotis 5:(Savarankiskai)
        Sukurti klases Hobis ir Profesija 
        Klasės interfeise turi būti properčiai: 
        - Id (int), 
        - TekstasLietuviskai(string)
        - Tekstas(string) 
        Sukurti tuscia konstruktorių, kuris inicializuoja duotas reikšmes.
        Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
        Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
        
        Sukurkite po 3 skirtingus hobius ir profesijas (panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus. 
        1. Konstruktoriaus pagalba 
        2. Tuscio objekto sukurimas ir pildymas eigoje
        3. Deklaravimo metu priskirti reiksmes (vienas SETeris gali buti PUBLIC arba default) */

        public static void Task5()
        {
            var hobby1 = new Hobby();
            var hobby2 = new Hobby(2, "šokiai", "pramoginiai");
            var hobby3 = new Hobby()
            {
                Id = 3
            };

            Console.WriteLine($"{hobby1.Id} | {hobby1.TextLT} | {hobby1.Text}");
            Console.WriteLine($"{hobby2.Id} | {hobby2.TextLT} | {hobby2.Text}");
            Console.WriteLine($"{hobby3.Id} | {hobby3.TextLT} | {hobby3.Text}");
            Console.WriteLine();


            var profession1 = new Profession();
            var profession2 = new Profession(2, "Vairuotojas", "C kategorijos");
            var profession3 = new Profession()
            {
                Text = "Nežinomas"
            };

            Console.WriteLine($"{profession1.Id} | {profession1.TextLT} | {profession1.Text}");
            Console.WriteLine($"{profession2.Id} | {profession2.TextLT} | {profession2.Text}");
            Console.WriteLine($"{profession3.Id} | {profession3.TextLT} | {profession3.Text}");
        }

        /* Uzduotis 6: (Savarankiskai)
        Sukurkite klasę “Bendrabutis”. 
        Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:       
        - BendrabucioId
        - KambariuSkaicius
        - Kaina
        Sujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip, 
        kad kiekviename bendrabutyje galėtų gyventi daug žmonių, 
        tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje. */

        public static List<Dormitory> allDormitories = new List<Dormitory>();
        public static List<Person> allPersons = new List<Person>();

        public static void Task6()
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.Write("\n\n1. Prideti bendrabuti.\n2. Prideti zmogu.\n3. Parodyti visus bendrabucius.\n4. Parodyti visus zmones.\n5. Parodyti viska.\n6. Iseiti.\n\nPasirinkite: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        AddDorm();
                        break;
                    case "2":
                        Console.Clear();
                        AddPerson();
                        break;
                    case "3":
                        Console.Clear();
                        ShowDorms();
                        break;
                    case "4":
                        Console.Clear();
                        ShowPersons();
                        break;
                    case "5":
                        Console.Clear();
                        ShowEverything();
                        break;
                    case "6":
                        Console.Clear();
                        isAppRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogas pasirinkimas");
                        break;
                }
            }
        }

        private static void AddDorm()
        {
            Console.Write("Dormatory name: ");
            var dormName = Console.ReadLine();
            var dorm = new Dormitory(dormName);
            allDormitories.Add(dorm);
        }

        private static void ShowDorms()
        {
            var sb = new StringBuilder();
            sb.AppendLine("ID\tDormatory\tRooms\tPrice\tPersons");
            foreach (var dorm in allDormitories)
            {
                var personCount = 0;
                if (dorm.Persons != null)
                    personCount = dorm.Persons.Count;
                sb.AppendLine($"{dorm.DormitoryId,-8}{dorm.Name,-16}{dorm.RoomCount,-8}{dorm.Price+"€",-8}{personCount,-8}");
            }
            Console.WriteLine(sb.ToString());
        }

        private static void AddPerson()
        {
            Console.Write("Person name: ");
            var personName = Console.ReadLine();
            Console.Write("Dormatory ID (can leave blank): ");
            var stringDormId = Console.ReadLine();
            if (string.IsNullOrEmpty(stringDormId))
            {
                var person = new Person(personName);
                var dorm = person.GetDorm();
                allDormitories.Add(dorm);
                allPersons.Add(person);
            }
            else
            {
                var dorm = allDormitories.Where(x => x.DormitoryId == Convert.ToInt32(stringDormId)).FirstOrDefault();
                var person = new Person(personName, dorm);
                allPersons.Add(person);
            }

        }

        private static void ShowPersons()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Person\t\tDormatory ID");
            foreach (var person in allPersons)
            {   
                sb.AppendLine($"{person.Name,-16}{person.DormitoryId,-8}");
            }
            Console.WriteLine(sb.ToString());
        }

        private static void ShowEverything()
        {
            var sb = new StringBuilder();
            foreach (var dorm in allDormitories)
            {
                sb.Append($"{dorm.Name} (id:{dorm.DormitoryId}, rooms:{dorm.RoomCount}, price:{dorm.Price}€) persons living:");
                foreach (var person in dorm.Persons)
                {
                    sb.Append($" {person.Name}");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }

        /* Uzduotis 7: 
        Sukurkite 5 klases – Studentas, Mokykla, Mokytojas, PazymiuKnygele, Pamoka ir juos sukomponuokite (Sudekite rysius tarp ju).
            Kiekviena mokykla turi nuo 1 iki begalybes mokytoju.
            Kiekvienas mokytojas turi nuo 1 iki begalybes studentu.
            Kiekvienas studentas turi 1 pažymių knygelę.
            Kiekviena pažymių knygelė turi nuo 1 iki begalybės pamokų, kurios turi buti saugomos su studentu pazymiais.
            Pamoka turi tik pavadinimą ir nuo 1 iki begalybės priskirtų mokytojų.
        Inicializuokite klases su duomenimis (turi buti maziausiai uzpildytos 2 mokyklos) ir sukurkite 3 metodus, kurie atspausdinkite ekrane(Šie metodai turetu priimti tik 1 objekta. Objektai gali buti skirtingi tarp metodu):       
        Mokyklos pavadinima + Kiekviena mokytoja kartu su jo mokiniu vardais
        (Savarankiskai)Kiekviena mokini kartu su kiekvieno is ju pazymiais 
        (Savarankiskai)Kiekvieno studento kiekvienos pamokos pazymiu vidurki */






    }
}