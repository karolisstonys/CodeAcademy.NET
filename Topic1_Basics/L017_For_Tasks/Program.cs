using System.Text;

namespace L017_For_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            UŽDUOTIS 1.
            Sukurti metodą ReadIntNumber,
            kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
            Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
            įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
            neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
            (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
            */
            //PirmaUzduotis();


            /*
            Sukurti metodą IntegerToBinary,
            kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
            2 --> 10
            7 --> 111
            45 --> 101101 
            */
            //AntraUzduotis();



            /*
            Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
            laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
            kelsime, antras laipsnis, kuriuo pakelti.
            NB! kai skaičius 0 o laipsnis > 0 gąžinama 1
            NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
            NB! kai laipsnis = 1 gąžinamas tas pats skaičius 
            */
            //TreciaUzduotis();

            /*
            Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
            (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą).
            Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
            5
            55
            555
            5555
            55555 
            */
            //KetvirtaUzduotis();


            /*
            Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
            jeigu įveda netinkamą skaičių
            prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
            7
            77
            777
            7777
            77777
            777777
            7777777
            777777
            77777
            7777
            777
            77
            7
            */
            //PenktaUzduotis();



            /*
            Sukurti metodą DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
            (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )).
            Programa turi grąžinti atitinkamą statųjį trikampį.
            1
            22
            333
            4444
            55555
            */
            //SestaUzduotis();



            /*
            Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
            (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )).
            Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
            1
            22
            333
            4444
            333
            22
            1 
            */
            //SeptintaUzduotis();



        }

        private static void PirmaUzduotis()
        {
            int skaicius;
            Console.Write("Sveiki, įveskite skaičiu: ");
            while (!int.TryParse(Console.ReadLine(), out skaicius))
            {            
                Console.Write("Ne! Pabandome dar kartą: ");
            }
            Console.WriteLine("Ačių! Jūsų skaičius: {0}", skaicius);
        }

        private static void AntraUzduotis()
        {
            bool arIvestasSkaicius;
            int skaicius;
            string binary = "";

            do
            {
                Console.Write("Iveskite skaiciu: ");
                arIvestasSkaicius = int.TryParse(Console.ReadLine(), out skaicius);
            } while (!arIvestasSkaicius);

            binary = skaicius % 2 + binary;
            int poDalybosSveikasSkaicius = skaicius / 2;
            while (poDalybosSveikasSkaicius != 0)
            {
                binary = (poDalybosSveikasSkaicius % 2) + binary;
                poDalybosSveikasSkaicius = poDalybosSveikasSkaicius / 2;
            }
            Console.WriteLine(binary);


        }

        private static void TreciaUzduotis()
        {
            Console.Write("iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.Write("iveskite kokiu laipsniu norite ta skaiciu pakelti: ");
            int laipsnis = Convert.ToInt32(Console.ReadLine());
            int ats = 1;

            if (skaicius == 0 && laipsnis > 0)
            {
                ats = 1;
            }
            else if (skaicius == 0 && laipsnis == 0)
            {
                ats = 0;
            }
            else if (laipsnis == 1)
            {
                ats = skaicius;
            }
            else
            {
                for (; laipsnis != 0; laipsnis--)
                {
                    ats = ats * skaicius;
                }
            }
            Console.WriteLine($"{skaicius} ^{laipsnis} = {ats}");
        }

        private static void KetvirtaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                    sb.Append(skaicius);
                    Console.WriteLine(sb.ToString());
            }
        }

        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;

        private static void PenktaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(skaicius);
                Console.WriteLine(sb.ToString());
            }

            for (int i = skaicius; i >= 1; i--)
            {
                sb.Remove(0, 1);
                Console.WriteLine(sb.ToString());
            }

        }

        private static void SestaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }

            for (int i = 1; i <= skaicius; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    sb.Append(i);
                }
                Console.WriteLine(sb.ToString());
            }
        }

        private static void SeptintaUzduotis()
        {
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.Write("Iveskite skaiciu: ");
                skaicius = SkaiciausTikrinimas(Console.ReadLine());
            }

            for (int i = 1; i <= skaicius; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    sb.Append(i);
                }
                Console.WriteLine(sb.ToString());
            }

            for (int i = skaicius - 1; i >= 1; i--)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    sb.Append(i);
                }
                Console.WriteLine(sb.ToString());
            }
        }
















    }
}