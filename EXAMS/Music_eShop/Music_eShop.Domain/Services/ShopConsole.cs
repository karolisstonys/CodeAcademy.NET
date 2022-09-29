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

            //Pirmas langas turėtų būti skirtas registracijai, prisijungimui ir Employee skirtoms statistikoms. 
            
            bool active = true;

            while (active)
            {

                Console.Clear();
                Console.WriteLine("| Pasirinkimas :                    |");
                Console.WriteLine("| 1.  |   Prisijungti               |");
                Console.WriteLine("| 2.  |   Registruotis              |");
                Console.WriteLine("| 3.  |   Darbuotojų Parinktys      |");
                Console.WriteLine("| ESC |   Išeiti");

                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        //PirmasKlientoPrisijungimoMetodas();
                        break;
                    case '2':
                        //KlientoRegistracijosMetodas();

                        break;
                    case '3':
                        //AdminAplinkosSecurityMetodas();
                        break;
                    case 'q' or 'Q' or '\u001b':  // ESC
                        active = false;
                        return;
                    default:
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }

                PauseScreen();





            }





        }

    }
}
