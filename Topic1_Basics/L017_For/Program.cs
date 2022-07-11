namespace L017_For
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, For loop!");

            //ForLoop();
            //ForLoopBack();
            //BreakForLoop();
            //SkipIterationForLoop();
            ForLoopNesting();


        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void ForLoopBack()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void BreakForLoop()
        {
            int skaicius = 5;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == skaicius)
                {
                    break;
                }
            }
        }

        private static void SkipIterationForLoop()
        {
            int iteracijaKuriaNorimePraleisti = 5;
            for (int i = 0; i < 10; i++)
            {
                if (i == iteracijaKuriaNorimePraleisti)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        private static void ForLoopNesting()
        {
            for (int i = 0; i <= 10; i++)
            {

                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static bool DnrGrandinesValidacija_Replace(string dnr)
        {
            return dnr.Replace("-", "").Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "").Length == 0;
        }

        public static bool DnrGrandinesValidacija_For(string dnr)
        {
            for (int i = 0; i < dnr.Length; i++)
            {
                if (dnr[i] != '-' &&
                    dnr[i] != 'A' &&
                    dnr[i] != 'T' &&
                    dnr[i] != 'C' &&
                    dnr[i] != 'G')
                {
                    return false;
                }
            }
            return true;
        }















    }
}