namespace L004_type_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ===================================================================================================================
            // INPLICIT CAST (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)

            int numberINT = 100;
            long numberLONG = 100;

            long castingLONG1 = (long)numberINT;    // neryskus tekstas nera butinas // daromas INPLICIT CAST
            long castingLONG2 = numberINT;          // tipo konversija daroma automatiskai (nes konvertuoja i didesni tipa)

            var castingLONG3 = (long)numberINT;

            byte numberBYTE = 200;
            int castingINT = numberBYTE;
            long castingLONG4 = numberBYTE;
            long castingLONG5 = numberINT;

            float float1 = numberBYTE;
            float float2 = numberINT;
            float float3 = numberLONG;

            double double1 = numberBYTE;
            double double2 = numberINT;
            double double3 = numberLONG;
            double double4 = float1;

            decimal decimal1 = numberBYTE;

            // tipo konversija I DIDESTI TIPA daroma automatiskai
            // Byte -> short -> int -> long -> float -> double -> decimal 




            // ===================================================================================================================
            // EXPLICIT CAST (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)


            int castingINTEGER1 = (int)numberLONG;
            // decimal -> double -> float -> long -> int -> char

            float fl = 5.9f;
            int castingINTEGER2 = (int)fl;       // bus 5, cast i int neapvalina 
            Console.WriteLine("(int)5.9f = {0}", castingINTEGER2);

            char numberChar = 'a';
            int castingINTEGER3 = numberChar;
            Console.WriteLine("casting char to int {0}", castingINTEGER3);
            // char -> ushort -> int -> uint -> long -> ulong -> float -> double -> decimal

            long numberLong3kkk = 3_000_000_000;
            int castingINTEGER4 = (int)numberLong3kkk;                                  // didelio skaiciaus CAST i mazesni VEIKIA BLOGAI!
            Console.WriteLine("casting 3kkk to int {0}", castingINTEGER4);

            long numberLongMax = long.MaxValue;
            int castingINTEGER5 = (int)numberLongMax;                                   // didelio skaiciaus CAST i mazesni VEIKIA BLOGAI!
            Console.WriteLine("casting long.MaxValue to int {0}", castingINTEGER5);




            // =============================================================================================================================
            // TYPE CONVERSION METHODS (https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)

            string convertedString1 = Convert.ToString(numberINT);
            string convertedString2 = numberINT.ToString(); // fluent method ?
            long convertedLong1 = Convert.ToInt64(numberINT);
            double convertedDouble = Convert.ToDouble(numberINT);

            //int convertedINTEGER = Convert.ToInt32(numberLongMax);                    // !!! Cia luzta nes netelpa skaicius convertuojant !!!




            // =============================================================================================================================
            // TESTING NULLABLE TYPES
            int? numberIntNull = null;
            //long castingLong1 = (long)numberIntNull;                                  // luzta
            long convertedLong2 = Convert.ToInt64(numberIntNull);                       // neluzta, o grazina default LONG TYPE value (0)
            Console.WriteLine("Convert.ToInt64(numberIntNull) = {0}", convertedLong2);




            // =============================================================================================================================
            // PARSING

            string numberString = "100";
            string veryLongNumberString = "999999999999999999999";
            string text = "text";

            int parsedINTEGER = int.Parse(numberString);
            Console.WriteLine($"numberString + 1 = {numberString + 1}");
            Console.WriteLine($"parsedINTEGER + 1 = {parsedINTEGER + 1}");

            //int parsedToBigInt = int.Parse(veryLongNUmberString);                     // luzta
            //int parsedText = int.Parse(text);                                         // luzta






        }
    }
}