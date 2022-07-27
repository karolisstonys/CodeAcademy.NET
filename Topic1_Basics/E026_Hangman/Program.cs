namespace E026_Hangman
{
    public class Program
    {
        static int HangmanProgress = 0; // 7 is max
        static string[] Names = new string[] { "Jonas", "Petras", "Antanas" };
        static string[] Cities = new string[] { "Vilnius", "Kaunas", "Klaipeda" };
        static string[] Countries = new string[] { "Lietuva", "Latvija", "Estija" };
        static string[] CarBrands = new string[] { "Volkswagen", "Toyota", "Porsche" };



        static void Main(string[] args)
        {
            DrawHangman(1);
        }

        public static void DrawHangman(int duh)
        {
            if (duh == 0)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 1)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 2)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 3)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║    O   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 4)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║   /O   ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 5)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║   /O\\  ");
                Console.WriteLine(" ║        ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 6)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☺   ");
                Console.WriteLine(" ║   /O\\  ");
                Console.WriteLine(" ║   /    ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }
            else if (duh == 7)
            {
                Console.WriteLine(" ╔════╕   ");
                Console.WriteLine(" ║    |   ");
                Console.WriteLine(" ║    ☻   ");
                Console.WriteLine(" ║   /O\\  ");
                Console.WriteLine(" ║   / \\  ");
                Console.WriteLine(" ║        ");
                Console.WriteLine("═╩════════");
            }







        }









    }
}