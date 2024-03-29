﻿using System.Text;

namespace L019_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task8();

        }

        private static void EXAMPLES()
        {
            // Galime isvengti bereikalingo kintamuju kurimo naudodami masyvus
            int skaicius1 = 100;
            int skaicius2 = 95;
            int skaicius3 = 92;
            // Iki 10 skaiciu

            //deklaravimas
            int[] skaiciai = { 100, 95, 92 };

            //Tuscio masyvo deklaravimas
            int[] skaiciai2 = null;

            if (skaicius1 != skaicius2)
            {
                skaiciai2 = new int[7];
            }

            Console.WriteLine(skaiciai2[1]);

            //vietos isskyrima
            int[] skaiciai3 = new int[10];
            string[] zodziai = new string[3];
            double[] realusSkaiciai = new double[3];

            //reiksmiu irasymas
            skaiciai3[0] = 100;
            skaiciai3[1] = 95;
            skaiciai3[2] = 92;
            //skaiciai3[99] = 999;

            //Daugiau budu masyvu reiksmems deklaruoti
            int[] intMasyvas1 = new int[] { 100, 155, 92, 165, 55, 50, 48, 40, 35, 10 };
            int[] intMasyvas2 = new[] { 100, 155, 92, 165, 55, 50, 48, 40, 35, 10 };
            int[] intMasyvas3 = new int[1] { 100 };
            int[] intMasyvas4 = { 100, 155, 92, 165, 55, 50, 48, 40, 35, 10 };

            //Masyvo reikmes gauti pagal indeksa
            Console.WriteLine(intMasyvas1[8]);

            var pazymiai = new int[10];

            //                       0               1              2               3                4                5              6
            string[] dienos = { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis" };

            Console.WriteLine(dienos[0]);
            Console.WriteLine(dienos[3]);
            dienos[3] = "Sestadienis";
            Console.WriteLine(dienos[3]);
            var pasirinktaDiena = "Penktadienis";
            dienos[3] = pasirinktaDiena;
            Console.WriteLine(dienos[3]);
            Console.WriteLine(dienos[5]);
            Console.WriteLine(dienos[3]);
            //Console.WriteLine(dienos[7]); NETEISINGA

            //dienos = new string[10];

            Console.WriteLine($"Masyvu irasu kiekis: {dienos.Length}");

            char[] testinisZodisIsChar = { 't', 'e' };
            string testinisZodis = "testinis";

            // String yra sudarytas is char masyvo
            for (int i = 0; i < testinisZodis.Length; i++)
            {
                Console.WriteLine(testinisZodis[i]);
            }

            // Visu masyvo irasu atspausdinimas
            for (int i = 0; i < dienos.Length; i++)
            {
                Console.WriteLine(dienos[i]);
            }

            // Matricos/Dvimacio masyvo deklaravimas
            int[][] dvimatisMasyvas = new int[4][];
            int[,] dvimatisMasyvas2 = new int[4, 5];


            // Dvimacio masyvo irasu deklaravimas
            int[,] dvimatisMasyvasKableliu = new int[,]
                { { 1, 2},
                { 3, 4 },
                { 4, 5 } };

            int[,] dvimatisMasyvas3 = new int[3, 2]
                { { 1, 2},
                { 3, 4 },
                { 4, 5 } };

            for (int i = 0; i < dvimatisMasyvas3.GetLength(0); i++)
            {
                for (int j = 0; j < dvimatisMasyvas3.GetLength(1); j++)
                {
                    Console.Write($"{dvimatisMasyvas3[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 1.Parasykite programa, kuri atspausdintu sia figura pvz:
        ///     1
        ///     01
        ///     101
        ///     0101
        ///     10101
        /// </summary>
        private static void Task1()
        {
            Console.Write("Kiek norite eiluciu: ");
            int eilutes = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= eilutes; i++)
                Console.WriteLine(sb.Insert(0, i % 2).ToString());
        }

        /// <summary>
        /// 2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. 
        /// Naudoti tik ciklus ir matematines operacijas.Visi kintamieji yra integer tipo. 
        ///     Pvz:            
        ///     Ivedam- 12345 (int)            
        ///     Rezultatas-54321 (int)
        /// </summary>
        private static void Task2()
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
        private static void Task3()
        {
            int? people = null;
            Console.Write("Kiek zmoniu atejo: ");

            while (people == null)
            {
                people = TRTL.Reusable.IntTryParseOutNull(Console.ReadLine());
            }

            string[] peopleInRoom = new string[people.Value];
            Console.WriteLine();
            Console.WriteLine("Iveskite zmoniu vardus.");
            for (int i = 0; i < peopleInRoom.Length; i++)
            {
                Console.Write($"{i + 1} zmogaus vardas: ");
                peopleInRoom[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.Write("Visi zmones atbuline tvarka: ");
            for (int i = peopleInRoom.Length - 1; i > 0; i--)
            {
                Console.Write(peopleInRoom[i] + " ");
            }
        }

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
        private static void Task4()
        {
            int? people = null;
            while (people == null)
            {
                Console.Write("Kiek zmoniu atejo: ");
                people = TRTL.Reusable.IntTryParseOutNull(Console.ReadLine());
            }

            Console.WriteLine();
            string[] peopleInRoom = new string[people.Value];
            Console.WriteLine("Iveskite zmoniu vardus.");
            for (int i = 0; i < peopleInRoom.Length; i++)
            {
                Console.Write($"{i + 1} zmogaus vardas: ");
                peopleInRoom[i] = Console.ReadLine();
            }

            int longestNameLength = 0;
            Task4LongestLength(peopleInRoom, ref longestNameLength);

            Console.WriteLine();
            Console.WriteLine("Ilgiausias(i) vardas(ai): ");
            Task4LongestName(peopleInRoom, longestNameLength);
        }

        private static void Task4LongestLength(string[] peopleInRoom, ref int longestNameLength)
        {
            for (int i = 0; i < peopleInRoom.Length; i++)
            {
                if (longestNameLength < peopleInRoom[i].Length)
                    longestNameLength = peopleInRoom[i].Length;
            }
        }

        private static void Task4LongestName(string[] peopleInRoom, int longestNameLength)
        {
            for (int i = 0; i < peopleInRoom.Length; i++)
            {
                if (longestNameLength == peopleInRoom[i].Length)
                    Console.WriteLine(peopleInRoom[i]);
            }
        }
        
        /// <summary>
        /// 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
        ///     PVZ: 1,2,2,4,2,7,6,1         
        ///     Pasikartojantys skaiciai: 1, 2
        /// </summary>
        private static void Task5()
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2 ,3 };

            Console.WriteLine("Pasikartojantys skaiciai: ");

            Task5RepeatingNumbers(intArray);
        }

        private static void Task5RepeatingNumbers(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j] && i != j)
                        Console.Write(intArray[j] + " ");
                }
            }
        }

        /// <summary>
        /// 6. Programa praso ivesti eiluciu ir stulpeliu kieki. 
        /// Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir 
        /// atspausdintu matrica is pateiktu skaiciu            
        /// PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3                 
        ///     1 2                 
        ///     2 3
        /// </summary>
        private static void Task6()
        {
            int? lines = null;
            int? columns = null;

            while (lines == null)
            {
                Console.Write("Matricos eiluciu skaicius: ");
                lines = TRTL.Reusable.IntTryParseOutNull(Console.ReadLine());
            }

            while (columns == null)
            {
                Console.Write("Matricos stulpeliu skaicius: ");
                columns = TRTL.Reusable.IntTryParseOutNull(Console.ReadLine());
            }

            int[,] array = new int[lines.Value, columns.Value];
            int arrayLengthRemaining = array.Length;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int? number = null;
                    while (number == null)
                    {
                        Console.Write($"Iveskite skaicius (liko {arrayLengthRemaining}): ");                        
                        number = TRTL.Reusable.IntTryParseOutNull(Console.ReadLine());
                    }
                    array[i, j] = number.Value;
                    arrayLengthRemaining--;
                }
            }

            Console.WriteLine("\nJusu masyvas: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"({i},{j}) {array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 7.Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
        /// </summary>
        /// 
        private static void Task7()
        {
            int[,] intArray = new int[,]
                {
                  { 2, 2, 2 },
                  { 2, 2, 2 },
                  { 2, 2, 3 }
                };

            string repeatingNumbers = Task7RepeatingNumbers(intArray);
            Console.WriteLine($"Pasikartojantys skaiciai: {repeatingNumbers}");

        }

        private static string Task7RepeatingNumbers(int[,] intArray)
        {
            string txt = "";
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {           
                    for (int k = 0; k < intArray.GetLength(0); k++)         // einame per visa masyva is naujo
                    {
                        for (int l = 0; l < intArray.GetLength(1); l++)
                        {
                            if (intArray[i, j] == intArray[k, l] && txt.Contains(intArray[i, j].ToString()) == false)
                                txt = txt + intArray[i, j].ToString() + " ";
                        }
                    }
                }
            }
            return txt;
        }

        /// <summary>
        /// 8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
        /// </summary>
        private static void Task8()
        {
            string[,] intArray = new string[,]
                {
                  { "Lukas", "Lukas", "Lėja", "Lukas", "Luknė" },
                  { "Nojus", "Luknė", "Lukas", "Liepa", "Herkus" },
                  { "Liepa", "Jokūbas", "Amelija", "Emilija", "Lėja" }     // kartojasi "Lukas", "Luknė", "Lėja", "Liepa"
                };

            string repeatingNames = Task8RepeatingNames(intArray);
            Console.WriteLine($"Pasikartojantys vardai: {repeatingNames}");
        }

        private static string Task8RepeatingNames(string[,] intArray)
        {
            string txt = "";
            int arrayLength1Remaining = intArray.Length;
            int arrayLength2Remaining = intArray.Length;

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    arrayLength2Remaining = intArray.Length;                // nuresetinam, nes pirma ciklu dalis pereina i nauja elementa             
                    for (int k = 0; k < intArray.GetLength(0); k++)         // einame per visa masyva is naujo
                    {
                        for (int l = 0; l < intArray.GetLength(1); l++)
                        {
                            if (intArray[i, j] == intArray[k, l] 
                                && i != k && j != l 
                                && arrayLength1Remaining > arrayLength2Remaining
                                && txt.Contains(intArray[i, j].ToString()) == false)
                                txt = txt + intArray[i, j].ToString() + " ";
                            arrayLength2Remaining--;
                        }
                    }
                    arrayLength1Remaining--;
                }
            }
            return txt;
        }
    }
}