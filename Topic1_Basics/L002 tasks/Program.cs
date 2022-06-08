namespace L002_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.
             * Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi
             * Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
             * Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
             * Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi
             * Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi
             * Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi
             * į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi
             * pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi
             * paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute
             */

            // ================================================================================================
            // =====================================TOWER OF HANOI=============================================
            // ================================================================================================

            /*
            string ring0 = "     |     ";
            string ring1 = "    #|#    ";
            string ring2 = "   ##|##   ";
            string ring3 = "  ###|###  ";
            string ring4 = " ####|#### ";

            string eil1 = "1eil.";
            string eil2 = "2eil.";
            string eil3 = "3eil.";
            string eil4 = "4eil.";
            string eil5 = "5eil.";
            string eil6 = "      ----st1---- ----st2---- ----st3----";

            Console.WriteLine();
            Console.WriteLine("Tower of Hanoi");
            Console.WriteLine();

            Console.WriteLine($"{eil1} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring1} {ring0} {ring0}");
            Console.WriteLine($"{eil3} {ring2} {ring0} {ring0}");
            Console.WriteLine($"{eil4} {ring3} {ring0} {ring0}");
            Console.WriteLine($"{eil5} {ring4} {ring0} {ring0}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring4} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring3} {ring0} {ring0}");
            Console.WriteLine($"{eil3} {ring2} {ring0} {ring0}");
            Console.WriteLine($"{eil4} {ring1} {ring0} {ring0}");
            Console.WriteLine($"{eil5} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil3} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil4} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil5} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil3} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil4} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil5} {ring4} {ring4} {ring4}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil3} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil4} {ring0} {ring0} {ring1}");
            Console.WriteLine($"{eil5} {ring4} {ring3} {ring2}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring0} {ring2} {ring0}");
            Console.WriteLine($"{eil2} {ring0} {ring2} {ring0}");
            Console.WriteLine($"{eil3} {ring0} {ring2} {ring0}");
            Console.WriteLine($"{eil4} {ring0} {ring2} {ring1}");
            Console.WriteLine($"{eil5} {ring4} {ring2} {ring2}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring0} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring0} {ring0} {ring1}");
            Console.WriteLine($"{eil3} {ring0} {ring0} {ring2}");
            Console.WriteLine($"{eil4} {ring0} {ring0} {ring3}");
            Console.WriteLine($"{eil5} {ring0} {ring0} {ring4}");
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine($"{eil1} {ring0} {ring0} {ring0}".Replace("#", "\""));
            Console.WriteLine($"{eil2} {ring0} {ring0} {ring1}".Replace("#", "\""));
            Console.WriteLine($"{eil3} {ring0} {ring0} {ring2}".Replace("#", "\""));
            Console.WriteLine($"{eil4} {ring0} {ring0} {ring3}".Replace("#", "\""));
            Console.WriteLine($"{eil5} {ring0} {ring0} {ring4}".Replace("#", "\""));
            Console.WriteLine($"{eil6}");

            Console.WriteLine();
            Console.WriteLine("click any key to continue...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("nupieskite pirmo stulpelio pirma eilute patys (5simboliai + | + 5simboliai):");
            string drawnByUser = Console.ReadLine();

            Console.WriteLine($"{eil1} {drawnByUser} {ring0} {ring0}");
            Console.WriteLine($"{eil2} {ring0} {ring0} {ring1}");
            Console.WriteLine($"{eil3} {ring0} {ring0} {ring2}");
            Console.WriteLine($"{eil4} {ring0} {ring0} {ring3}");
            Console.WriteLine($"{eil5} {ring0} {ring0} {ring4}");
            Console.WriteLine($"{eil6}");
            */












            // ================================================================================================
            // =====================================TOWER OF HANOI (second try)================================
            // ================================================================================================

            /* nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.
             * Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi
             * Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
             * Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
             * Į 1stulp5eil įdėkite 4 dalių elementą, 2stulp5eil - 3 dalių, 3stulp4eil - 1 dalies, 3stulp5eil - 2 dalių, ir išveskite Tower of Hanoi
             * Į 1stulp4eil įdėkite tokį pat elementą kaip yra 3stulp4eil, ir išveskite Tower of Hanoi
             * Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup5eil, ir išveskite Tower of Hanoi
             * į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi
             * pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi
             * paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute
             */




            // ================================================================================================
            // nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.

            string ring0 = "     |     ";
            string ring1 = "    #|#    ";
            string ring2 = "   ##|##   ";
            string ring3 = "  ###|###  ";
            string ring4 = " ####|#### ";
            string paskutineEil = "      ----st1---- ----st2---- ----st3----";

            string stulp1eil1 = ring0;
            string stulp1eil2 = ring1;
            string stulp1eil3 = ring2;
            string stulp1eil4 = ring3;
            string stulp1eil5 = ring4;

            string stulp2eil1 = ring0;
            string stulp2eil2 = ring0;
            string stulp2eil3 = ring0;
            string stulp2eil4 = ring0;
            string stulp2eil5 = ring0;

            string stulp3eil1 = ring0;
            string stulp3eil2 = ring0;
            string stulp3eil3 = ring0;
            string stulp3eil4 = ring0;
            string stulp3eil5 = ring0;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi

            stulp1eil1 = stulp1eil5;
            stulp1eil2 = stulp1eil4;
            //stulp1eil3 = stulp1eil3; //apverciant stulpeli1 eilute3 islieka tokia pat kaip ir buvo
            stulp1eil4 = ring1;
            stulp1eil5 = ring0;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi

            stulp1eil1 = ring0;
            stulp1eil2 = "     |     ";
            stulp1eil3 = ring0;
            stulp1eil4 = stulp2eil4;
            // stulp1eil5 = ring0; // nereikia valyti stulp1eil5, nes jis jau ir taip tuscias

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi

            stulp1eil5 = ring4;
            stulp2eil5 = ring4;
            stulp3eil5 = ring4;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();


            // ================================================================================================
            // Į 1stulp5eil įdėkite 4 dalių elementą, 2stulp5eil - 3 dalių, 3stulp4eil - 1 dalies, 3stulp5eil - 2 dalių, ir išveskite Tower of Hanoi


            //stulp1eil5 = ring4;   // stulp1eil5 jau toks ir yra
            stulp2eil5 = ring3;
            stulp3eil4 = ring1;
            stulp3eil5 = ring2;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // Į 1stulp4eil įdėkite tokį pat elementą kaip yra 3stulp4eil, ir išveskite Tower of Hanoi

            stulp1eil4 = stulp3eil4;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stulp5eil, ir išveskite Tower of Hanoi

            stulp2eil1 = stulp3eil5;
            stulp2eil2 = stulp3eil5;
            stulp2eil3 = stulp3eil5;
            stulp2eil4 = stulp3eil5;
            stulp2eil5 = stulp3eil5;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi

            stulp1eil4 = ring0;
            stulp1eil5 = ring0;
            stulp2eil1 = ring0;
            stulp2eil2 = ring0;
            stulp2eil3 = ring0;
            stulp2eil4 = ring0;
            stulp2eil5 = ring0;
            stulp3eil1 = ring0;
            stulp3eil2 = ring1;
            stulp3eil3 = ring2;
            stulp3eil4 = ring3;
            stulp3eil5 = ring4;

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi

            stulp3eil1 = stulp3eil1.Replace("#", "\""); 
            stulp3eil2 = stulp3eil2.Replace("#", "\"");
            stulp3eil3 = stulp3eil3.Replace("#", "\"");
            stulp3eil4 = stulp3eil4.Replace("#", "\"");
            stulp3eil5 = stulp3eil5.Replace("#", "\"");

            Console.WriteLine($"1eil. {stulp1eil1}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\ntesti...\n");
            Console.ReadKey();

            // ================================================================================================
            // paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine();
            Console.WriteLine("nupieskite pirmo stulpelio pirma eilute patys (\"5 simboliai\" + \"|\" + \"5 simboliai\"):");
            string drawnByUser = Console.ReadLine();    //priskiriame naujai vartotojo ivesta string prie string drawnByUser
            Console.WriteLine();

            Console.WriteLine($"1eil. {drawnByUser}{stulp2eil1}{stulp3eil1}");
            Console.WriteLine($"2eil. {stulp1eil2}{stulp2eil2}{stulp3eil2}");
            Console.WriteLine($"3eil. {stulp1eil3}{stulp2eil3}{stulp3eil3}");
            Console.WriteLine($"4eil. {stulp1eil4}{stulp2eil4}{stulp3eil4}");
            Console.WriteLine($"5eil. {stulp1eil5}{stulp2eil5}{stulp3eil5}");
            Console.WriteLine($"{paskutineEil}");

            Console.WriteLine("\n - PABAIGA - \n");
            Console.ReadKey();


        }
    }
}