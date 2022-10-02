using Music_eShop.Domain.Enums;
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
        private AppState _state = AppState.LoginScreen;
        private User _user = null;

        public void Run()
        {
            while (true)
            {
                RunState();
            }
        }

        public void RunState()
        {
            Console.Clear();

            switch (_state)
            {
                case AppState.LoginScreen:
                    LoginMenu();
                    break;
                case AppState.BuyScreen:
                    BuyMenu();
                    break;
                case AppState.CatalogScreen:
                    CatalogMenu();
                    break;
                case AppState.AddToCartScreen:

                    break;
                case AppState.CartScreen:

                    break;
                case AppState.MakePurchaseScreen:

                    break;
                case AppState.EmployeeLogin:
                    EmployeeLogin();
                    break;
                case AppState.EmployeeScreen:
                    EmployeeMenu();
                    break;
                case AppState.UpdateUserScreen:

                    break;
                default:
                    break;
            }
        }

        private void EmployeeMenu()
        {
            ShowMenu();
            while (_state == AppState.EmployeeScreen)
            {
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        //Keisti klientų duomenis
                        break;
                    case '2':
                        //Pakeisti dainos statusą
                        break;
                    case '3':
                        //Statistika (Darbuotojams)
                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.LoginScreen;
                        _user = null;
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                //PauseScreen();
            }
        }

        private void EmployeeLogin()
        {
            ShowMenu();
            var pinCode = "0001";
            Console.Write("Įveskit PIN: ");
            var pinEntered = Console.ReadLine();
            while (pinEntered != pinCode)
            {
                Console.Write("Blogas PIN! Bandykite dar kartą: ");
                pinEntered = Console.ReadLine();
            }
            _state = AppState.EmployeeScreen;
            _user = new User()
            {
                Name = "Darbuotojas-0001"
            };
        }

        private void LoginMenu()
        {
            ShowMenu();
            while (_state == AppState.LoginScreen)
            {
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        Console.WriteLine();
                        ShowAllCustomers();
                        Console.Write("Pasirinkite pagal ID: ");
                        _user = Login(Console.ReadLine());
                        _state = AppState.BuyScreen;
                        break;
                    case '2':
                        Console.WriteLine();
                        RegisterNewCustomer();
                        break;
                    case '3':
                        _state = AppState.EmployeeLogin;
                        break;
                    case 'q' or 'Q':  // ESC
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                //PauseScreen();
            }
        }

        private void BuyMenu()
        {
            ShowMenu();
            while (_state == AppState.BuyScreen)
            {
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        _state = AppState.CatalogScreen;
                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.LoginScreen;
                        _user = null;
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                //PauseScreen();
            }
        }

        private void CatalogMenu()
        {
            while (_state == AppState.CatalogScreen)
            {
                ShowMenu();
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 'a': //rikiavims pagal Name abecėlės tvarka
                        ShowCatalogOrderedAsc();
                        break;
                    case 'b': //rikiavims pagal Name atvirkštine abecėlės tvarka
                        ShowCatalogOrderedDesc();
                        break;
                    case 'c': //rikiavims pagal Composer
                        ShowCatalogOrderedByComposer();
                        break;
                    case 'd': //rikiavims pagal Genre
                        ShowCatalogOrderedByGenre();
                        break;
                    case 'e': //rikiavims pagal Composer ir Album   
                        ShowCatalogOrderedByComposerAndAlbum();
                        break;
                    case 'f': //paieška pagal Id                   

                        break;
                    case 'g': //paieška pagal Name                   
                        Console.WriteLine();
                        var context = new ChinookContext();
                        ITrackRepository tracks = new TrackRepository(context);
                        Console.Write("Iveskite paieškos teksta (Name): ");
                        var found = tracks.FindTracksByName(Console.ReadLine());
                        break;
                    case 'h': //paieška pagal Composer                   

                        break;
                    case 'i': //paieška pagal Genre

                        break;
                    case 'j': //paieška pagal Composer ir Album

                        break;
                    case 'k': //paieška pagal Milliseconds (Mažiau nei X arba daugiau nei X)                   

                        break;
                    case 'l': //(BONUS) paieška pagal Album ir Artist

                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.BuyScreen;
                        return;
                    default:
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                PauseScreen();
            }
        }


        private void ShowMenu()
        {
            if (_user != null)
            {
                Console.WriteLine("┌────────────────────────────────────────────────────┐");
                Console.WriteLine($"│Vartotojas:{_user.Name,41}│");
                Console.WriteLine($"│Krepšelyje prekių:{_user.Cart.Count(),34}│");
                Console.WriteLine("└────────────────────────────────────────────────────┘");
            }

            switch (_state)
            {
                case AppState.LoginScreen:
                    Console.WriteLine("┌────────────────────────────────────────────────────┐");
                    Console.WriteLine("│           Muzikos elektroninė-parduotuvė           │");
                    Console.WriteLine("╞════════════════════════════════════════════════════╡");
                    Console.WriteLine("| Pasirinkimai :                                     │");
                    Console.WriteLine("│ 1.  │   Prisijungti                                │");
                    Console.WriteLine("│ 2.  │   Registruotis                               │");
                    Console.WriteLine("│ 3.  │   Darbuotojų Parinktys                       │");
                    Console.WriteLine("| Q.  │   Išeiti                                     │");
                    Console.WriteLine("└────────────────────────────────────────────────────┘");
                    break;
                case AppState.BuyScreen:
                    Console.WriteLine("┌────────────────────────────────────────────────────┐");
                    Console.WriteLine("│           Muzikos elektroninė-parduotuvė           │");
                    Console.WriteLine("╞════════════════════════════════════════════════════╡");
                    Console.WriteLine("| Pasirinkimai :                                     │");
                    Console.WriteLine("│ 1.  │   Peržiūrėti katalogą                        │");
                    Console.WriteLine("│ 2.  │   Įdėti į krepšelį                           │");
                    Console.WriteLine("│ 3.  │   Peržiūrėti krepšelį                        │");
                    Console.WriteLine("│ 3.  │   Peržiūrėti pirkimų istorija (Išrašai)      │");
                    Console.WriteLine("│ Q.  │   Atsijungti                                 │");
                    Console.WriteLine("└────────────────────────────────────────────────────┘");
                    break;
                case AppState.CatalogScreen:
                    Console.WriteLine("┌────────────────────────────────────────────────────┐");
                    Console.WriteLine("│           Muzikos elektroninė-parduotuvė           │");
                    Console.WriteLine("╞════════════════════════════════════════════════════╡");
                    Console.WriteLine("| Pasirinkimai :                                     │");
                    Console.WriteLine("│ a   │   rikiavimas pagal Name abecėlės tvarka      │");
                    Console.WriteLine("│ b   │   rikiavimas pagalName atvirkštine abecėle   │");
                    Console.WriteLine("│ c   │   rikiavimas Pagal Composer                  │");
                    Console.WriteLine("│ d   │   rikiavimas pagal Genre                     │");
                    Console.WriteLine("│ e   │   rikiavimas pagal Composer ir Album         │");
                    Console.WriteLine("│ f   │   paieška pagal Id                           │");
                    Console.WriteLine("│ g   │   paieška pagal Name                         │");
                    Console.WriteLine("│ h   │   paieška pagal Composer                     │");
                    Console.WriteLine("│ i   │   paieška pagal Genre                        │");
                    Console.WriteLine("│ j   │   paieška pagal Composer ir Album            │");
                    Console.WriteLine("│ k   │   paieška pagal Milliseconds                 │");
                    Console.WriteLine("│ l   │   paieška pagal Album ir Artist              │");
                    Console.WriteLine("│ Q.  │   Grįžti                                     │");
                    Console.WriteLine("└────────────────────────────────────────────────────┘");
                    break;
                case AppState.EmployeeLogin:
                    Console.WriteLine("╔═══════════╗");
                    Console.WriteLine("║  * * * *  ║");
                    Console.WriteLine("╠═══╦═══╦═══╣");
                    Console.WriteLine("║ 1 ║ 2 ║ 3 ║");
                    Console.WriteLine("╠═══╬═══╬═══╣");
                    Console.WriteLine("║ 4 ║ 5 ║ 6 ║");
                    Console.WriteLine("╠═══╬═══╬═══╣");
                    Console.WriteLine("║ 7 ║ 8 ║ 9 ║");
                    Console.WriteLine("╠═══╬═══╬═══╣");
                    Console.WriteLine("║ * ║ 0 ║ # ║");
                    Console.WriteLine("╚═══╩═══╩═══╝");
                    break;
                case AppState.EmployeeScreen:
                    Console.WriteLine("┌────────────────────────────────────────────────────┐");
                    Console.WriteLine("│           Muzikos elektroninė-parduotuvė           │");
                    Console.WriteLine("╞════════════════════════════════════════════════════╡");
                    Console.WriteLine("| Pasirinkimai :                                     │");
                    Console.WriteLine("│ 1.  │   Keisti klientų duomenis                    │");
                    Console.WriteLine("│ 2.  │   Pakeisti dainos statusą                    │");
                    Console.WriteLine("│ 3.  │   Statistika (Darbuotojams)                  │");
                    Console.WriteLine("│ Q.  │   Atsijungti                                 │");
                    Console.WriteLine("└────────────────────────────────────────────────────┘");
                    break;
            }
        }

        private void PauseScreen()
        {
            Console.WriteLine();
            Console.WriteLine("Norėdami tęsti, paspauskite bet kurį mygtuką...");
            Console.ReadKey();
            Console.Clear();
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

        private void ShowCatalogOrderedAsc()
        {
            Console.WriteLine("Visas katalogas surikiuotas pagal 'Name' abecėlės tvarka:");
            var context = new ChinookContext();
            ITrackRepository tracks = new TrackRepository(context);
            tracks.Print(tracks.GetTracksSortedByNameAsc());
        }

        private void ShowCatalogOrderedDesc()
        {
            Console.WriteLine("Visas katalogas surikiuotas pagal 'Name' atvirkštine abecėlės tvarka:");
            var context = new ChinookContext();
            ITrackRepository tracks = new TrackRepository(context);
            tracks.Print(tracks.GetTracksSortedByNameDesc());
        }
        private void ShowCatalogOrderedByComposer()
        {
            Console.WriteLine("Visas katalogas surikiuotas pagal 'Composer':");
            var context = new ChinookContext();
            ITrackRepository tracks = new TrackRepository(context);
            tracks.Print(tracks.GetTracksSortedByComposer());
        }
        private void ShowCatalogOrderedByGenre()
        {
            Console.WriteLine("Visas katalogas surikiuotas pagal 'Genre':");
            var context = new ChinookContext();
            ITrackRepository tracks = new TrackRepository(context);
            tracks.Print(tracks.GetTracksSortedByGenre());
        }
        private void ShowCatalogOrderedByComposerAndAlbum()
        {
            Console.WriteLine("Visas katalogas surikiuotas pagal 'Composer' ir 'Album':");
            var context = new ChinookContext();
            ITrackRepository tracks = new TrackRepository(context);
            tracks.Print(tracks.GetTracksSortedByComposerAndAlbum());
        }
    }
}
