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
            //PirmaUzduotis();

            /// <summary>
            /// 2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. 
            /// Naudoti tik ciklus ir matematines operacijas.Visi kintamieji yra integer tipo. 
            ///     Pvz:            
            ///     Ivedam- 12345 (int)            
            ///     Rezultatas-54321 (int)
            /// </summary>
            //AntraUzduotis();

            /// <summary>
            /// 3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
            /// Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
            /// Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
            ///     Pvz:
            ///     3
            ///     Edvinas
            ///     Jonas
            ///     Petras
            ///     ----------
            ///     Petras
            ///     Jonas
            ///     Edvinas
            /// </summary>


            /// <summary>
            /// 4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
            /// Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
            /// Kada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane. 
            /// Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.
            ///     Pvz:             
            ///     3            
            ///     Edvinas            
            ///     Jonas            
            ///     Petras
            ///     ---------------------            
            ///     Edvinas
            /// </summary>


            /// <summary>
            /// 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
            ///     PVZ: 1,2,2,4,2,7,6,1         
            ///     Pasikartojantys skaiciai: 1, 2
            /// </summary>


            /// <summary>
            /// 6. Programa praso ivesti eiluciu ir stulpeliu kieki. 
            /// Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir 
            /// atspausdintu matrica is pateiktu skaiciu            
            /// PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3                 
            ///     1 2                 
            ///     2 3
            /// </summary>
            /// 


            /// <summary>
            /// 7.Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
            /// </summary>
            /// 


            /// <summary>
            /// 8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
            /// </summary>


        }

        private static void PirmaUzduotis()
        {
            Console.Write("Kiek norite eiluciu: ");
            int eilutes = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= eilutes; i++)
                Console.WriteLine(sb.Insert(0, i % 2).ToString());
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