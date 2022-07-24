namespace E020_SuperSkaiciuotuvas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Super skaiciuotuvas");

            while (stage != 9)
            {
                SuperSkaiciuotuvas("");
            }
        }




        /* ## Super Skaiciuotuvas ##
        Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
        1. Nauja operacija 2 Iseiti.
       
        Pasirinkus 1 vada į submeniu:
        1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
   
        Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
        o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu.
       
        1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
        Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS.
        Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.

        NB! programos karkasas pateiktas testuose. Testų logikos keisti negalima.
        Programos karkasas: https://github.com/Atikas/CA.NET2/blob/main/BasicMokymai/E002_SuperSkaiciuotuvas/Program.cs
        Pateikiami programos testai: https://github.com/Atikas/CA.NET2/blob/main/BasicMokymai/E002_SuperSkaiciuotuvas_Tests/ProgramTests.cs
   
        Pvz:
        > 1. Nauja operacija 2 Iseiti.
        _1
        > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
        _1
        > pasirinktas veiksmas +
        > iveskite pirma skaiciu
        _15
        > iveskite antra skaiciu
        _45
        > Rezultatas: 60
        > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
        _2
        > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
        _2
        > pasirinktas veiksmas -
        > Iveskite skaiciu
        _10
        > Rezultatas: 50
        > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
        _1
        > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
        _2
        > pasirinktas veiksmas *
          > iveskite pirma skaiciu
        _2
        > iveskite antra skaiciu
        _3
        > Rezultatas: 6
        > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
        _3
        > Baigta
        
        BONUS1: Iskelkite operacijas i metodus
        BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.
                - dalyba is nulio, neteisingu ivesciu prevencija
                - kada tikimasi gauti skaiciu, bet gaunamas char arba string.
                - neteisingas meniu punkto pasirinkimas
        BONUS3: Parasyti unit testus uztikrinant operaciju veikima
        BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas   */

        static int stage = 1;
        // 1 - select MENU
        // 2 - select MENU (with previous result)
        // 3 - pick MATHEMATICAL action
        // 4 - pick MATHEMATICAL action (with previous result)
        // 5 - entering numbers if any is needed
        // 9 - EXIT

        static string action = "";
        static double? number1 = null;
        static double? number2 = null;
        static double? rezultatas = null;

        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            if (stage == 1) // 1 - select MENU
            {
                MainMenu();
                ivedimas = MenuEnterCheck(ivedimas);

                if (ivedimas == "1")
                    stage = 3;
                else
                {
                    stage = 9;
                }
            }
            else if (stage == 2) // 2 - select MENU (with previous result)
            {
                MainMenu();
                ivedimas = MenuEnterCheck(ivedimas);
                if (ivedimas == "1")
                    stage = 3;
                else if (ivedimas == "2")
                    stage = 4;
                else
                {
                    stage = 9;
                    action = "";
                    number1 = null;
                    number2 = null;
                }
            }
            else if (stage == 3) // 3 - pick MATHEMATICAL action
            {
                ShowPossibleCalcActions();
                if (ActionCheck(ivedimas))
                    action = ivedimas;
                else
                    action = EnterActionAgain(ivedimas);
                ActionNomalization();
                stage = 5;
            }
            else if (stage == 4) // 4 - pick MATHEMATICAL action (with previous result)
            {
                ShowPossibleCalcActions();
                if (ActionCheck(ivedimas))
                    action = ivedimas;
                else
                    action = EnterActionAgain(ivedimas);
                ActionNomalization();
                number1 = rezultatas.Value;
                stage = 5;
            }
            else if (stage == 5) // 5 - entering numbers if any is needed
            {
                if (number1 == null)
                {
                    double? testDouble = DoubleTryParseOutNull(ivedimas);
                    if (testDouble != null)
                        number1 = testDouble.Value;
                    else
                        number1 = EnterNumberAgain();
                }
                else if (number1 != null && (action == "^2" || action == "^3" || action == "√"))
                {
                    rezultatas = Calculate();
                    Rezultatas();
                    Console.WriteLine($"{number1} {action} = {rezultatas}");
                    GoToStageTwo();
                }
                else if (number1 != null && number2 == null && action != "^2" && action != "^3" && action != "√")
                {
                    double? testDouble = DoubleTryParseOutNull(ivedimas);
                    if (testDouble != null)
                        number2 = testDouble.Value;
                    else
                        number2 = EnterNumberAgain();
                    rezultatas = Calculate();
                    Rezultatas();
                    Console.WriteLine($"{number1} {action} {number2} = {rezultatas}");
                    GoToStageTwo();
                }
            }
        }
        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            stage = 1;
            action = "";
            number1 = null;
            number2 = null;
            rezultatas = null;
        }

        private static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Nauja operacija");
            if (stage != 2)
            {
                Console.WriteLine("2. Iseiti");
            }
            else
            {
                Console.WriteLine("2. Testi su rezultatu");
                Console.WriteLine("3. Iseiti");
            }
            Console.WriteLine();
        }

        private static string MenuEnterCheck(string enter)
        {
            int? number = null;
            int minNumber = 1;
            int maxNumber = 0;

            if (stage == 1)
                maxNumber = 2;      // kai yra [1. Nauja operacija 2. Iseiti]
            else if (stage == 2)
                maxNumber = 3;      // kai yra [1. Nauja operacija 2. Testi su rezultatu 3. Iseiti]

            number = IntTryParseOutNull(enter);

            while (number == null || number < minNumber || number > maxNumber)
            {
                Console.Write("Pasirinkite: ");
                enter = Console.ReadLine();
                number = IntTryParseOutNull(enter);

            }
            return enter;
        }

        private static void ShowPossibleCalcActions()
        {
            Console.WriteLine();
            Console.WriteLine("1. Sudetis (+)");
            Console.WriteLine("2. Atimtis (-)");
            Console.WriteLine("3. Daugyba (*)");
            Console.WriteLine("4. Dalyba  (/)");
            Console.WriteLine("5. Kelima kvadratu   (^2)");
            Console.WriteLine("6. Kelimas kubu      (^3)");
            Console.WriteLine("7. Saknies traukimas (√)");
            Console.WriteLine();
        }

        public static int? IntTryParseOutNull(string? txt) => int.TryParse(txt, out int output) ? (int?)output : null;

        private static bool ActionCheck(string txt) =>
            txt == "1"     ||
            txt == "2"     ||
            txt == "3"     ||
            txt == "4"     ||
            txt == "5"     ||
            txt == "6"     ||
            txt == "7"     ||
            txt == "+"     ||
            txt == "-"     ||
            txt == "*"     ||
            txt == "/"     ||
            txt == "^2"    ||
            txt == "^3"    ||
            txt == "√";

        private static string EnterActionAgain(string enter)
        {            
            while (ActionCheck(enter) == false)
            {
                Console.Write("Pasirinkite: ");
                enter = Console.ReadLine();
            }
            return enter;
        }

        private static void ActionNomalization()
        {
            action = action.Replace("1", "+");
            if (action == "2")
                action = action.Replace("2", "-");
            if (action == "3")
                action = action.Replace("3", "*");
            action = action.Replace("4", "/");
            action = action.Replace("5", "^2");
            action = action.Replace("6", "^3");
            action = action.Replace("7", "√");
        }

        public static double? DoubleTryParseOutNull(string? txt) => double.TryParse(txt, out double output) ? (double?)output : null;

        private static double? EnterNumberAgain()
        {
            string enter = "";
            double? testDouble = null;
            do
            {
                Console.Write("Iveskite skaiciu: ");
                enter = Console.ReadLine();
                testDouble = DoubleTryParseOutNull(enter);
            } while (testDouble == null);
            return testDouble;
        }

        public static double? Calculate()
        {
            switch (action)       // state machine
            {
                case "+":
                    return Addition();
                case "-":
                    return Subtraction();
                case "*":
                    return Multiplication();
                case "/":
                    return Division();
                case "^2":
                    return PowerOfTwo();
                case "^3":
                    return PowerOfThree();
                case "√":
                    return SquareRoot();
                default:
                    return null;
            }
        }

        public static double Addition() => number1.Value + number2.Value;
        public static double Subtraction() => number1.Value - number2.Value;
        public static double Multiplication() => number1.Value * number2.Value;
        public static double Division() => number1.Value / number2.Value;
        public static double PowerOfTwo() => number1.Value * number1.Value;
        public static double PowerOfThree() => number1.Value * number1.Value * number1.Value;
        public static double SquareRoot() => Math.Sqrt(number1.Value);

        public static void GoToStageTwo()
        {
            stage = 2;
            action = "";
            number1 = null;
            number2 = null;            
        }












    }
}