namespace L001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("IŠVEDIMAS1 ");
            Console.Write("vienoje2 ");
            Console.Write("Eilutėje3 ");
            Console.WriteLine("\nlabas rytas\n");

            // KONKATINACIJA - rekomenduojama nenaudoti sio metodo
            Console.WriteLine("cia" + " " + "yra" + " " + "konkatinacija. A bad thing. =)");
            Console.WriteLine();

            // KOMPOZICIJA - Greitas, bet sunkiau skaitomas variantas
            Console.WriteLine("{0} {1} {2}", "Cia", "yra", "kompozicija");
            Console.WriteLine();

            // INTERPOLIACIJA - Letas, bet lengvai skaitomas variantas
            Console.WriteLine($"{"Cia"} {"yra"} {"interpoliacija"}");
            Console.WriteLine();

            // ESCAPE variantai:
            Console.WriteLine("\"ABC\"");
            Console.WriteLine("horizontal \t tab");
            Console.WriteLine("vertical \v tab");

            Console.WriteLine($"nauja ===>{Environment.NewLine}<=== eilute");

            // Consoles isvalymas
            Console.WriteLine();
            Console.WriteLine("click any key to clear console");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Koks tavo vardas? ");
            var vardas = Console.ReadLine();

            Console.Write("Kokia tavo pavarde? ");
            var pavarde = Console.ReadLine();

            Console.Write("Kokie tavo metu? ");
            var metai = Console.ReadLine();

            Console.WriteLine($"Tu esi {vardas} {pavarde} ir tau yra {metai}.");

            Console.Write("Raide: ");
            var key = Console.ReadKey();                                // PVZ a
            Console.WriteLine();
            Console.WriteLine("Raide yra - {0}", key.KeyChar);          // a
            Console.WriteLine("Raide yra - {0}", key.Key);              // A
            Console.WriteLine("Raide yra - {0}", (int)key.KeyChar);     // 97

            Console.Write("Koks tavo vardas? ");
            Console.WriteLine("Tavo pirma vardo raide yra " + Console.ReadLine()[0]);

            Console.WriteLine(
                 "eilute 1" +
                 "eilute 2" +
                 "eilute 3" +
                 "eilute 4");

             // verbatim (a verbatim MULTILINE STRING is created using a special symbol @)
             Console.WriteLine(@" 
                 eilute 1
                 eilute 2
                 eilute 3
                 eilute 4");

            //------------------------------------------------------------------------------------------------------
            // UŽDUOTIS NR.1

            // Isvesti savo varda i console
            Console.WriteLine("Karolis");

            // Ivedus savo varda atkartoti ji
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");

            // isvesti vardo pirmos raides ascii
            if (name != null) { 
                var ascii = (Convert.ToInt32(name[0]));
                Console.WriteLine($"Your name's first letter in ASCII is {ascii}");
                
                Console.WriteLine();
                Console.Write("Enter a number: ");
                var number = Console.ReadLine();

                Console.WriteLine("{0} + {1} = {2}", ascii, number, Convert.ToInt32(ascii)+Convert.ToInt32(number));

            }

            // Is paduoto meniu issirinkti viena varianta
            Console.WriteLine();
            Console.WriteLine("Please select from menu:");
            Console.WriteLine("(1) Buy");
            Console.WriteLine("(2) Sell");
            Console.WriteLine("(3) Stock");
            Console.WriteLine("Click 1, 2 or 3 to select.");
            Console.WriteLine();

            var key1 = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            if (key1 == "1")
            {
                Console.WriteLine("You selected 'Buy'");
            }
            else if (key1 == "2")
            {
                Console.WriteLine("You selected 'Sell'");
            }
            else if (key1 == "3")
            {
                Console.WriteLine("You selected 'Stock'");
            }

            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------
            // UŽDUOTIS NR.1 (Alternative)

            Console.WriteLine("1.");
            Console.Write("Enter your name: ");
            Console.WriteLine("Your name is {0}", Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("2.");
            Console.Write("Enter your name: ");
            Console.WriteLine("First letter of your name is \"{0}\"", Console.ReadLine()[0]);
            Console.Write("Enter first letter of your name: ");
            Console.WriteLine("\nFirst letter of your name in ASCII is {0}", (int)Console.ReadKey().KeyChar);

            Console.ReadKey();
        }
    }
}