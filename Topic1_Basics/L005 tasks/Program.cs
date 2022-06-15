namespace L005_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =====================================================================================================
            // PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
            // - INT , SHORT , BYTE
            // - STEBĖTI REZULTATĄ.

            /*
            double bigTen = 1234567890;

            int intBigTen1 = (int)bigTen;
            int intBigTen2 = Convert.ToInt32(bigTen);       // luzta jei virsija 2,147,483,647

            short shortBigTen1 = (short)bigTen;
            //int shortBigTen2 = Convert.ToInt16(bigTen);   // luzta

            byte byteBigTen1 = (byte)bigTen;
            //byte byteBigTen2 = Convert.ToByte(bigTen);    // luzta

            Console.WriteLine($"                  bigTen:  {bigTen}");
            Console.WriteLine($"             (int)bigTen:  {intBigTen1}");
            Console.WriteLine($" Convert.ToInt32(bigTen):  {intBigTen2}");
            Console.WriteLine($"           (short)bigTen:  {shortBigTen1}");
            Console.WriteLine($" Convert.ToInt16(bigTen):  luzta");
            Console.WriteLine($"            (byte)bigTen:  {byteBigTen1}");
            Console.WriteLine($"  Convert.ToByte(bigTen):  luzta");
            */



            // =====================================================================================================
            // PARAŠYTI PROGRAMĄ KURI
            // PRAŠO ĮVESTI RUTULIO DIAMETRĄ,
            // O IŠVEDA PLOTĄ IR TŪRĮ

            /*
            Console.WriteLine("Iveskite rutulio diametra: ");
            double rutulioDiametras = Convert.ToDouble(Console.ReadLine());
            double rutulioSpindulys = rutulioDiametras / 2;

            double rutulioPavirsiausPlotas = 4 * 3.14 * (rutulioSpindulys * rutulioSpindulys);
            Console.WriteLine($"Rutulio pavirsiaus plotas yra {rutulioPavirsiausPlotas}");

            double rutulioTuris = (4 / 3) * 3.14 * (rutulioSpindulys * rutulioSpindulys * rutulioSpindulys);
            Console.WriteLine($"Rutulio turis yra {rutulioTuris}");
            */



            // =====================================================================================================
            // PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ(METRAIS) IR LAIKĄ(SEKUNDĖMIS),
            // - IŠVEDA GREITĮ km/h.
            // - IŠVEDA GREITĮ km/s.

            /*
            //speed = distance ÷ time


            Console.Write("Iveskite atstuma (metrais): ");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite laika (sekundemis): ");
            double seconds = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();

            double kmph = meters / seconds * 3.6;
            Console.WriteLine($"km/h yra {kmph}");

            double kmps = meters / seconds / 1000;
            Console.WriteLine($"km/s yra {kmps}");
            */



            // =====================================================================================================
            // Nuskaitykite iš klaviatūros 2 skaičius (x ir y).
            // Išveskite į ekraną funkciją y+2y+x+1 ir apskaičiuokite šios funkcijos rezultatą.
            // Išveskite į ekraną funkciją y²+x/2 apskaičiuokite šios funkcijos rezultatą.

            /*
            Console.Write("Iveskite x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double y2yx1 = y + 2 * y + x + 1;
            Console.WriteLine($"y+2y+x+1= {y2yx1}");

            double yyx2 = y * y + x / 2;
            Console.WriteLine($"y²+x/2= {yyx2}");
            */



            // =====================================================================================================
            // PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
            // VISUS ĮVESTUS 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            // PVZ BUVO ĮVESTA 12345
            // REZULTATAS 2345/2=1172,5

            /*
            Console.Write("Iveskite 5zenkli skaiciu: ");
            string penkiazenklis = Console.ReadLine();
            Console.WriteLine($"penkiazenklis: {penkiazenklis}");
            penkiazenklis = penkiazenklis.Replace("1", "0");
            Console.WriteLine($"penkiazenklis pakeitus 1 i 0: {penkiazenklis}");
            double rezultatas = (Convert.ToDouble(penkiazenklis) / 2);
            Console.WriteLine($"Atsakymas padalinus is 2: {rezultatas}");
            */



            // =====================================================================================================
            /*PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
            VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            PVZ BUVO ĮVESTA 12345
            REZULTATAS 10000/2=5000
            <HINT> naudokite replace*/

            /*
            Console.Write("Iveskite penkiazenkli skaiciu: ");
            string skaicius = Console.ReadLine();

            Console.WriteLine($"penkiazenklis sk: {skaicius}");
            skaicius = skaicius.Replace("2", "0").Replace("3", "0").Replace("4", "0").Replace("5", "0").Replace("6", "0").Replace("7", "0").Replace("8", "0").Replace("9", "0");

            Console.WriteLine($"penkiazenklis sk pakeitus visus skaicius iskyrus 1 i 0: {skaicius}");
            double rezultatas = (Convert.ToDouble(skaicius) / 2);
            Console.WriteLine($"pakeista penkiazenkli sk padalinus is 2: {rezultatas}");
            */



            // =====================================================================================================
            /*PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI SVEIKĄ SKAIČIŲ
              VIENOJE EILUTĖJE IŠVESKITE ŠĮ SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU.
              PVZ BUVO ĮVESTA 5
              REZULTATAS 6 7 8 9 10*/
            /*
            Console.Write("Iveskite viena skaitmeni: ");
            int skaicius =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            skaicius++;
            Console.WriteLine($"{skaicius++} {skaicius++} {skaicius++} {skaicius++} {skaicius}");
            */
            /*
            skaicius = skaicius+1;
            Console.Write($"{skaicius} ");

            skaicius = skaicius+1;
            Console.Write($"{skaicius} ");

            skaicius = skaicius+1;
            Console.Write($"{skaicius} ");

            skaicius = skaicius+1;
            Console.Write($"{skaicius} ");

            skaicius = skaicius+1;
            Console.Write($"{skaicius} ");
            */



            // =====================================================================================================
            // ==========================================SAVARANKISKAS DARBAS=======================================
            // =====================================================================================================
            /*
             Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 
               1 - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
               2 - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
               3 - Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
               4 - Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
               5 - Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
               6 - Nupieškite termometrą pagal Celsijų 
                 a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
                   (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
                 b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
                    <HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir .Replace(). 
                    if naudoti negalima, ternary operator (?) naudoti negalima.
             rezultatas gali atrodyti taip:
                                        |--------------------|
                                        |   ^F     _    ^C   |
                                        |  100  - | | -  40  |
                                        |   95  - | | -  35  |
                                        |   90  - | | -  30  |
                                        |   80  - | | -  25  |
                                        |   70  - | | -  20  |
                                        |   60  - | | -  15  |
                                        |   50  - |#| -  10  |
                                        |   40  - |#| -   5  |
                                        |   30  - |#| -   0  |
                                        |   20  - |#| -  -5  |
                                        |   10  - |#| - -10  |
                                        |    5  - |#| - -15  |
                                        |    0  - |#| - -20  |
                                        |  -10  - |#| - -25  |
                                        |  -20  - |#| - -30  |
                                        |  -30  - |#| - -35  |
                                        |  -40  - |#| - -40  |
                                        |        '***`       |
                                        |       (*****)      |
                                        |        `---'       |
                                        |____________________|
            
            Celsius to Fahrenheit 	° F = 9/5 ( ° C) + 32           (°C × 9/5) + 32 
            Kelvin to Fahrenheit 	° F = 9/5 (K - 273) + 32
            Fahrenheit to Celsius 	° C = 5/9 (° F - 32)
            Celsius to Kelvin 	      K = ° C + 273
            Kelvin to Celsius 	    ° C = K - 273
            Fahrenheit to Kelvin 	  K = 5/9 (° F - 32) + 273
            */

            // Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų.
            Console.Write("Enter °C: ");
            int tempC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // 1. Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
            // Celsius to Fahrenheit -> °F = 9/5 (°C) + 32
            //Console.WriteLine($"testing: 9D / 5 = {9D / 5}");
            //Console.WriteLine($"testing: tempC + 32 = {tempC + 32}");
            //Console.WriteLine($"testing: 9D / 5 * tempC + 32 = {9D / 5 * tempC + 32}");
            double tempF = 9D / 5 * tempC + 32;
            Console.WriteLine($"1. °C to °F = {tempF}");
            Console.WriteLine();

            // 2. Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
            // Celsius to Kelvin -> K = °C + 273
            int tempK = tempC + 273;
            Console.WriteLine($"2. °C to K = {tempK}");
            Console.WriteLine();

            // 3. Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
            // Fahrenheit to Celsius -> °C = 5/9 (°F - 32)
            double fahrenheitBackToCelsius = 5D * (tempF - 32D)/ 9D;
            Console.WriteLine($"3. °F back to °C = {fahrenheitBackToCelsius} ({fahrenheitBackToCelsius == tempC})");
            Console.WriteLine();

            // 4. Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
            // Kelvin to Celsius -> °C = K - 273
            int kelvinBackToCelsius = tempK - 273;
            Console.WriteLine($"4. K back to °C = {kelvinBackToCelsius} ({kelvinBackToCelsius == tempC})");
            Console.WriteLine();

            // 5. Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
            // Fahrenheit to Kelvin -> K = 5/9 (°F - 32) + 273
            double farenheitaToKelvin = 5D / 9D * (tempF - 32) + 273;
            Console.WriteLine($"5. °F to K = {farenheitaToKelvin} ({farenheitaToKelvin == tempK})");
            Console.WriteLine();

            Console.WriteLine("Click ENTER to continue...");
            Console.ReadLine();
            Console.WriteLine();

            // 6. Nupieškite termometrą pagal Celsijų 
            // a - Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
            //     (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
            // b - Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
            //     <HINT> naudokite.ToString(), palyginimo reliacinius operatorius(==, >, < ir t.t.) ir.Replace().
            Console.WriteLine("6.");

            // Celsius number column
            var c17 = tempC + 40;
            var c16 = tempC + 35;
            var c15 = tempC + 30;
            var c14 = tempC + 25;
            var c13 = tempC + 20;
            var c12 = tempC + 15;
            var c11 = tempC + 10;
            var c10 = tempC + 5;
            var c09 = tempC;
            var c08 = tempC - 5;
            var c07 = tempC - 10;
            var c06 = tempC - 15;
            var c05 = tempC - 20;
            var c04 = tempC - 25;
            var c03 = tempC - 30;
            var c02 = tempC - 35;
            var c01 = tempC - 40;

            // Fahrenheit number column
            var f17 = 9D / 5 * c17 + 32;
            var f16 = 9D / 5 * c16 + 32;
            var f15 = 9D / 5 * c15 + 32;
            var f14 = 9D / 5 * c14 + 32;
            var f13 = 9D / 5 * c13 + 32;
            var f12 = 9D / 5 * c12 + 32;
            var f11 = 9D / 5 * c11 + 32;
            var f10 = 9D / 5 * c10 + 32;
            var f09 = 9D / 5 * c09 + 32;
            var f08 = 9D / 5 * c08 + 32;
            var f07 = 9D / 5 * c07 + 32;
            var f06 = 9D / 5 * c06 + 32;
            var f05 = 9D / 5 * c05 + 32;
            var f04 = 9D / 5 * c04 + 32;
            var f03 = 9D / 5 * c03 + 32;
            var f02 = 9D / 5 * c02 + 32;
            var f01 = 9D / 5 * c01 + 32;

            // Kelvin number column
            var k17 = c17 + 273;
            var k16 = c16 + 273;
            var k15 = c15 + 273;
            var k14 = c14 + 273;
            var k13 = c13 + 273;
            var k12 = c12 + 273;
            var k11 = c11 + 273;
            var k10 = c10 + 273;
            var k09 = c09 + 273;
            var k08 = c08 + 273;
            var k07 = c07 + 273;
            var k06 = c06 + 273;
            var k05 = c05 + 273;
            var k04 = c04 + 273;
            var k03 = c03 + 273;
            var k02 = c02 + 273;
            var k01 = c01 + 273;

            // Filling termometer with "*" till entered °C value is reached
            var t17 = Convert.ToString(tempC >= c17).Replace("True", "░").Replace("False", " ");
            var t16 = Convert.ToString(tempC >= c16).Replace("True", "░").Replace("False", " ");
            var t15 = Convert.ToString(tempC >= c15).Replace("True", "░").Replace("False", " ");
            var t14 = Convert.ToString(tempC >= c14).Replace("True", "░").Replace("False", " ");
            var t13 = Convert.ToString(tempC >= c13).Replace("True", "░").Replace("False", " ");
            var t12 = Convert.ToString(tempC >= c12).Replace("True", "░").Replace("False", " ");
            var t11 = Convert.ToString(tempC >= c11).Replace("True", "░").Replace("False", " ");
            var t10 = Convert.ToString(tempC >= c10).Replace("True", "░").Replace("False", " ");
            var t09 = Convert.ToString(tempC >= c09).Replace("True", "░").Replace("False", " ");
            var t08 = Convert.ToString(tempC >= c08).Replace("True", "░").Replace("False", " ");
            var t07 = Convert.ToString(tempC >= c07).Replace("True", "░").Replace("False", " ");
            var t06 = Convert.ToString(tempC >= c06).Replace("True", "░").Replace("False", " ");
            var t05 = Convert.ToString(tempC >= c05).Replace("True", "░").Replace("False", " ");
            var t04 = Convert.ToString(tempC >= c04).Replace("True", "░").Replace("False", " ");
            var t03 = Convert.ToString(tempC >= c03).Replace("True", "░").Replace("False", " ");
            var t02 = Convert.ToString(tempC >= c02).Replace("True", "░").Replace("False", " ");
            var t01 = Convert.ToString(tempC >= c01).Replace("True", "░").Replace("False", " ");

            // Drawing
            Console.WriteLine("\t°F\t┌─┐\t°C\t┌─┐\t K");
            Console.WriteLine($"\t{f17}\t|{t17}|\t{c17}\t|{t17}|\t{k17}");
            Console.WriteLine($"\t{f16}\t|{t16}|\t{c16}\t|{t16}|\t{k16}");
            Console.WriteLine($"\t{f15}\t|{t15}|\t{c15}\t|{t15}|\t{k15}");
            Console.WriteLine($"\t{f14}\t|{t14}|\t{c14}\t|{t14}|\t{k14}");
            Console.WriteLine($"\t{f13}\t|{t13}|\t{c13}\t|{t13}|\t{k13}");
            Console.WriteLine($"\t{f12}\t|{t12}|\t{c12}\t|{t12}|\t{k12}");
            Console.WriteLine($"\t{f11}\t|{t11}|\t{c11}\t|{t11}|\t{k11}");
            Console.WriteLine($"\t{f10}\t|{t10}|\t{c10}\t|{t10}|\t{k10}");
            Console.WriteLine($"\t{f09}\t|{t09}|\t{c09}\t|{t09}|\t{k09}");
            Console.WriteLine($"\t{f08}\t|{t08}|\t{c08}\t|{t08}|\t{k08}");
            Console.WriteLine($"\t{f07}\t|{t07}|\t{c07}\t|{t07}|\t{k07}");
            Console.WriteLine($"\t{f06}\t|{t06}|\t{c06}\t|{t06}|\t{k06}");
            Console.WriteLine($"\t{f05}\t|{t05}|\t{c05}\t|{t05}|\t{k05}");
            Console.WriteLine($"\t{f04}\t|{t04}|\t{c04}\t|{t04}|\t{k04}");
            Console.WriteLine($"\t{f03}\t|{t03}|\t{c03}\t|{t03}|\t{k03}");
            Console.WriteLine($"\t{f02}\t|{t02}|\t{c02}\t|{t02}|\t{k02}");
            Console.WriteLine($"\t{f01}\t|{t01}|\t{c01}\t|{t01}|\t{k01}");
            Console.WriteLine("\t     ┌──┘░└─────────────┘░└──┐");
            Console.WriteLine("\t     │░░░░░░TEMPERATURE░░░░░░│");
            Console.WriteLine("\t     └───────────────────────┘");



        }
    }
}