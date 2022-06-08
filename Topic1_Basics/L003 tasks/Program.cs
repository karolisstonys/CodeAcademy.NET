namespace L003_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =====================================================================================================
            // PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
            // - MOKYKLOS PAVADINIMĄ
            // - KURSO PAVADINIMĄ
            // - STUDENTŲ SKAIČIŲ
            // - ŠIANDIENOS DATĄ
            // VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ

            string mokyklosPav = "Code Academy";
            string kursoPav = ".Net";
            int studentuSkaicius = 5_000;
            string siandiena = new DateTime(2022, 06, 08).ToShortDateString();
            Console.WriteLine($"\nMOKYKLOS PAVADINIMAS: {mokyklosPav}\nKURSO PAVADINIMAS: {kursoPav} \nSTUDENTŲ SKAIČIUS: {studentuSkaicius} \nŠIANDIENOS DATA: {siandiena}");

            Console.WriteLine();
            // =====================================================================================================
            // PAPILDYTI PROGRAMĄ IR PRIDĖTI:
            // - KURSO PRADŽIOS DATĄ
            // - KURSO PABAIGOS DATĄ
            // - Sužinoti skirtumą tarp pradžios ir dabartinės datos(dienomis)
            // VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ

            DateTime kursoPradzia = new DateTime(2022, 05, 30);
            DateTime kursoPabaiga = new DateTime(2022, 12, 30);

            Console.WriteLine($"Kurso pradzia: {(kursoPradzia).ToShortDateString()}");
            Console.WriteLine($"Kurso pabaiga: {(kursoPabaiga).ToShortDateString()}");
            Console.WriteLine($"Kurso dienu sk.: {(kursoPabaiga - kursoPradzia).Days}");
            Console.WriteLine($"Jau praejo dienu: {(new DateTime(2022, 06, 08) - kursoPradzia).Days}");


            Console.WriteLine();
            // =====================================================================================================
            // Sukurkite tris kintamuosius.tekstinio, sveiko skaitmens ir loginio tipo.
            // Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu

            string tekstas = "tekstas";
            int skaicius = 12;
            bool logika = true;
            Console.WriteLine(tekstas + " " + skaicius + " " + logika);


            Console.WriteLine();
            // =====================================================================================================
            // Sukurkite tris sveikojo skaitmens tipo kintamuosius.
            // Parašykite programą kuri į konsolę visus aprašytus kintamuosius atskiriant tarpu
            // - panaudokite konkatinacija
            // - panaudokite kompoziciją
            // - panaudokite interpociacija

            int int1 = 1;
            int int2 = 2;
            int int3 = 3;

            Console.WriteLine(int1 + " " + int2 + " " + int3);
            Console.WriteLine("{0} {1} {2}", int1, int2, int3);
            Console.WriteLine($"{int1} {int2} {int3}");



        }
    }
}