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











        }
    }
}