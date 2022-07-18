namespace L020_Repeating_arrays
{
    public class Program
    {
        static void Main(string[] args)
        {




            //Task1();
            //Task2();
            //Task3();
            Task4();








        }



        /// <summary>
        ///  1. "Rasti mažiausią"
        ///  Duotas vienatis sveikų skaičių masyvas.
        ///  Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
        ///  { 5, 3, 7, 6, 8, 7, 10 }
        ///  rezultatas: 3
        /// </summary>
        private static void Task1()
        {
            int[] array = { 5, 3, 7, 6, 8, 7, 10, 0 };

            int smallestNumber = Task1FindSmallestNumber(array);
            Console.WriteLine(smallestNumber);
        }

        public static int Task1FindSmallestNumber(int[] a)
        {
            int smallest = a[0]; 
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < smallest)
                    smallest = a[i];
            }
            return smallest;
        }

        /// <summary>
        /// 2. "Rasti didžiausią"
        /// Duotas vienatis sveikų skaičių masyvas.
        /// Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
        /// { 5, 3, 7, 6, 8, 7, 10 }
        /// rezultatas:  10
        /// </summary>
        private static void Task2()
        {
            int[] array = { 5, 3, 7, 6, 8, 7, 10 };

            int largestNumber = Task2FindLargestNumber(array);
            Console.WriteLine(largestNumber);
        }

        public static int Task2FindLargestNumber(int[] a)
        {
            int largest = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                    largest = a[i];
            }
            return largest;
        }

        /// <summary>
        /// 3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
        /// Duotas vienmatis sveikų skaičių masyvas.
        /// Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo
        /// mažiausio iki didžiausio
        /// { 5, 1, 7, 6, 8, 7, 10 }
        /// rezultatas:  1, 5, 6, 7, 7, 8, 10
        /// /// </summary>
        private static void Task3()
        {
            int[] array = { 5, 3, 7, 6, 8, 7, 10 };

            int[] reorderedArray = Task3Ascending(array);
            for (int i = 0; i < reorderedArray.Length; i++)
            {
                Console.Write(reorderedArray[i] + " ");
            }
        }

        public static int[] Task3Ascending(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tempI = a[i];
                        int tempJ = a[j];
                        a[i] = tempJ;
                        a[j] = tempI;
                    }
                }
            }
            return a;
        }


        /// <summary>
        /// ## RIKIUOTI TRIS RAIDES ##
        /// Parašykite programą kurioje vienas metodas.
        /// - Naudotojo paprašome įvesti 3 raides(atskirai).
        /// Būtina validacija kad įvesta tik vienas simbolis.
        /// - Metodas priima masyvą iš char ir grąžina masyvą iš char - surikiuotas raides pagal abecelę.
        /// Pvz:
        /// > Iveskite pirma raide:
        /// _ C
        /// > Iveskite antra raide:
        /// _ D
        /// > Iveskite trecia raide:
        /// _ B
        /// >  B, C, D
        /// </summary>
        private static void Task4()
        {
            char? char1 = null;
            while (char1 == null)
            {
                Console.Write("Iveskite viena didziaja raide: ");
                char1 = CharAZTryParseOutNull(Console.ReadLine());
            }

            char? char2 = null;
            while (char2 == null)
            {
                Console.Write("iveskite viena didziaja raide: ");
                char2 = CharAZTryParseOutNull(Console.ReadLine());
            }

            char? char3 = null;
            while (char3 == null)
            {
                Console.Write("iveskite viena didziaja raide: ");
                char3 = CharAZTryParseOutNull(Console.ReadLine());
            }

            char[] charArray = { char1.Value, char2.Value, char3.Value };

            charArray = Task4Reorder(charArray);


            Console.WriteLine(String.Join(" ", charArray));
        }

        private static char[] Task4Reorder(char[] charArray)
        {
            throw new NotImplementedException();
        }

        public static char? CharAZTryParseOutNull(string? txt)
        { 
            if (char.TryParse(txt, out char output) && output >= 65 && output <= 90)
            {
                return (char?)output;
            }
            else
            {
                return null;
            }
        }









    }
}