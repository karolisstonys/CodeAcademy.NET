using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Domain.Services
{
    public class ShopConsole
    {
        public void Run()
        {            
            bool active = true;

            while (active)
            {
                Console.Clear();

                ShowMenu(1);

                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        //();
                        break;
                    case '2':
                        //();
                        break;
                    case '3':
                        //();
                        break;
                    case '\u001b':  // ESC
                        active = false;
                        return;
                    default:
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }

                PauseScreen();
            }
        }

        private void ShowMenu(int menuNumber)
        {
            switch (menuNumber)
            {
                case 1:
                    Console.WriteLine("┌────────────────────────────────────────────────────┐");
                    Console.WriteLine("│           Muzikos elektroninė-parduotuvė           │");
                    Console.WriteLine("╞════════════════════════════════════════════════════╡");
                    Console.WriteLine("| Pasirinkimai :                                     │");
                    Console.WriteLine("| 1.  |   Prisijungti                                │");
                    Console.WriteLine("| 2.  |   Registruotis                               │");
                    Console.WriteLine("| 3.  |   Darbuotojų Parinktys                       │");
                    Console.WriteLine("| ESC |   Išeiti                                     │");
                    Console.WriteLine("└────────────────────────────────────────────────────┘");
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void PauseScreen()
        {
            Console.WriteLine("Norėdami tęsti, paspauskite bet kurį mygtuką...");
            Console.ReadKey();
        }
    }
}
