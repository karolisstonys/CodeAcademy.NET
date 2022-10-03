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
        private readonly ICustomerRepository _customers;
        private readonly ITrackRepository _tracks;

        public ShopConsole()
        {
            var context = new ChinookContext();
            _customers = new CustomerRepository(context);
            _tracks = new TrackRepository(context);
        }

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
                    UpdateUserMenu();
                    break;
                default:
                    break;
            }
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
                        Environment.Exit(0);
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
                        //Įdėti į krepšelį
                        break;
                    case '3':
                    //Peržiūrėti krepšelį
                    case '4':
                        //Peržiūrėti pirkimų istorija (Išrašai)
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
                    case 'a':
                        PrintCatalogOrderedAsc();
                        break;
                    case 'b':
                        PrintCatalogOrderedDesc();
                        break;
                    case 'c':
                        PrintCatalogOrderedByComposer();
                        break;
                    case 'd':
                        PrintCatalogOrderedByGenre();
                        break;
                    case 'e':
                        PrintCatalogOrderedByComposerAndAlbum();
                        break;
                    case 'f':   
                        FindAndPrintTrackByID();
                        break;
                    case 'g':
                        FindAndPrintTracksByName();
                        break;
                    case 'h':
                        FindAndPrintTracksByComposer();
                        break;
                    case 'i':
                        FindAndPrintTracksByGenre();
                        break;
                    case 'j':
                        FindAndPrintTracksByComposerAndAlbum();
                        break;
                    case 'k': 
                        FindAndPrintTracksByMilliseconds();
                        break;
                    case 'l': // (BONUS)
                        FindAndPrintTracksByAlbumAndArtist();
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

        private void UpdateUserMenu()
        {
            ShowMenu();
            while (_state == AppState.UpdateUserScreen)
            {
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        ShowAllCustomers();
                        break;
                    case '2':
                        //Pašalinti pirkėją pagal ID (BONUS)
                        break;
                    case '3':
                        //Modifikuoti pirkėjo duomenis
                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.EmployeeScreen;
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                //PauseScreen();
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

            if (_state != AppState.EmployeeLogin)
            {
                Console.WriteLine("┌────────────────────────────────────────────────────┐");
                Console.WriteLine("│           Muzikos elektroninė-parduotuvė           │");
                Console.WriteLine("╞════════════════════════════════════════════════════╡");
                Console.WriteLine("| Pasirinkimai :                                     │");
            }

            switch (_state)
            {
                case AppState.LoginScreen:
                    Console.WriteLine("│ 1.  │   Prisijungti                                │");
                    Console.WriteLine("│ 2.  │   Registruotis                               │");
                    Console.WriteLine("│ 3.  │   Darbuotojų Parinktys                       │");
                    Console.WriteLine("| Q.  │   Išeiti                                     │");
                    break;
                case AppState.BuyScreen:
                    Console.WriteLine("│ 1.  │   Peržiūrėti katalogą                        │");
                    Console.WriteLine("│ 2.  │   Įdėti į krepšelį                           │");
                    Console.WriteLine("│ 3.  │   Peržiūrėti krepšelį                        │");
                    Console.WriteLine("│ 3.  │   Peržiūrėti pirkimų istorija (Išrašai)      │");
                    Console.WriteLine("│ Q.  │   Atsijungti                                 │");
                    break;
                case AppState.CatalogScreen:
                    Console.WriteLine("│ a   │   rikiavimas pagal Name abecėlės tvarka      │");
                    Console.WriteLine("│ b   │   rikiavimas pagal Name atvirkštine abecėle  │");
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
                    Console.WriteLine("│ 1.  │   Keisti klientų duomenis                    │");
                    Console.WriteLine("│ 2.  │   Pakeisti dainos statusą                    │");
                    Console.WriteLine("│ 3.  │   Statistika (Darbuotojams)                  │");
                    Console.WriteLine("│ Q.  │   Atsijungti                                 │");
                    break;
                case AppState.UpdateUserScreen:
                    Console.WriteLine("│ 1.  │   Gauti pirkėjų sąrašą                       │");
                    Console.WriteLine("│ 2.  │   Pašalinti pirkėją pagal ID                 │");
                    Console.WriteLine("│ 3.  │   Modifikuoti pirkėjo duomenis               │");
                    Console.WriteLine("│ Q.  │   Grįžti                                     │");
                    break; 
            }

            if (_state != AppState.EmployeeLogin)
            {
                Console.WriteLine("└────────────────────────────────────────────────────┘");
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
            Console.WriteLine();
            var allCustomers = _customers.Get();
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

            _customers.Add(firstName, lastName, email);
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

            var customer = _customers.Get(userId);

            var user = new User(customer.CustomerId, customer.FirstName + " " + customer.LastName);

            return user;
        }

        private void PrintCatalogOrderedAsc()
        {
            Console.WriteLine(" Visas katalogas surikiuotas pagal 'Name' abecėlės tvarka:");
            _tracks.Print(_tracks.GetTracksSortedByNameAsc());
        }

        private void PrintCatalogOrderedDesc()
        {
            Console.WriteLine(" Visas katalogas surikiuotas pagal 'Name' atvirkštine abecėlės tvarka:");
            _tracks.Print(_tracks.GetTracksSortedByNameDesc());
        }

        private void PrintCatalogOrderedByComposer()
        {
            Console.WriteLine(" Visas katalogas surikiuotas pagal 'Composer':");
            _tracks.Print(_tracks.GetTracksSortedByComposer());
        }

        private void PrintCatalogOrderedByGenre()
        {
            Console.WriteLine(" Visas katalogas surikiuotas pagal 'Genre':");
            _tracks.Print(_tracks.GetTracksSortedByGenre());
        }

        private void PrintCatalogOrderedByComposerAndAlbum()
        {
            Console.WriteLine(" Visas katalogas surikiuotas pagal 'Composer' ir 'Album':");
            _tracks.Print(_tracks.GetTracksSortedByComposerAndAlbum());
        }

        private void FindAndPrintTrackByID()
        {
            Console.Write(" Įveskite paieškos tekstą (Id): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Id':");
            _tracks.Print(_tracks.FindTracksById(searchText));
        }

        private void FindAndPrintTracksByName()
        {
            Console.Write(" Įveskite paieškos tekstą (Name): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Name':");
            _tracks.Print(_tracks.FindTracksByName(searchText));
        }

        private void FindAndPrintTracksByComposer()
        {
            Console.Write(" Įveskite paieškos tekstą (Composer): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Composer':");
            _tracks.Print(_tracks.FindTracksByComposer(searchText));
        }

        private void FindAndPrintTracksByGenre()
        {
            Console.Write(" Įveskite paieškos tekstą (Genre): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Genre':");
            _tracks.Print(_tracks.FindTracksByGenre(searchText));
        }

        private void FindAndPrintTracksByComposerAndAlbum()
        {
            Console.Write(" Įveskite paieškos tekstą (Composer ir Album): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Composer' ir 'Album':"); 
            _tracks.Print(_tracks.FindTracksByComposerAndAlbum(searchText));
        }

        private void FindAndPrintTracksByMilliseconds()
        {
            Console.Write("Įveskite paieškos tekstą (Milliseconds) nuo: ");
            var from = Console.ReadLine();
            Console.Write("Įveskite paieškos tekstą (Milliseconds) iki: ");
            var to = Console.ReadLine();
            _tracks.Print(_tracks.FindTracksByMilliseconds(from, to));
        }

        private void FindAndPrintTracksByAlbumAndArtist()
        {
            Console.Write(" Įveskite paieškos tekstą (Album ir Artist): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Album' ir 'Artist':");
            _tracks.Print(_tracks.FindTracksByAlbumAndArtist(searchText));
        }
    }
}
