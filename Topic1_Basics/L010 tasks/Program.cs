namespace L010_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==============================================================================
            /*
            Parašykite programą kurioje yra 2 metodai.
            - Pirmas metodas į konsolę išveda "Sveiki visi"
            - Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
            */

            //sveiki();
            //iki();




            // ==============================================================================
            /*
            Parašykite programą kurioje yra 2 metodai.
            - Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
            - Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
            Pvz:
            > Iveskite savo Varda:
            _ Petras
            > Labas Petras
            > Linkiu jums Petras geros dienos*/

            //string name = sveikiSuVardu();
            //ikiSuVardu(name);




            // ==============================================================================
            /*
            Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
            - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
            N.B. būtina validacija
            - Į ekraną išveskite argumentų matematinę sumą.
            Pvz:
            > Iveskite pirmą skaičių:
            _ 15
            > Iveskite antrą skaičių:
            _ 16
            > Rezultatas: 31
            */

            //Console.Write("Iveskite pirmą skaičių: ");
            //string skA1 = Console.ReadLine();

            //Console.Write("Iveskite antrą skaičių: ");
            //string skA2 = Console.ReadLine();

            //bool arSkA1 = int.TryParse(skA1, out int intSkA1);
            //bool arSkA2 = int.TryParse(skA2, out int intSkA2);

            //if (arSkA1 && arSkA2)
            //{
            //    MatematineSuma(intSkA1, intSkA2);
            //}
            //else
            //{
            //    Console.WriteLine("Ivesta blogai");
            //}




            // ==============================================================================
            /*
            Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
            - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
            - Main metode į ekraną išveskite tarpų kiekį
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > Tarpu kiekis yra: 2
            */

            Console.WriteLine("įvesti betkokį tekstą su tarpais: ");
            string tekstasSuTarpais = Console.ReadLine();

            int kiekTarpu = SkaiciuojamTarpus(tekstasSuTarpais, 1);

            Console.WriteLine($"tekste yra {kiekTarpu} tarpų");


            // ==============================================================================
            /*
            Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti betkokį tekstą Main metode.
            - Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
            Pvz:
            > Iveskite teksta:
            _ ' as mokausi '
            > Teksto ilgis yra: 10
            */

            int kiekRaidziuBeTarpu = SkaiciuojamTarpus(tekstasSuTarpais, 2);
            Console.WriteLine($"tekstas be tarpų yra {kiekRaidziuBeTarpu} ilgio");


            // ==============================================================================
        }




        private static int SkaiciuojamTarpus(string? tekstasSuTarpais, int x)
        {
            if (x == 1)
            {
                int ats = tekstasSuTarpais.Length - tekstasSuTarpais.Replace(" ", "").Length;
                return ats;
            }
            else if (x == 2)
            {
                return tekstasSuTarpais.Trim().Length; ;
            }
            else
                return 0;
        }




        private static void MatematineSuma(int intSkA1, int intSkA2)
        {
            Console.Write($"{intSkA1} + {intSkA2} = {intSkA1 + intSkA2}");
        }




        public static string sveikiSuVardu()
        {
            Console.Write("Iveskite savo varda: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Sveiki {name}");
            return name;
        }




        public static void ikiSuVardu(string name)
        {
            Console.WriteLine($"{name}, linkiu jums geros dienos");
        }


        public static void sveiki()
        {
            Console.WriteLine("Sveiki visi");
        }




        public static void iki()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }
    }
}