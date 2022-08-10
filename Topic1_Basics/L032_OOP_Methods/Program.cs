using L032_OOP_Methods.Domain;

namespace L032_OOP_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OOP Metodai!");
            //var house1 = new House();
            //foreach (var pplNameInHose in house1.PeopleNames)
            //{
            //    Console.WriteLine($"Namo gyventojo vardas: {pplNameInHose}");
            //}

            Task5();
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

        public static void Task6()
        {
            var dorm1 = new Dormitory(5, 69.90m) { };

            var persons = new List<Person>();
            persons.Add(new Person("Joniukas", dorm1.DormitoryId));
            persons.Add(new Person("Pepė", dorm1.DormitoryId));
            persons.Add(new Person("Petriukas", dorm1.DormitoryId));
            dorm1.Persons = persons;

            foreach (var person in dorm1.Persons)
            {
                Console.WriteLine($"{person.DormId} {person.Name} ");
            }
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