using System.Text;

namespace L019_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// 1.Parasykite programa, kuri atspausdintu sia figura pvz:
            ///     1
            ///     01
            ///     101
            ///     0101
            ///     10101
            /// </summary>
            PirmaUzduotis();

            /// <summary>
            /// 2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. 
            /// Naudoti tik ciklus ir matematines operacijas.Visi kintamieji yra integer tipo. 
            ///     Pvz:            
            ///     Ivedam- 12345 (int)            
            ///     Rezultatas-54321 (int)
            /// </summary>
            //AntraUzduotis();


        }

        private static void PirmaUzduotis()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 10; i++)
            {
                sb.Insert(0, i % 2);
                Console.WriteLine(sb.ToString());
            }
        }

        private static void AntraUzduotis()
        {
            int a = 0;
            int reverse = 0;
            int rem;

            a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                rem = a % 10;
                reverse = reverse * 10 + rem;
                a /= 10;
            }
            Console.Write("Number: " + a);
            Console.Write("Reversed Number: " + reverse);
        }

















    }
}