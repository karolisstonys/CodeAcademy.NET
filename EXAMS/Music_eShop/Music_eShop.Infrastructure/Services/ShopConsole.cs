using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure;
using Music_eShop.Infrastructure.Database;
using Music_eShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Domain.Services
{
    public class ShopConsole : IShopConsole
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
                        ShowAllCustomers();
                        Console.WriteLine("Pasirinkite pagal ID:");
                        User user = Login(Console.ReadLine());
                        break;
                    case '2':
                        Console.WriteLine();
                        RegisterNewCustomer();
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
                    Console.WriteLine("│ 1.  │   Prisijungti                                │");
                    Console.WriteLine("│ 2.  │   Registruotis                               │");
                    Console.WriteLine("│ 3.  │   Darbuotojų Parinktys                       │");
                    Console.WriteLine("| ESC │   Išeiti                                     │");
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
            Console.WriteLine();
            Console.WriteLine("Norėdami tęsti, paspauskite bet kurį mygtuką...");
            Console.ReadKey();
        }



        private void ShowAllCustomers()
        {
            var context = new ChinookContext();
            ICustomerRepository customers = new CustomerRepository(context);
            Console.WriteLine();
            var allCustomers = customers.Get();
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"| {customer.CustomerId,3} │ {customer.FirstName} {customer.LastName}");
            }



        }




        private void RegisterNewCustomer()
        {
            Console.Write("Vardas: ");
            var firstName = Console.ReadLine();
            Console.Write("Pavarde: ");
            var lastName = Console.ReadLine();
            Console.Write("El.paštas: ");
            var email = Console.ReadLine();

            var context = new ChinookContext();
            ICustomerRepository customers = new CustomerRepository(context);
            customers.Add(firstName, lastName, email);
            Console.WriteLine("Naujas klientas sekmingai išsaugotas.");
        }
        private User Login(string customerId)
        {
            long userId = 0;
            while(!long.TryParse(customerId, out userId))
            {
                Console.Write("Blogas pasirinkimas, bandykite dar kartą: ");
                customerId = Console.ReadLine();
            }


            var context = new ChinookContext();

            var customer = context.Customers.Find(userId);

            var user = new User(customer.CustomerId, customer.FirstName + " " + customer.LastName);

            return user;
        }
    }
}
