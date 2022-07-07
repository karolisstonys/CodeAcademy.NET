namespace L015_WhileDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *      1.Paprašyti vartotojo įvesti bet kokį skaičių. 
             *      Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.
             */
            //Uzduotis1();




            /*
             *      Paprašyti vartotojo įvesti bet kokį skaičių. 
             *      Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, 
             *      vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....
             */
            //Uzduotis2();




            /*
             *      Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma, 
             *      kurie buvo ivesti iki ivesto neigiamo skaiciaus
             * 
             *      PVZ
             *      1,23,4,5,7,8,-1
             */
            //Uzduotis3();




            /*
             *      6. Parasykite slaptazodzio ivedimo simuliacija. Pirma kompiuteris paprasys, 
             *      kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi. 
             *      Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
             *      Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.
             *      BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa 
             *      ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo.
             */
            Uzduotis4();


            /*
             *      Parasykite programa, kuri paklaustu naudotojo “skaicius ar herbas” ir naudotojas 
             *      galetu zaisti iki kol pasieke arba 10 pergaliu arba 10 pralaimejimu
             */


        }

        private static void Uzduotis4()
        {
            int galimiSlaptazodzioSpejimai = 3;
            Console.Write("Iveskite nauja spatazodi: ");
            string slaptazodis = Console.ReadLine();
            string pakartotasSlaptazodis = "";

            do
            {
                Console.Write("Pakartokite spatazodi: ");
                pakartotasSlaptazodis = Console.ReadLine();
                galimiSlaptazodzioSpejimai--;

                if (slaptazodis != pakartotasSlaptazodis && galimiSlaptazodzioSpejimai == 0)
                    Console.Write("UZBLOKUOTA!!!");
                else if (slaptazodis != pakartotasSlaptazodis)
                    Console.Write("NETEISINGAI, bandykite dar karta...");
                else
                    Console.Write("Sveikiname prisijungus!");

            } while (slaptazodis != pakartotasSlaptazodis && galimiSlaptazodzioSpejimai != 0);

        }

        private static void Uzduotis3()
        {
            int i = 0;
            int suma = 0;

            while (i == 0)
            {
                Console.Write("Iveskite skaiciu: ");
                int skaicius = Convert.ToInt32(Console.ReadLine());


                if (skaicius >= 0)
                    suma += skaicius;
                else
                    i++;
            }
            Console.Write("Suma: " + suma);
        }

        private static void Uzduotis2()
        {
            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            string ats = "0";

            while (i <= skaicius)
            {
                if (i % 2 == 0)
                    ats += ", " + i;
                if (i == skaicius)
                    ats += ".";
                i++;
            }
            Console.Write("Lyginiai: " + ats);
        }

        private static void Uzduotis1()
        {
            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int suma = 0;

            while (i <= skaicius)
            {
                suma+=i;
                i++;
            }
            Console.Write("Suma: {0}", suma);
        }




    }
}













