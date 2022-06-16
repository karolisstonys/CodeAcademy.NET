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
            // ==========================================SAVARANKISKAS DARBAS 1=====================================
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



            /*
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
            Console.WriteLine("\t  °F\t┌─┐\t  °C\t┌─┐\t   K");
            Console.WriteLine($"\t{f17,4:0}\t|{t17}|\t{c17,4:0}\t|{t17}|\t{k17,4:0}");
            Console.WriteLine($"\t{f16,4:0}\t|{t16}|\t{c16,4:0}\t|{t16}|\t{k16,4:0}");
            Console.WriteLine($"\t{f15,4:0}\t|{t15}|\t{c15,4:0}\t|{t15}|\t{k15,4:0}");
            Console.WriteLine($"\t{f14,4:0}\t|{t14}|\t{c14,4:0}\t|{t14}|\t{k14,4:0}");
            Console.WriteLine($"\t{f13,4:0}\t|{t13}|\t{c13,4:0}\t|{t13}|\t{k13,4:0}");
            Console.WriteLine($"\t{f12,4:0}\t|{t12}|\t{c12,4:0}\t|{t12}|\t{k12,4:0}");
            Console.WriteLine($"\t{f11,4:0}\t|{t11}|\t{c11,4:0}\t|{t11}|\t{k11,4:0}");
            Console.WriteLine($"\t{f10,4:0}\t|{t10}|\t{c10,4:0}\t|{t10}|\t{k10,4:0}");
            Console.WriteLine($"\t{f09,4:0}\t|{t09}|\t{c09,4:0}\t|{t09}|\t{k09,4:0}");
            Console.WriteLine($"\t{f08,4:0}\t|{t08}|\t{c08,4:0}\t|{t08}|\t{k08,4:0}");
            Console.WriteLine($"\t{f07,4:0}\t|{t07}|\t{c07,4:0}\t|{t07}|\t{k07,4:0}");
            Console.WriteLine($"\t{f06,4:0}\t|{t06}|\t{c06,4:0}\t|{t06}|\t{k06,4:0}");
            Console.WriteLine($"\t{f05,4:0}\t|{t05}|\t{c05,4:0}\t|{t05}|\t{k05,4:0}");
            Console.WriteLine($"\t{f04,4:0}\t|{t04}|\t{c04,4:0}\t|{t04}|\t{k04,4:0}");
            Console.WriteLine($"\t{f03,4:0}\t|{t03}|\t{c03,4:0}\t|{t03}|\t{k03,4:0}");
            Console.WriteLine($"\t{f02,4:0}\t|{t02}|\t{c02,4:0}\t|{t02}|\t{k02,4:0}");
            Console.WriteLine($"\t{f01,4:0}\t|{t01}|\t{c01,4:0}\t|{t01}|\t{k01,4:0}");
            Console.WriteLine("\t     ┌──┘░└─────────────┘░└──┐");
            Console.WriteLine("\t     │░░░░░░TEMPERATURE░░░░░░│");
            Console.WriteLine("\t     └───────────────────────┘");


            */


            // =====================================================================================================
            // ==========================================SAVARANKISKAS DARBAS 2=====================================
            // =====================================================================================================
            /*
             PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H). 
             VIENA TRANSPORTO PRIEMONĖS PRADEDA VAŽIUOTI IŠ A, KITA IŠ B.STARTUOJA VIENU METU.
             ! - PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS. 
             ! - PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS. 
             ! - PASKAIČIUOTI LAIKĄ, KADA TRASPORTUO PRIEMONĖS PASIEKS GALIUTINIUS TAŠKUS MINUTĖMIS.
             ! - PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.
              - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
                A) PARODYTI VISO KELIO ILGĮ KM
                B) PARODYTI SEGMENTO ILGĮ KM
                C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
                D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
                REZULTATAS GALI ARTODYTI TAIP:
               viso 100 km

             |--------------------------------------------------------------------------------------------------------------------------------------------|
             0      5     10     15     20      25     30     35     40     45     50     55     60     65     70     75     80     85     90     95    100
             |      |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
            _A______|______|______|______|___V___|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______B_
             |-------------------------------|       
            
               susitikimo vieta 23,1 km
               susitikimo laikas po 0,87 val.

             | >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   200 min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|
             |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   60 min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< |
            */

            Console.WriteLine("|------------KM--------------|");
            Console.WriteLine("A----------->  <-------------B");
            Console.WriteLine();
            Console.Write("Iveskite atstuma (km): ");
            int distance = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Iveskite transporto priemones A greiti (km/h): ");
            int akmph = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite transporto priemones B greiti (km/h): ");
            int bkmph = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Atstumas - {distance}, A - {akmph}km/h, B - {bkmph}km/h.");
            Console.WriteLine();

            // TIME TILL CARS MEET
            decimal hoursTillMeet = (decimal)distance / (akmph + bkmph);
            Console.WriteLine($"Time till meet {hoursTillMeet:0.00} hours.");
            Console.WriteLine($"Time till meet {(hoursTillMeet * 3600):0} seconds.");
            Console.WriteLine();

            // DISTANCE FROM A WHEN CARS MEET
            var fromAtoMeet = akmph * hoursTillMeet;
            Console.WriteLine($"Car A travels {(akmph * hoursTillMeet):0.00} km till it meets car B.");
            Console.WriteLine($"Car B travels {(bkmph * hoursTillMeet):0.00} km till it meets car A.");
            Console.WriteLine($"Distance from A to meeting point is {(akmph * hoursTillMeet * 1000):0} meters.");
            Console.WriteLine();

            // WHEN BOTH CARS REACH END DESTINATION
            Console.WriteLine($"Car A will take {((decimal)distance / akmph * 60):0.} minutes to reach the end destination.");
            Console.WriteLine($"Car B will take {((decimal)distance / bkmph * 60):0.} minutes to reach the end destination.");
            Console.WriteLine();

            // CO2 EMISSIONS
            Console.WriteLine($"To travel {distance}km each car will emit {(distance * 95):0.}g of CO2.");
            Console.WriteLine();

            // VISUALISATION
            // divides total distance into 20 equal range segments and outputs it to console
            var segmentLength = (decimal)distance / 20;
            var marker0 = 0;
            var marker1 = 1 * segmentLength;
            var marker2 = 2 * segmentLength;
            var marker3 = 3 * segmentLength;
            var marker4 = 4 * segmentLength;
            var marker5 = 5 * segmentLength;
            var marker6 = 6 * segmentLength;
            var marker7 = 7 * segmentLength;
            var marker8 = 8 * segmentLength;
            var marker9 = 9 * segmentLength;
            var marker10 = 10 * segmentLength;
            var marker11 = 11 * segmentLength;
            var marker12 = 12 * segmentLength;
            var marker13 = 13 * segmentLength;
            var marker14 = 14 * segmentLength;
            var marker15 = 15 * segmentLength;
            var marker16 = 16 * segmentLength;
            var marker17 = 17 * segmentLength;
            var marker18 = 18 * segmentLength;
            var marker19 = 19 * segmentLength;
            var marker20 = 20 * segmentLength;

            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"{marker0}{marker1,7}{marker2,7}{marker3,7}{marker4,7}{marker5,7}{marker6,7}{marker7,7}{marker8,7}{marker9,7}{marker10,7}" +
                              $"{marker11,7}{marker12,7}{marker13,7}{marker14,7}{marker15,7}{marker16,7}{marker17,7}{marker18,7}{marker19,7}{marker20,7}");
            Console.WriteLine("|      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |");
            
            // checks if meeting point is further than marker0 and closer or at marker1
            // sets TRUE for segment only where cars meet 
            // checking every marker pair         
            var segment1 = Convert.ToString(0 < fromAtoMeet && fromAtoMeet <= marker1).Replace("False", "A------|").Replace("True", "A--><--|");    // cannot be 0 sadly, cannot divide by 0
            var segment2 = Convert.ToString(marker1 < fromAtoMeet && fromAtoMeet <= marker2).Replace("False", "------|").Replace("True", "--><--|");
            var segment3 = Convert.ToString(marker2 < fromAtoMeet && fromAtoMeet <= marker3).Replace("False", "------|").Replace("True", "--><--|");
            var segment4 = Convert.ToString(marker3 < fromAtoMeet && fromAtoMeet <= marker4).Replace("False", "------|").Replace("True", "--><--|");
            var segment5 = Convert.ToString(marker4 < fromAtoMeet && fromAtoMeet <= marker5).Replace("False", "------|").Replace("True", "--><--|");
            var segment6 = Convert.ToString(marker5 < fromAtoMeet && fromAtoMeet <= marker6).Replace("False", "------|").Replace("True", "--><--|");
            var segment7 = Convert.ToString(marker6 < fromAtoMeet && fromAtoMeet <= marker7).Replace("False", "------|").Replace("True", "--><--|");
            var segment8 = Convert.ToString(marker7 < fromAtoMeet && fromAtoMeet <= marker8).Replace("False", "------|").Replace("True", "--><--|");
            var segment9 = Convert.ToString(marker8 < fromAtoMeet && fromAtoMeet <= marker9).Replace("False", "------|").Replace("True", "--><--|");
            var segment10 = Convert.ToString(marker9 < fromAtoMeet && fromAtoMeet <= marker10).Replace("False", "------|").Replace("True", "--><--|");
            var segment11 = Convert.ToString(marker10 < fromAtoMeet && fromAtoMeet <= marker11).Replace("False", "------|").Replace("True", "--><--|");
            var segment12 = Convert.ToString(marker11 < fromAtoMeet && fromAtoMeet <= marker12).Replace("False", "------|").Replace("True", "--><--|");
            var segment13 = Convert.ToString(marker12 < fromAtoMeet && fromAtoMeet <= marker13).Replace("False", "------|").Replace("True", "--><--|");
            var segment14 = Convert.ToString(marker13 < fromAtoMeet && fromAtoMeet <= marker14).Replace("False", "------|").Replace("True", "--><--|");
            var segment15 = Convert.ToString(marker14 < fromAtoMeet && fromAtoMeet <= marker15).Replace("False", "------|").Replace("True", "--><--|");
            var segment16 = Convert.ToString(marker15 < fromAtoMeet && fromAtoMeet <= marker16).Replace("False", "------|").Replace("True", "--><--|");
            var segment17 = Convert.ToString(marker16 < fromAtoMeet && fromAtoMeet <= marker17).Replace("False", "------|").Replace("True", "--><--|");
            var segment18 = Convert.ToString(marker17 < fromAtoMeet && fromAtoMeet <= marker18).Replace("False", "------|").Replace("True", "--><--|");
            var segment19 = Convert.ToString(marker18 < fromAtoMeet && fromAtoMeet <= marker19).Replace("False", "------|").Replace("True", "--><--|");
            var segment20 = Convert.ToString(marker19 < fromAtoMeet && fromAtoMeet <= marker20).Replace("False", "------B").Replace("True", "--><--B");

            Console.WriteLine($"{segment1}{segment2}{segment3}{segment4}{segment5}{segment6}{segment7}{segment8}{segment9}{segment10}" +
                              $"{segment11}{segment12}{segment13}{segment14}{segment15}{segment16}{segment17}{segment18}{segment19}{segment20}");

            // checks if (meeting point is further than marker0 and closer or at marker1) OR (meeting point is further or at marker1)
            // sets TRUE for all traveling distance for car A till meeting point
            // checking every marker pair
            var bar1 = Convert.ToString(0 < fromAtoMeet && fromAtoMeet <= marker1 || fromAtoMeet >= marker1).Replace("False", "        ").Replace("True", "░░░░░░░░");  // cannot be 0 sadly, cannot divide by 0
            var bar2 = Convert.ToString(marker1 < fromAtoMeet && fromAtoMeet <= marker2 || fromAtoMeet >= marker2).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar3 = Convert.ToString(marker2 < fromAtoMeet && fromAtoMeet <= marker3 || fromAtoMeet >= marker3).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar4 = Convert.ToString(marker3 < fromAtoMeet && fromAtoMeet <= marker4 || fromAtoMeet >= marker4).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar5 = Convert.ToString(marker4 < fromAtoMeet && fromAtoMeet <= marker5 || fromAtoMeet >= marker5).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar6 = Convert.ToString(marker5 < fromAtoMeet && fromAtoMeet <= marker6 || fromAtoMeet >= marker6).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar7 = Convert.ToString(marker6 < fromAtoMeet && fromAtoMeet <= marker7 || fromAtoMeet >= marker7).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar8 = Convert.ToString(marker7 < fromAtoMeet && fromAtoMeet <= marker8 || fromAtoMeet >= marker8).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar9 = Convert.ToString(marker8 < fromAtoMeet && fromAtoMeet <= marker9 || fromAtoMeet >= marker9).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar10 = Convert.ToString(marker9 < fromAtoMeet && fromAtoMeet <= marker10 || fromAtoMeet >= marker10).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar11 = Convert.ToString(marker10 < fromAtoMeet && fromAtoMeet <= marker11 || fromAtoMeet >= marker11).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar12 = Convert.ToString(marker11 < fromAtoMeet && fromAtoMeet <= marker12 || fromAtoMeet >= marker12).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar13 = Convert.ToString(marker12 < fromAtoMeet && fromAtoMeet <= marker13 || fromAtoMeet >= marker13).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar14 = Convert.ToString(marker13 < fromAtoMeet && fromAtoMeet <= marker14 || fromAtoMeet >= marker14).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar15 = Convert.ToString(marker14 < fromAtoMeet && fromAtoMeet <= marker15 || fromAtoMeet >= marker15).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar16 = Convert.ToString(marker15 < fromAtoMeet && fromAtoMeet <= marker16 || fromAtoMeet >= marker16).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar17 = Convert.ToString(marker16 < fromAtoMeet && fromAtoMeet <= marker17 || fromAtoMeet >= marker17).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar18 = Convert.ToString(marker17 < fromAtoMeet && fromAtoMeet <= marker18 || fromAtoMeet >= marker18).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar19 = Convert.ToString(marker18 < fromAtoMeet && fromAtoMeet <= marker19 || fromAtoMeet >= marker19).Replace("False", "       ").Replace("True", "░░░░░░░");
            var bar20 = Convert.ToString(marker19 < fromAtoMeet && fromAtoMeet <= marker20 || fromAtoMeet >= marker20).Replace("False", "       ").Replace("True", "░░░░░░░");


            // finds exact variable bar where cars meet and modifies it
            bar1 = (bar1 + Convert.ToString(0 < fromAtoMeet && fromAtoMeet <= marker1)).Replace("False", "").Replace("░░░░░░░░True", "░░>     ");  // cannot be 0 sadly, cannot divide by 0
            bar2 = (bar2 + Convert.ToString(marker1 < fromAtoMeet && fromAtoMeet <= marker2)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar3 = (bar3 + Convert.ToString(marker2 < fromAtoMeet && fromAtoMeet <= marker3)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar4 = (bar4 + Convert.ToString(marker3 < fromAtoMeet && fromAtoMeet <= marker4)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar5 = (bar5 + Convert.ToString(marker4 < fromAtoMeet && fromAtoMeet <= marker5)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar6 = (bar6 + Convert.ToString(marker5 < fromAtoMeet && fromAtoMeet <= marker6)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar7 = (bar7 + Convert.ToString(marker6 < fromAtoMeet && fromAtoMeet <= marker7)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar8 = (bar8 + Convert.ToString(marker7 < fromAtoMeet && fromAtoMeet <= marker8)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar9 = (bar9 + Convert.ToString(marker8 < fromAtoMeet && fromAtoMeet <= marker9)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar10 = (bar10 + Convert.ToString(marker9 < fromAtoMeet && fromAtoMeet <= marker10)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar11 = (bar11 + Convert.ToString(marker10 < fromAtoMeet && fromAtoMeet <= marker11)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar12 = (bar12 + Convert.ToString(marker11 < fromAtoMeet && fromAtoMeet <= marker12)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar13 = (bar13 + Convert.ToString(marker12 < fromAtoMeet && fromAtoMeet <= marker13)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar14 = (bar14 + Convert.ToString(marker13 < fromAtoMeet && fromAtoMeet <= marker14)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar15 = (bar15 + Convert.ToString(marker14 < fromAtoMeet && fromAtoMeet <= marker15)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar16 = (bar16 + Convert.ToString(marker15 < fromAtoMeet && fromAtoMeet <= marker16)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar17 = (bar17 + Convert.ToString(marker16 < fromAtoMeet && fromAtoMeet <= marker17)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar18 = (bar18 + Convert.ToString(marker17 < fromAtoMeet && fromAtoMeet <= marker18)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar19 = (bar19 + Convert.ToString(marker18 < fromAtoMeet && fromAtoMeet <= marker19)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");
            bar20 = (bar20 + Convert.ToString(marker19 < fromAtoMeet && fromAtoMeet <= marker20)).Replace("False", "").Replace("░░░░░░░True", "░░>     ");


            Console.WriteLine($"{bar1}{bar2}{bar3}{bar4}{bar5}{bar6}{bar7}{bar8}{bar9}{bar10}" +
                              $"{bar11}{bar12}{bar13}{bar14}{bar15}{bar16}{bar17}{bar18}{bar19}{bar20}");

            Console.WriteLine();
            Console.WriteLine($"Susirikimo vieta {fromAtoMeet:0.0} km.");
            Console.WriteLine($"Susirikimo laikas {hoursTillMeet:0.0} val.");

            Console.WriteLine();
            Console.WriteLine($"A > > > > > > > > > > > > > > > > > > > > > > > > > > > {((decimal)distance / akmph * 60),4:0.}min > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > > |");
            Console.WriteLine($"| < < < < < < < < < < < < < < < < < < < < < < < < < < < {((decimal)distance / bkmph * 60),4:0.}min < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < < B");

        }
    }
}