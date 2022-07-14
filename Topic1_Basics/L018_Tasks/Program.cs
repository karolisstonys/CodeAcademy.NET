using System.Text;

namespace L018_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 1.Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1-> 11-> 111-> 1111-> 11111-> .......
            /// programa turi paprašyti nurodyti skaičių ir grupių kiekį
            /// naudokite for ir StringBuilder
            /// </summary>
            //PirmaUzduotis();

            /// <summary>
            /// 2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
            /// 15 X 1 = 15
            /// 15 X 2 = 30
            /// 15 X 3 = 45
            /// 15 X 4 = 60
            /// 15 X 5 = 75
            /// 15 X 6 = 90
            /// 15 X 7 = 105
            /// 15 X 8 = 120
            /// 15 X 9 = 135
            /// 15 X 10 = 150
            /// </summary>
            //AntraUzduotis();


            /// <summary>            
            /// 3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima 
            /// "1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti"
            ///     1.Sudetis
            ///     2.Atimtis
            ///     3.Daugyba
            ///     4.Dalyba
            /// Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
            /// o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu.
            /// 
            ///     Sudeties pvz:
            ///     1
            ///     15
            ///     45
            ///     Rezultatas: 60
            /// 
            ///     1.Nauja operacija
            ///     2.Testi su rezultatu
            ///     3.Iseiti
            /// 
            /// Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
            /// 
            /// BONUS1: Iskelkite operacijas i metodus
            /// BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            /// BONUS3: Parasyti unit testus uztikrinant operaciju veikima
            /// BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas 
            /// </summary>
            TreciaUzduotisSkaiciuotuvas();    

            /// <summary>
            /// 4. Sukurkite programa, kuri atspausdintu sia forma:
            /// 
            ///             *
            ///            ***
            ///           *****
            ///          *******
            ///         *********
            ///          *******
            ///           *****
            ///            ***
            ///             * 
            ///             
            /// </summary>

        }


        private static int? SkaiciausTikrinimas(string? txt)
        {

            if (int.TryParse(txt, out int num) == false)
            {
                AntraUzduotis();
                return null;
            }
            else
                return num;
        }

        public static int? IntTryParseNullable(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

        public static double? DoubleTryParseNullable(string? txt) => double.TryParse(txt, out double output) ? (double?)output : null;


        /// <summary>
        /// 1.Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1-> 11-> 111-> 1111-> 11111-> .......
        /// programa turi paprašyti nurodyti skaičių ir grupių kiekį
        /// naudokite for ir StringBuilder
        /// </summary>
        private static void PirmaUzduotis()
        {
            Console.WriteLine("iveskite du skaicius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius2; i++)
            {
                sb.Append(" -> ");
                for (int j = 1; j <= i; j++)
                {
                    sb.Append(skaicius1);
                }
            }
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// 2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
        /// 15 X 1 = 15
        /// 15 X 2 = 30
        /// 15 X 3 = 45
        /// 15 X 4 = 60
        /// 15 X 5 = 75
        /// 15 X 6 = 90
        /// 15 X 7 = 105
        /// 15 X 8 = 120
        /// 15 X 9 = 135
        /// 15 X 10 = 150
        /// </summary>
        private static void AntraUzduotis()
        {
            int? skaicius = null;
            do
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            } while (skaicius != null);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
            }
        }
        
        /// <summary>            
        /// 3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima 
        ///     
        ///     1. Nauja operacija 
        ///     2. Testi su rezultatu 
        ///     3. Iseiti”. 
        ///  
        /// Pasirinkus 1 turetu ismesti
        /// 
        ///     1.Sudetis
        ///     2.Atimtis
        ///     3.Daugyba
        ///     4.Dalyba
        ///     
        /// Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
        /// o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu.
        /// 
        ///     Sudeties pvz:
        ///     1
        ///     15
        ///     45
        ///     Rezultatas: 60
        /// 
        ///     1.Nauja operacija
        ///     2.Testi su rezultatu
        ///     3.Iseiti
        /// 
        /// Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
        /// 
        /// BONUS1: Iskelkite operacijas i metodus
        /// BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
        /// BONUS3: Parasyti unit testus uztikrinant operaciju veikima
        /// BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas 
        /// </summary>        
        private static void TreciaUzduotisSkaiciuotuvas()
        {
            double? skaicius1 = null;
            double? skaicius2 = null;
            double? atsakymas = null;
            string veiksmas = string.Empty;
            int? pasirinkimas = null;

            Console.WriteLine("SKAICIUOTUVAS");

            while (pasirinkimas != 3)
            {
                do
                {
                    ParodytiSkaiciuotuvoMenu();
                    Console.Write("Pasirinkimas: ");
                    pasirinkimas = IntTryParseNullable(Console.ReadLine());
                    if (ArBlogasPasinkimas(pasirinkimas))
                    {
                        Console.WriteLine("Blogas pasirinkimas, bandykite dar karta.");
                        Console.WriteLine();
                    }
                } while (ArBlogasPasinkimas(pasirinkimas));

                switch (pasirinkimas)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("NAUJA OPERACIJA");
                        ParodytiSkaiciuotuvoVeiksmus();

                        Console.Write("Pasirinkimas: ");
                        veiksmas = Console.ReadLine();

                        while (!VeiksmoPatikrinimas(veiksmas))
                        {
                            // Galima rinktis 1, 2, 3, 4, 5, 6, 7 arba +, -, *, /, ^2, ^3
                            Console.Write("Netinkamas pasirinkimas. Bandykite dar karta: ");
                            veiksmas = Console.ReadLine();
                        }

                        VeiksmoNormalizacija(ref veiksmas);

                        Console.Write("Pirmas skaicius: ");
                        skaicius1 = DoubleTryParseNullable(Console.ReadLine());

                        while (skaicius1 == null)
                        {
                            Console.Write("Netinkamai ivestas pirmas skacius. Bandykite dar karta: ");
                            skaicius1 = DoubleTryParseNullable(Console.ReadLine());
                        }

                        if (veiksmas != "^2" && veiksmas != "^3" && veiksmas != "√")
                        {
                            Console.Write("Antras skaicius: ");
                            skaicius2 = DoubleTryParseNullable(Console.ReadLine());

                            while (skaicius2 == null)
                            {
                                Console.Write("Netinkamai ivestas pirmas skacius. Bandykite dar karta: ");
                                skaicius2 = DoubleTryParseNullable(Console.ReadLine());
                            }

                            atsakymas = Skaiciuotuvas(skaicius1.Value, skaicius2.Value, veiksmas);
                            Console.Clear();
                            Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {atsakymas}");
                        }
                        else
                        {
                            atsakymas = Skaiciuotuvas(skaicius1.Value, 0, veiksmas);
                            Console.Clear();
                            if (veiksmas == "√")
                                Console.WriteLine($"{veiksmas}{skaicius1} = {atsakymas}");
                            else
                                Console.WriteLine($"{skaicius1} {veiksmas} = {atsakymas}");
                        }
                        break;
                    case 2:
                        if (atsakymas != null)
                        {












                            Console.Clear();
                            Console.WriteLine("TESIAME SU REZULTATU");
                            ParodytiSkaiciuotuvoVeiksmus();

                            Console.Write("Pasirinkimas: ");
                            veiksmas = Console.ReadLine();

                            while (!VeiksmoPatikrinimas(veiksmas))
                            {
                                // Galima rinktis 1, 2, 3, 4, 5, 6, 7 arba +, -, *, /, ^2, ^3
                                Console.Write("Netinkamas pasirinkimas. Bandykite dar karta: ");
                                veiksmas = Console.ReadLine();
                            }

                            VeiksmoNormalizacija(ref veiksmas);

                            Console.WriteLine($"Pirmas skaicius: {atsakymas}");
                            skaicius1 = atsakymas;

                            while (skaicius1 == null)
                            {
                                Console.Write("Netinkamai ivestas pirmas skacius. Bandykite dar karta: ");
                                skaicius1 = DoubleTryParseNullable(Console.ReadLine());
                            }

                            if (veiksmas != "^2" && veiksmas != "^3" && veiksmas != "√")
                            {
                                Console.Write("Antras skaicius: ");
                                skaicius2 = DoubleTryParseNullable(Console.ReadLine());

                                while (skaicius2 == null)
                                {
                                    Console.Write("Netinkamai ivestas pirmas skacius. Bandykite dar karta: ");
                                    skaicius2 = DoubleTryParseNullable(Console.ReadLine());
                                }

                                atsakymas = Skaiciuotuvas(skaicius1.Value, skaicius2.Value, veiksmas);
                                Console.Clear();
                                Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {atsakymas}");
                            }
                            else
                            {
                                atsakymas = Skaiciuotuvas(skaicius1.Value, 0, veiksmas);
                                Console.Clear();
                                if (veiksmas == "√")
                                    Console.WriteLine($"{veiksmas}{skaicius1} = {atsakymas}");
                                else
                                    Console.WriteLine($"{skaicius1} {veiksmas} = {atsakymas}");
                            }















                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Atmintyje nera jokio skaiciaus!");
                        }
                        break;
                }
            }
        }

        private static bool VeiksmoPatikrinimas(string veiksmas) => 
            veiksmas == "1"     ||
            veiksmas == "2"     ||
            veiksmas == "3"     ||
            veiksmas == "4"     ||
            veiksmas == "5"     ||
            veiksmas == "6"     ||
            veiksmas == "7"     ||
            veiksmas == "+"     ||
            veiksmas == "-"     ||
            veiksmas == "*"     ||
            veiksmas == "/"     ||
            veiksmas == "^2"    ||
            veiksmas == "^3"    ||
            veiksmas == "√";

        private static void VeiksmoNormalizacija(ref string veiksmas)
        {
            veiksmas = veiksmas.Replace("7", "√");
            veiksmas = veiksmas.Replace("6", "^3");
            veiksmas = veiksmas.Replace("5", "^2");
            veiksmas = veiksmas.Replace("4", "/");
            if (veiksmas == "3")
                veiksmas = veiksmas.Replace("3", "*");
            if (veiksmas == "2")
                veiksmas = veiksmas.Replace("2", "-");
            veiksmas = veiksmas.Replace("1", "+");
        }

        private static bool ArBlogasPasinkimas(int? pasirinkimas) => pasirinkimas == null || pasirinkimas > 3 || pasirinkimas < 1;

        private static void ParodytiSkaiciuotuvoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Nauja operacija");
            Console.WriteLine("2. Testi su rezultatu");
            Console.WriteLine("3. Iseiti");
            Console.WriteLine();
        }

        private static void ParodytiSkaiciuotuvoVeiksmus()
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis (+)");
            Console.WriteLine("2. Atimtis (-)");
            Console.WriteLine("3. Daugyba (*)");
            Console.WriteLine("4. Dalyba  (/)");
            Console.WriteLine("5. Kelima kvadratu (^2)");
            Console.WriteLine("6. Kelimas kubu    (^3)");
            Console.WriteLine("7. Saknies traukimas");
            Console.WriteLine();
        }

        public static double Skaiciuotuvas(double skaicius1, double skaicius2, string? veiksmas)
        {
            switch (veiksmas)       // state machine
            {
                case "+":
                    return Suma(skaicius1, skaicius2);
                case "-":
                    return Atimtis(skaicius1, skaicius2);
                case "*":
                    return Daugyba(skaicius1, skaicius2);
                case "/":
                    return Dalyba(skaicius1, skaicius2);
                case "^2":
                    return KelimasKvadratu(skaicius1);
                case "^3":
                    return KelimasKubu(skaicius1);
                case "√":
                    return SakniesTraukimas(skaicius1);
            }
            return 0;
        }

        public static double Suma(double skaicius1, double skaicius2) => skaicius1 + skaicius2;

        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;

        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;

        public static double Dalyba(double skaicius1, double skaicius2) => skaicius1 / skaicius2;

        public static double KelimasKvadratu(double skaicius1) => skaicius1 * skaicius1;

        public static double KelimasKubu(double skaicius1) => skaicius1 * skaicius1 * skaicius1;

        public static double SakniesTraukimas(double skaicius1) => Math.Sqrt(skaicius1);
    }
}