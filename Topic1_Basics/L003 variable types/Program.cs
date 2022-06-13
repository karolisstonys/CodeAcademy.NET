namespace L003_variable_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VARIABLE TYPES");


            //====================================================================================================================
            // sveikieji skaiciai 
            // NOT-NULLABLE !!!
            byte mazasSkaicius = 2;         //              MinValue = 0;               MaxValue = 255;
            short trumpasSkaicius = 2;      // (int16)      MinValue = -32,768;         MaxValue = 32,767;
            int skaicius = 2;               // (int32)      MinValue = -2,147,483,648;  MaxValue = 2,147,483,647;
            int maxIntVal = int.MaxValue;
            int minIntVal = int.MinValue;
            Console.WriteLine("INT min: {0}\nINT max: {1}", minIntVal,maxIntVal);
            long ilgasSkaicius = 2;         // (int64)      MinValue = -9223372036854775808; MaxValue = 9223372036854775807;

            // NULLABLE
            int? nullableSkaicius1 = null;
            Nullable<int> nullableSkaicius2 = null;

            // UNSIGNED TYPE - ONLY POSITIVE NUMBERS - AMOUNT STAYS THE SAME
            uint tikTeigiamasSkaicius = 2;  // (int32)      MinValue = 0;               MaxValue = 4,294,967,295;


            //====================================================================================================================
            // Floating point types
            // NOT-NULLABLE !!!
            // ROUNDING ERRORS !!!
            float maziausiasTrukmeninisSkaicius = 0.5f;
            var trukmeninisVar1 = 0.5;                      // System.Single
            var trukmeninisVar2 = 0.5f;                     // System.Float
            double trukmeninisSkaicius = 0.5;
            decimal didziausiasTrukmeninisSkaicius = 0.5m;

            // better readability
            double avogadrosSkaicius = 6.022e23;            // taip uzrasoma 6.022x10^23
            double digitalSeparator = 1_000_000.000_095;

            int trylika = 0b0001101;    // 13 binary code

            // multiple declarations
            int skaicius1, skaicius2, skaicius3;
            skaicius1 = skaicius1 = skaicius1 = 100;    // visiems skaiciams bus priskirta reiksme 100


            //====================================================================================================================
            // Logic variables
            // NOT-NULLABLE !!!
            bool teisybe = true;
            bool neteisybe = false;
            bool? nulableBool = null;


            //====================================================================================================================
            // Char variable
            // NOT-NULLABLE !!!
            char raide = 'a';   // yra vieno skaitmens tipas, nors atrodo, kad talpina raide. CHAR is similar to an INTEGER or USHORT.
            char.IsDigit(raide);
            char.IsLetter(raide);
            char.IsLetterOrDigit(raide);
            char.IsPunctuation(raide);
            // + many more ...


            //====================================================================================================================
            // DateTime variable
            // NOT-NULLABLE !!!
            DateTime siandien = DateTime.Now;   // 2022-06-08 20:34:23


            //====================================================================================================================
            // implicit "type" var
            var nulis = 0;                                              // int
            var automatinisIlgasSkaicius = 100_000_000_000_000_000;     // long
            var testas = "tekstas";                                     // string? (nullable nuo .NET6)

            var kazkokiaData = new DateTime(2022, 06, 08);
            kazkokiaData.AddDays(ilgasSkaicius);

            var floatSkaicius = 99F;


            //====================================================================================================================
            // 

            KeyValuePair<int, string> raktasIrReiksme = new KeyValuePair<int, string>(10, "Laptop");
            Console.WriteLine(raktasIrReiksme.Key);
            Console.WriteLine(raktasIrReiksme.Value);

                             var tupleVar = new Tuple<int, int, string>(20, 1500, "Laptop");
            Tuple<int, int, string> tuple = new Tuple<int, int, string>(20, 1500, "Laptop");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);

            Tuple<int, int, string, string> tuple1 = new Tuple<int, int, string, string>(20, 1500, "Laptop", "Lenovo"); //iki 7 reikšmių
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item2);
            Console.WriteLine(tuple1.Item3);
            Console.WriteLine(tuple1.Item4);



        }
    }
}