namespace L007_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================================================================================================================================
            /*
            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
            - JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
            - JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
            - KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ
            */

            /*
            int skaicius = 0;
            Console.Write("iveskite skaiciu:");
            skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius % 2 == 0)                      // daliname is 2 ir ziurime ar liekana yra lygi nuliui, taip issiaiskindami ar skaicius yra lyginis
            {
                Console.WriteLine("SKAIČIUS YRA LYGINIS");
            }
            if (skaicius < 0)                           // jei skaicius yra neigiamas 
            {
                Console.WriteLine("SKAIČIUS YRA NEIGIAMAS");
            }

            if (skaicius % 2 != 0 && skaicius >= 0) 
            {
                Console.WriteLine(skaicius);
            }
            */

            // ================================================================================================================================
            /*
            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
            VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
            - JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA „TAI SOLO ATLIKĖJAS“, 
            - JEI NARIŲ KIEKIS 2 --„TAI DUETAS“, 
            - JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, 
            - JEI DAUGIAU NEI 10 ––„TAI KAMERINIS ANSAMBLIS“
             */

            /*
            int skaicius = 0;
            Console.Write("iveskite grupes nariu skaiciu:");
            skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius == 1)
            {
                Console.WriteLine("TAI SOLO ATLIKĖJAS");
            }
            else if (skaicius == 2)
            {
                Console.WriteLine("TAI SOLO ATLIKĖJAS");
            }
            else if (2 < skaicius && skaicius < 10)
            {
                Console.WriteLine("TAI ANSAMBLIS");
            }
            else if (skaicius > 10)
            {
                Console.WriteLine("TAI KAMERINIS ANSAMBLIS");
            }
            else
            {
                Console.WriteLine("Ivestas blogas skaicius");
            }
            */


            // ================================================================================================================================
            /*
            PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI IŠDIRBTAS VALANDAS.
            - JEI VALANDŲ YRA MAŽIAU NEI 160, PROGRAMA TURI PARODYTI, KIEK DAR REIKIA IŠDIRBTI, 
            - JEI LYGIAI 160, PARODO, KAD IŠDIRBTAS PILNAS ETATAS, 
            - JEI DAUGIAU PARODO KIEK YRA VIRŠVALANDŽIŲ.
            - JEI VARTOTOJAS PADARO ĮVEDIMO KLAIDĄ PRANEŠTI IR UŽBAIGTI DARBĄ
             */


            int skaicius = 0;
            Console.Write("ĮVESTI IŠDIRBTAS VALANDAS:");
            // bandome TryParse
            bool arGerasSkaicius = uint.TryParse(Console.ReadLine(), out var input);      
            // bool arGerasSkaicius - ar pavyko ta norima skaiciu isgauti
            // var input - ivestas skaicius

            if (arGerasSkaicius)
            {
                if (input < 160)
                {
                    Console.WriteLine($"DAR REIKIA IŠDIRBTI {160 - skaicius}val");
                }
                else if (input == 160)
                {
                    Console.WriteLine("IŠDIRBTAS PILNAS ETATAS");
                }
                else if (input > 160)
                {
                    Console.WriteLine($"VIRŠVALANDŽIŲ: {input - 160}val");
                }
            }
            else
            {
                Console.WriteLine("KLAIDA");
            }

























            // ================================================================================================================================


            // ================================================================================================================================


            // ================================================================================================================================














        }
    }
}