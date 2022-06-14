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
            
            Celsius to Fahrenheit 	° F = 9/5 ( ° C) + 32
            Kelvin to Fahrenheit 	° F = 9/5 (K - 273) + 32
            Fahrenheit to Celsius 	° C = 5/9 (° F - 32)
            Celsius to Kelvin 	      K = ° C + 273
            Kelvin to Celsius 	    ° C = K - 273
            Fahrenheit to Kelvin 	  K = 5/9 (° F - 32) + 273
            */

            // Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų.
            Console.Write("Iveskite °C: ");
            double tempC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // 1. Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
            double tempF = (double)9 / 5 * tempC + 32;
            Console.WriteLine($"1. Fahrenheit: {tempF}");
            Console.WriteLine();

            // 2. Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
            double tempK = tempC + 273;
            Console.WriteLine($"2. Kelvin: {tempK}");
            Console.WriteLine();

            // 3. Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
            double fahrenheitBackToCelsius = (double)5 / 9 * (tempF - 32);
            Console.WriteLine($"fahrenheitBackToCelsius: {fahrenheitBackToCelsius}");
            Console.WriteLine($"3. {fahrenheitBackToCelsius == tempC}");
            Console.WriteLine();

            // 4. Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
            double kelvinBackToCelsius = tempK - 273;
            Console.WriteLine($"kelvinBackToCelsius: {kelvinBackToCelsius}");
            Console.WriteLine($"4. {kelvinBackToCelsius == tempC}");
            Console.WriteLine();

            // 5. Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
            double farenheitaToKelvin = (double)5 / 9 * (tempF - 32) + 273;
            Console.WriteLine($"farenheitaToKelvin: {farenheitaToKelvin}");
            Console.WriteLine($"5. {farenheitaToKelvin == tempK}");
            Console.WriteLine();

            // 6. Nupieškite termometrą pagal Celsijų 
            // a - Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
            //     (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
            // b - Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
            //     <HINT> naudokite.ToString(), palyginimo reliacinius operatorius(==, >, < ir t.t.) ir.Replace().
            Console.WriteLine("6.");

            var cu8 = tempC + 40;
            var cu7 = tempC + 35;
            var cu6 = tempC + 30;
            var cu5 = tempC + 25;
            var cu4 = tempC + 20;
            var cu3 = tempC + 15;
            var cu2 = tempC + 10;
            var cu1 = tempC + 5;
            var c00 = tempC;
            var cd1 = tempC - 5;
            var cd2 = tempC - 10;
            var cd3 = tempC - 15;
            var cd4 = tempC - 20;
            var cd5 = tempC - 25;
            var cd6 = tempC - 30;
            var cd7 = tempC - 35;
            var cd8 = tempC - 40;

            var fu8 = (double)9 / 5 * cu8 + 32;
            var fu7 = (double)9 / 5 * cu7 + 32;
            var fu6 = (double)9 / 5 * cu6 + 32;
            var fu5 = (double)9 / 5 * cu5 + 32;
            var fu4 = (double)9 / 5 * cu4 + 32;
            var fu3 = (double)9 / 5 * cu3 + 32;
            var fu2 = (double)9 / 5 * cu2 + 32;
            var fu1 = (double)9 / 5 * cu1 + 32;
            var f00 = (double)9 / 5 * c00 + 32;
            var fd1 = (double)9 / 5 * cd1 + 32;
            var fd2 = (double)9 / 5 * cd2 + 32;
            var fd3 = (double)9 / 5 * cd3 + 32;
            var fd4 = (double)9 / 5 * cd4 + 32;
            var fd5 = (double)9 / 5 * cd5 + 32;
            var fd6 = (double)9 / 5 * cd6 + 32;
            var fd7 = (double)9 / 5 * cd7 + 32;
            var fd8 = (double)9 / 5 * cd8 + 32;

            var t17 = Convert.ToString(tempC >= cu8).Replace("True","*").Replace("False", " ");
            var t16 = Convert.ToString(tempC >= cu7).Replace("True", "*").Replace("False", " ");
            var t15 = Convert.ToString(tempC >= cu6).Replace("True", "*").Replace("False", " ");
            var t14 = Convert.ToString(tempC >= cu5).Replace("True", "*").Replace("False", " ");
            var t13 = Convert.ToString(tempC >= cu4).Replace("True", "*").Replace("False", " ");
            var t12 = Convert.ToString(tempC >= cu3).Replace("True", "*").Replace("False", " ");
            var t11 = Convert.ToString(tempC >= cu2).Replace("True", "*").Replace("False", " ");
            var t10 = Convert.ToString(tempC >= cu1).Replace("True", "*").Replace("False", " ");
            var t09 = Convert.ToString(tempC >= c00).Replace("True", "*").Replace("False", " ");
            var t08 = Convert.ToString(tempC >= cd1).Replace("True", "*").Replace("False", " ");
            var t07 = Convert.ToString(tempC >= cd2).Replace("True", "*").Replace("False", " ");
            var t06 = Convert.ToString(tempC >= cd3).Replace("True", "*").Replace("False", " ");
            var t05 = Convert.ToString(tempC >= cd4).Replace("True", "*").Replace("False", " ");
            var t04 = Convert.ToString(tempC >= cd5).Replace("True", "*").Replace("False", " ");
            var t03 = Convert.ToString(tempC >= cd6).Replace("True", "*").Replace("False", " ");
            var t02 = Convert.ToString(tempC >= cd7).Replace("True", "*").Replace("False", " ");
            var t01 = Convert.ToString(tempC >= cd8).Replace("True", "*").Replace("False", " ");

            Console.WriteLine("\t\t(+)\t");
            Console.WriteLine($"\t{fu8}\t|{t17}|\t{cu8}");
            Console.WriteLine($"\t{fu7}\t|{t16}|\t{cu7}");
            Console.WriteLine($"\t{fu6}\t|{t15}|\t{cu6}");
            Console.WriteLine($"\t{fu5}\t|{t14}|\t{cu5}");
            Console.WriteLine($"\t{fu4}\t|{t13}|\t{cu4}");
            Console.WriteLine($"\t{fu3}\t|{t12}|\t{cu3}");
            Console.WriteLine($"\t{fu2}\t|{t11}|\t{cu2}");
            Console.WriteLine($"\t{fu1}\t|{t10}|\t{cu1}");
            Console.WriteLine($"\t{f00}\t|{t09}|\t{c00}");
            Console.WriteLine($"\t{fd1}\t|{t08}|\t{cd1}");
            Console.WriteLine($"\t{fd2}\t|{t07}|\t{cd2}");
            Console.WriteLine($"\t{fd3}\t|{t06}|\t{cd3}");
            Console.WriteLine($"\t{fd4}\t|{t05}|\t{cd4}");
            Console.WriteLine($"\t{fd5}\t|{t04}|\t{cd5}");
            Console.WriteLine($"\t{fd6}\t|{t03}|\t{cd6}");
            Console.WriteLine($"\t{fd7}\t|{t02}|\t{cd7}");
            Console.WriteLine($"\t{fd8}\t|{t01}|\t{cd8}");
            Console.WriteLine("\t       '***'");
            Console.WriteLine("\t      (*****) ");
            Console.WriteLine("\t       '---' ");



        }
    }
}