namespace L020_Repeating_arrays
{
    public class Program
    {
        static void Main(string[] args)
        {


            /// <summary>
            ///  Rasti mažiausią 
            ///  Duotas vienatis sveikų skaičių masyvas.
            ///  Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
            ///  { 5, 3, 7, 6, 8, 7, 10 }
            ///  rezultatas: 3
            /// </summary>

            Task1();









        }

        private static void Task1()
        {
            int[] array = { 5, 3, 7, 6, 8, 7, 10, 0 };

            int smallestNumber = Task1FindSmallestNumber(array);
            Console.WriteLine(smallestNumber);
        }

        public static int Task1FindSmallestNumber(int[] a)
        {
            int? number = null; 
            for (int i = 0; i < a.Length; i++)
            {
                if (number == null)
                    number = a[i];
                if (a[i] < number)
                    number = a[i];
            }
            return number.Value;
        }
    }
}