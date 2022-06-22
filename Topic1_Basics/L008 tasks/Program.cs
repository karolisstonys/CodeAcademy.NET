namespace L008_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =================================================================================================================================
            /*
             PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
            EGZAMINO PAŽYMĮ. IŠVESTI:
            0 - 4: NEPATEKINAMAI
            5: SILPNAI
            6: PATENKINAMAI
            7: VIDUTINIŠKAI
            8: GERAI
            9: LABAI GERAI
            10: PUIKIAI
            */

            /*
            Console.Write("ĮVESTI EGZAMINO PAŽYMĮ: ");
            bool arGerasSkaicius = uint.TryParse(Console.ReadLine(), out var paz);      // patikriname ar ivestas yra teigiamas skaicius

            if (arGerasSkaicius)
            {
                // variantas su switch
                switch (paz)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("NEPATEKINAMAI");     // 0 - 4
                        break;

                    case 5:
                        Console.WriteLine("SILPNAI");
                        break;
                    case 6:
                        Console.WriteLine("PATENKINAMAI");
                        break;
                    case 7:
                        Console.WriteLine("VIDUTINIŠKAI");
                        break;
                    case 8:
                        Console.WriteLine("GERAI");
                        break;
                    case 9:
                        Console.WriteLine("LABAI GERAI");
                        break;
                    case 10:
                        Console.WriteLine("PUIKIAI");
                        break;
                }

                // variantas su if else
                if (paz >= 0 && paz <= 4)
                {
                    Console.WriteLine("NEPATEKINAMAI");
                }
                else if (paz == 5)
                {
                    Console.WriteLine("SILPNAI");
                }
                else if (paz == 6)
                {
                    Console.WriteLine("PATENKINAMAI");
                }
                else if (paz == 7)
                {
                    Console.WriteLine("VIDUTINIŠKAI");
                }
                else if (paz == 8)
                {
                    Console.WriteLine("GERAI");
                }
                else if (paz == 9)
                {
                    Console.WriteLine("LABAI GERAI");
                }
                else if (paz == 10)
                {
                    Console.WriteLine("PUIKIAI");
                }

                // variantas su switch (2)
                var rez = paz switch
                {
                    0 or 1 or 2 or 3 or 4 => "NEPATEKINAMAI",
                    5 => "SILPNAI",
                    6 => "PATENKINAMAI",
                    7 => "VIDUTINIŠKAI",
                    8 => "GERAI",
                    9 => "LABAI GERAI",
                    10 => "PUIKIAI",
                    _ => null
                };
                Console.WriteLine(rez);
            }
            else
            {
                Console.WriteLine("Klaida - blogas ivedimas");
            }
            */





            // =================================================================================================================================
            /*
            ** Nemokama kava **
            Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
            Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
            - Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
            - Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"
            */

            /*
            Console.Write("Kiek kavos pirksite: ");
            int coffee = Convert.ToInt32(Console.ReadLine());

            if (coffee >= 3)
            {
                int nemokama = coffee / 3;
                Console.WriteLine($"Jums nemokamai priklauso {nemokama}vnt kavos");
            }
            else
            {
                Console.WriteLine("Pirkėjui nepriklauso nemokama kava");
            }
            */

            // =================================================================================================================================
            /*
            ** Piešingi skaičiai **
            Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
            - Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
            - Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;*/
            /*
            Console.Write("skaicius 1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("skaicius 2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("skaicius 3: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("skaicius 4: ");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            //string skaicius1kitaip = "N/A";
            //string skaicius2kitaip = "N/A";
            //string skaicius3kitaip = "N/A";
            //string skaicius4kitaip = "N/A";

            //if (skaicius1 != 0)
            //{
            //    skaicius1kitaip = Convert.ToString(skaicius1 * -1);
            //}

            //if (skaicius2 != 0)
            //{
            //    skaicius2kitaip = Convert.ToString(skaicius2 * -1);
            //}

            //if (skaicius3 != 0)
            //{
            //    skaicius3kitaip = Convert.ToString(skaicius3 * -1);
            //}

            //if (skaicius4 != 0)
            //{
            //    skaicius4kitaip = Convert.ToString(skaicius4 * -1);
            //}

            //Console.WriteLine($"{skaicius1} -> {skaicius1kitaip}\n{skaicius2} -> {skaicius2kitaip}\n{skaicius3} -> {skaicius3kitaip}\n{skaicius4} -> {skaicius4kitaip}");

            Console.WriteLine(skaicius1 != 0 ? $"{skaicius1} -> {skaicius1 * -1}" : "0 -> N/A");
            Console.WriteLine(skaicius2 != 0 ? $"{skaicius2} -> {skaicius2 * -1}" : "0 -> N/A");
            Console.WriteLine(skaicius3 != 0 ? $"{skaicius3} -> {skaicius3 * -1}" : "0 -> N/A");
            Console.WriteLine(skaicius4 != 0 ? $"{skaicius4} -> {skaicius4 * -1}" : "0 -> N/A");
            */



            // =================================================================================================================================
            /*
             ŽAIDIMAS ATSPĖK SKAIČIŲ
            - ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
            - NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
            - JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
            - JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
            - JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
            nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.
             */

            /*
            //Random rnd = new Random();
            //int atspek = rnd.Next(1, 20);
            int atspek = 10;

            Console.Write("Atspek skaiciu nuo 1 iki 20: ");
            int spejimas = Convert.ToInt32(Console.ReadLine());

            if (spejimas == atspek && !(spejimas < 1 || spejimas > 20))
            {
                Console.WriteLine("TEISINGAI");
            }
            else
            {
                if (spejimas < 1 || spejimas > 20)
                {
                    Console.WriteLine("KLAIDA");
                }
                else
                {
                    Console.WriteLine(spejimas > atspek ? "SKAIČIUS YRA MAŽESNIS" : "SKAIČIUS YRA DIDESNIS");
                    Console.WriteLine($"Bandykite speti dar darta (liko 5 spejimai): ");
                    spejimas = Convert.ToInt32(Console.ReadLine());

                    if (spejimas == atspek && !(spejimas < 1 || spejimas > 20))
                    {
                        Console.WriteLine("TEISINGAI");
                    }
                    else
                    {
                        if (spejimas < 1 || spejimas > 20)
                        {
                            Console.WriteLine("KLAIDA");
                        }
                        else
                        {
                            Console.WriteLine(spejimas > atspek ? "SKAIČIUS YRA MAŽESNIS" : "SKAIČIUS YRA DIDESNIS");
                            Console.WriteLine($"Bandykite speti dar darta (liko 4 spejimai): ");
                            spejimas = Convert.ToInt32(Console.ReadLine());

                            if (spejimas == atspek && !(spejimas < 1 || spejimas > 20))
                            {
                                Console.WriteLine("TEISINGAI");
                            }
                            else
                            {
                                if (spejimas < 1 || spejimas > 20)
                                {
                                    Console.WriteLine("KLAIDA");
                                }
                                else
                                {
                                    Console.WriteLine(spejimas > atspek ? "SKAIČIUS YRA MAŽESNIS" : "SKAIČIUS YRA DIDESNIS");
                                    Console.WriteLine($"Bandykite speti dar darta (liko 3 spejimai): ");
                                    spejimas = Convert.ToInt32(Console.ReadLine());

                                    if (spejimas == atspek && !(spejimas < 1 || spejimas > 20))
                                    {
                                        Console.WriteLine("TEISINGAI");
                                    }
                                    else
                                    {
                                        if (spejimas < 1 || spejimas > 20)
                                        {
                                            Console.WriteLine("KLAIDA");
                                        }
                                        else
                                        {
                                            Console.WriteLine(spejimas > atspek ? "SKAIČIUS YRA MAŽESNIS" : "SKAIČIUS YRA DIDESNIS");
                                            Console.WriteLine($"Bandykite speti dar darta (liko 2 spejimai): ");
                                            spejimas = Convert.ToInt32(Console.ReadLine());

                                            if (spejimas == atspek && !(spejimas < 1 || spejimas > 20))
                                            {
                                                Console.WriteLine("TEISINGAI");
                                            }
                                            else
                                            {
                                                if (spejimas < 1 || spejimas > 20)
                                                {
                                                    Console.WriteLine("KLAIDA");
                                                }
                                                else
                                                {
                                                    Console.WriteLine(spejimas > atspek ? "SKAIČIUS YRA MAŽESNIS" : "SKAIČIUS YRA DIDESNIS");
                                                    Console.WriteLine($"Bandykite speti dar darta (liko 1 spejimai): ");
                                                    spejimas = Convert.ToInt32(Console.ReadLine());

                                                    if (spejimas == atspek && !(spejimas < 1 || spejimas > 20))
                                                    {
                                                        Console.WriteLine("TEISINGAI");
                                                    }
                                                    else
                                                    {
                                                        if (spejimas < 1 || spejimas > 20)
                                                        {
                                                            Console.WriteLine("KLAIDA");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Atspeti nepavyko :(");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
             */




            // =================================================================================================================================
            /*
             * SKAIČIUOTUVAS *
            Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją ( +, -, * arba / )
            - Parašykite programą kuri į ekraną išves skaičių rezultatą
            - naudokite if
            - naudokite switch
             */

            /*
            Console.Write("skaičius 1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("skaičius 2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operacija ( +, -, * arba / ): ");
            string operacija = Console.ReadLine();

            Console.WriteLine("\nIf:");
            if (operacija == "+")
            {
                Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
            }
            else if (operacija == "-")
            {
                Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
            }
            else if (operacija == "*")
            {
                Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
            }
            else if (operacija == "/")
            {
                if (skaicius2 == 0)
                {
                    Console.WriteLine("Dalyba is nulio negalima!");
                }
                else
                {
                    Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / skaicius2}");
                }
            }

            Console.WriteLine("\nSwitch:");
            switch (operacija)
            {
                case "+":
                    Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
                    break;
                case "-":
                    Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
                    break;
                case "*":
                    Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
                    break;
                case "/":
                    if (skaicius2 == 0)
                    {
                        Console.WriteLine("Dalyba is nulio negalima!");
                    }
                    else
                    {
                        Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / skaicius2}");
                    }
                    break;
            }
            */





            // =================================================================================================================================
            /*
             * Trys draugai *
            - Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
            - Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
            - Atspausdinti draugų amžiaus vidurkį
            - Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
            - Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
            <Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
            konstrukcijas kurias iki šiol išėjome.
             */
            /*
            Console.Write("Draugo 1 vardas: ");
            string draugas1 = Console.ReadLine();
            Console.Write("Draugo 1 amzius: ");
            int amzius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Draugo 2 vardas: ");
            string draugas2 = Console.ReadLine();
            Console.Write("Draugo 2 amzius: ");
            int amzius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Draugo 3 vardas: ");
            string draugas3 = Console.ReadLine();
            Console.Write("Draugo 3 amzius: ");
            int amzius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{draugas1} {amzius1}");
            Console.WriteLine($"{draugas2} {amzius2}");
            Console.WriteLine($"{draugas3} {amzius3}");

            Console.WriteLine();
            Console.WriteLine($"Draugu amziu vidurkis - {(amzius1 + amzius2 + amzius3) / 3D}");

            if (amzius1 < amzius2 && amzius1 < amzius3)
                Console.WriteLine($"{draugas1} yra jauniausias");
            else if (amzius2 < amzius1 && amzius2 < amzius3)
                Console.WriteLine($"{draugas2} yra jauniausias");
            else if (amzius3 < amzius1 && amzius3 < amzius2)
                Console.WriteLine($"{draugas3} yra jauniausias");

            if (amzius1 > amzius2 && amzius1 > amzius3)
                Console.WriteLine($"{draugas1} yra vyriausias");
            else if (amzius2 > amzius1 && amzius2 > amzius3)
                Console.WriteLine($"{draugas2} yra vyriausias");
            else if (amzius3 > amzius1 && amzius3 > amzius2)
                Console.WriteLine($"{draugas3} yra vyriausias");
            */









            // =================================================================================================================================

            /*
            ** Kalėdų sausainiai **
            - Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
            - Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
            - Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
            - Jei nėra išveda - "Palaukite kalėdų"
            Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
            <Hint> metodai data.Month ir data.Day
             */

            Console.Write("Iveskite data (1): ");
            DateTime data1 = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Iveskite data (2): ");
            DateTime data2 = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Iveskite data (3): ");
            DateTime data3 = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Iveskite data (4): ");
            DateTime data4 = Convert.ToDateTime(Console.ReadLine());

            if (data1.Month == 12 && data1.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            }
            else if (data2.Month == 12 && data2.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            }
            else if (data3.Month == 12 && data3.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            }
            else if (data4.Month == 12 && data4.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            }
            else
            {
                Console.WriteLine("Palaukite kalėdų");
            }

            // =================================================================================================================================
        }
    }
}