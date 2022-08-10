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

        }

        /*
        Uzduotis 4:
        Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus (kontrakta) taip, 
        kad atributu reiksmes galima butu skaityti is isores, 
        bet nustatyti reiksmes butu galima tik klases viduje.
        */

        /*
        Uzduotis 5:(Savarankiskai)
        Sukurti klases Hobis ir Profesija 
        Klasės interfeise turi būti properčiai: Id (int), TekstasLietuviskai(string) ir Tekstas(string) 
        Sukurti tuscia konstruktorių, kuris inicializuoja duotas reikšmes.
        Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
        Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
        
        Sukurkite po 3 skirtingus hobius ir profesijas (panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus. 
        1. Konstruktoriaus pagalba 
        2. Tuscio objekto sukurimas ir pildymas eigoje
        3. Deklaravimo metu priskirti reiksmes (vienas SETeris gali buti PUBLIC arba default)
        */


        public static void Task5()
        {
            var hobby1 = new Hobby();
            var hobby2 = new Hobby(2, "šokiai", "pramoginiai");
            var hobby3 = new Hobby()
            {
                Id = 3
            };

            Console.WriteLine($"{hobby1.Id} | {hobby1.TekstasLietuviskai} | {hobby1.Tekstas}");
            Console.WriteLine($"{hobby2.Id} | {hobby2.TekstasLietuviskai} | {hobby2.Tekstas}");
            Console.WriteLine($"{hobby3.Id} | {hobby3.TekstasLietuviskai} | {hobby3.Tekstas}");
            Console.WriteLine();


            var profession1 = new Profession();
            var profession2 = new Profession(2, "Vairuotojas", "C kategorijos");
            var profession3 = new Profession()
            {
                Tekstas = "Nežinomas"
            };

            Console.WriteLine($"{profession1.Id} | {profession1.TekstasLietuviskai} | {profession1.Tekstas}");
            Console.WriteLine($"{profession2.Id} | {profession2.TekstasLietuviskai} | {profession2.Tekstas}");
            Console.WriteLine($"{profession3.Id} | {profession3.TekstasLietuviskai} | {profession3.Tekstas}");
            Console.WriteLine();

        }



    }
}