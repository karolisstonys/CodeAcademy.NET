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
        private readonly IEmployeeRepository _employee;
        private readonly ITrackRepository _tracks;

        public ShopConsole()
        {
            var context = new ChinookContext();
            _customers = new CustomerRepository(context);
            _employee = new EmployeeRepository(context);
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
                    AddToCartMenu();
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


        // -------------------------------------------

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
                        Console.Clear();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                //PauseScreen();
            }
        }

        private void BuyMenu()
        {
            while (_state == AppState.BuyScreen)
            {
                ShowMenu();
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        _state = AppState.CatalogScreen;
                        break;
                    case '2':
                        _state = AppState.AddToCartScreen;                        
                        break;
                    case '3':
                        PrintCart();
                        break;
                    case '4':
                        //Peržiūrėti pirkimų istorija (Išrašai)
                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.LoginScreen;
                        _user = null;
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                PauseScreen();
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
                        Console.Clear();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                PauseScreen();
            }
        }

        private void AddToCartMenu()
        {
            while (_state == AppState.AddToCartScreen)
            {
                ShowMenu();
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        //Rasti dainą pagal Id
                        FindAndAddToCartTracksById();
                        break;
                    case '2':
                        //Rasti dainą pagal pavadinimą
                        FindAndAddToCartTracksByName();
                        break;
                    case '3':
                        //Rasti dainas pagal albumo Id
                        break;
                    case '4':
                        //Rasti dainas pagal albumo pavadinimą
                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.BuyScreen;
                        return;
                    default:
                        Console.Clear();
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
            var employee = _employee.Get(1);
            _user = new User()
            {
                CustomerID = null,
                EmoloyeeID = 1,            
                Name =  employee.Title + " " + employee.FirstName + " " + employee.LastName
            };
        }

        private void EmployeeMenu()
        {
            while (_state == AppState.EmployeeScreen)
            {
                ShowMenu();
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1': // Keisti klientų duomenis
                        _state = AppState.UpdateUserScreen;
                        break;
                    case '2':
                        //Pakeisti dainos statusą
                        ChangeTackStatus();
                        break;
                    case '3':
                        //Statistika (Darbuotojams)
                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.LoginScreen;
                        _user = null;
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                PauseScreen();
            }
        }

        private void UpdateUserMenu()
        {
            while (_state == AppState.UpdateUserScreen)
            {
                ShowMenu();
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1':
                        ShowAllCustomers();
                        break;
                    case '2':
                        //Pašalinti pirkėją pagal ID (BONUS)
                        FindAndDeleteCusttomer();
                        break;
                    case '3':
                        //Modifikuoti pirkėjo duomenis
                        FindAndUpdateCustomer();
                        break;
                    case 'q' or 'Q':  // ESC
                        _state = AppState.EmployeeScreen;
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Blogas pasirinkimas, bandykite iš naujo.");
                        break;
                }
                PauseScreen();
            }
        }

        // -------------------------------------------

        private void ShowMenu()
        {
            if (_user != null)
            {
                Console.WriteLine("┌────────────────────────────────────────────────────┐");
                Console.WriteLine($"│Vartotojas:{_user.Name,41}│");
                Console.WriteLine($"│Dainos krepšelyje:{_user.Cart.Count(),34}│");
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
                    Console.WriteLine("│ 4.  │   Peržiūrėti pirkimų istorija (Išrašai)      │");
                    Console.WriteLine("│ Q.  │   Atsijungti                                 │");
                    break; 
                case AppState.AddToCartScreen:
                    Console.WriteLine("│ 1.  │   Rasti dainą pagal Id                       │");
                    Console.WriteLine("│ 2.  │   Rasti dainą pagal pavadinimą               │");
                    Console.WriteLine("│ 3.  │   Rasti dainas pagal albumo Id               │");
                    Console.WriteLine("│ 4.  │   Rasti dainas pagal albumo pavadinimą       │");
                    Console.WriteLine("│ Q.  │   Grįžti                                     │");
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

        // -------------------------------------------

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

        public User Login(string customerId)
        {
            var customer = _customers.Get(customerId);

            var user = new User(customer.CustomerId, null, customer.FirstName + " " + customer.LastName);

            return user;
        }

        private void FindAndUpdateCustomer()
        {
            Console.Write(" Pasirinkite Customer pagal ID: ");
            var customer = _customers.Get(Console.ReadLine());

            Console.Write($"Customer FirstName '{customer.FirstName}' keisti į: ");
            var newFirstName = Console.ReadLine();
            Console.Write($"Customer LastName '{customer.LastName}' keisti į: ");
            var newLastName = Console.ReadLine();
            Console.Write($"Customer Company '{customer.Company}' keisti į: ");
            var newCompany = Console.ReadLine();
            Console.Write($"Customer Address '{customer.Address}' keisti į: ");
            var newAddress = Console.ReadLine();
            Console.Write($"Customer City '{customer.City}' keisti į: ");
            var newCity = Console.ReadLine();
            Console.Write($"Customer State '{customer.State}' keisti į: ");
            var newState = Console.ReadLine();
            Console.Write($"Customer Country '{customer.Country}' keisti į: ");
            var newCountry = Console.ReadLine();
            Console.Write($"Customer PostalCode '{customer.PostalCode}' keisti į: ");
            var newPostalCode = Console.ReadLine();
            Console.Write($"Customer Phone '{customer.Phone}' keisti į: ");
            var newPhone = Console.ReadLine();
            Console.Write($"Customer Fax '{customer.Fax}' keisti į: ");
            var newFax = Console.ReadLine();
            Console.Write($"Customer Email '{customer.Email}' keisti į: ");
            var newEmail = Console.ReadLine();

            _customers.Update(customer.CustomerId, newFirstName, newLastName, newCompany, newAddress, newCity, newState, newCountry, newPostalCode, newPhone, newFax, newEmail, _user.EmoloyeeID);
            Console.WriteLine("Customer pakeistas sekmingai");
        }

        private void FindAndDeleteCusttomer()
        {
            Console.Write(" Pasirinkite Customer pagal ID: ");
            var customer = _customers.Get(Console.ReadLine());
            throw new NotImplementedException();
        }

        private void ChangeTackStatus()
        {
            Console.Write(" Pasirinkite Track pagal ID: ");
            var track = _tracks.Get(Console.ReadLine());
            Console.WriteLine($"{track.Name} [{track.Status}]");

            Console.Write("Ar norite keisti [Status] ? (t/n) ");
            if (Console.ReadKey().KeyChar == 't')
            {
                track = _tracks.ChangeStatus(track.TrackId.ToString());
                Console.WriteLine($"\n{track.Name} [{track.Status}\n]");
            }
        }

        private void PrintCatalogOrderedAsc()
        {
            Console.WriteLine("\nVisas katalogas surikiuotas pagal 'Name' abecėlės tvarka:");
            _tracks.Print(_tracks.GetTracksSortedByNameAsc());
        }

        private void PrintCatalogOrderedDesc()
        {
            Console.WriteLine("\nVisas katalogas surikiuotas pagal 'Name' atvirkštine abecėlės tvarka:");
            _tracks.Print(_tracks.GetTracksSortedByNameDesc());
        }

        private void PrintCatalogOrderedByComposer()
        {
            Console.WriteLine("\nVisas katalogas surikiuotas pagal 'Composer':");
            _tracks.Print(_tracks.GetTracksSortedByComposer());
        }

        private void PrintCatalogOrderedByGenre()
        {
            Console.WriteLine("\nVisas katalogas surikiuotas pagal 'Genre':");
            _tracks.Print(_tracks.GetTracksSortedByGenre());
        }

        private void PrintCatalogOrderedByComposerAndAlbum()
        {
            Console.WriteLine("\nVisas katalogas surikiuotas pagal 'Composer' ir 'Album':");
            _tracks.Print(_tracks.GetTracksSortedByComposerAndAlbum());
        }

        private void FindAndPrintTrackByID()
        {
            Console.Write("\nĮveskite paieškos tekstą (Id): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Id':");
            _tracks.Print(_tracks.FindTracksById(searchText));
        }

        private void FindAndPrintTracksByName()
        {
            Console.Write("\nĮveskite paieškos tekstą (Name): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Name':");
            _tracks.Print(_tracks.FindTracksByName(searchText));
        }

        private void FindAndPrintTracksByComposer()
        {
            Console.Write("\nĮveskite paieškos tekstą (Composer): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Composer':");
            _tracks.Print(_tracks.FindTracksByComposer(searchText));
        }

        private void FindAndPrintTracksByGenre()
        {
            Console.Write("\nĮveskite paieškos tekstą (Genre): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Genre':");
            _tracks.Print(_tracks.FindTracksByGenre(searchText));
        }

        private void FindAndPrintTracksByComposerAndAlbum()
        {
            Console.Write("\nĮveskite paieškos tekstą (Composer ir Album): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Composer' ir 'Album':"); 
            _tracks.Print(_tracks.FindTracksByComposerAndAlbum(searchText));
        }

        private void FindAndPrintTracksByMilliseconds()
        {
            Console.Write("\nĮveskite paieškos tekstą (Milliseconds) nuo: ");
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

        private void FindAndAddToCartTracksById()
        {
            Console.Write("\nĮveskite paieškos tekstą (Id): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Id':");
            var tracks = _tracks.FindTracksById(searchText);
            _tracks.Print(tracks);


            if (tracks.Count == 0) return;

            Console.Write("Ar norite įdėti rasts dainas į krepšelį? (t/n) ");
            if (Console.ReadKey().KeyChar == 't')
            {
                AddToCart(tracks);
                Console.WriteLine("\nĮ krepšelį įdėta sekmingai.");
            }
        }

        private void FindAndAddToCartTracksByName()
        {
            Console.Write("\nĮveskite paieškos tekstą (Name): ");
            var searchText = Console.ReadLine();
            Console.WriteLine(" Daina/os pagal 'Id':");
            var tracks = _tracks.FindTracksByName(searchText);
            _tracks.Print(tracks);

            if (tracks.Count == 0) return;

            Console.Write("Ar norite įdėti rasts dainas į krepšelį? (t/n) ");
            if (Console.ReadKey().KeyChar == 't')
            {
                AddToCart(tracks);
                Console.WriteLine("\nĮ krepšelį įdėta sekmingai.");
            }
        }

        private void AddToCart(List<Track> tracks)
        {
            foreach (var track in tracks)
            {
                var trackIsInCart = false;
                // Goes through CART and looks for same track   // Increase count if found 
                foreach (var cartItem in _user.Cart)
                {
                    if (cartItem.trackId == track.TrackId)
                    {
                        cartItem.trackCount++;
                        trackIsInCart = true;
                    }
                }

                // If track is not in CART, adds it
                if (!trackIsInCart) _user.Cart.Add(new CartTrack() { trackId = track.TrackId, trackCount = 1 });
            }
        }

        private void PrintCart()
        {
            string albumTitle = "";
            string genreName = "";
            string composer = "";

            Console.WriteLine();
            Console.WriteLine("┌────┬─────────────────────────────────────────────┬─────────────────────────────────────────────┬───────────────────────────────────┬────────────────────┬──────────┬──────────┐");
            Console.WriteLine($"│{"Id",-4}│{"Name",-45}│{"Composer",-45}│{"Album",-35}│{"Genre",-20}│{"Kaina",-10}│{"Kiekis",-10}│");
            Console.WriteLine("├────┼─────────────────────────────────────────────┼─────────────────────────────────────────────┼───────────────────────────────────┼────────────────────┼──────────┼──────────┤");
            foreach (var cartItem in _user.Cart)
            {
                var track = _tracks.Get(cartItem.trackId.ToString());
                if (track.AlbumId != null) albumTitle = track.Album.Title;
                if (track.GenreId != null) genreName = track.Genre.Name;
                if (track.Composer != null) composer = track.Composer;

                Console.WriteLine($"│{track.TrackId,-4}│{track.Name.Truncate(44),-45}│{composer.Truncate(44),-45}│{albumTitle.Truncate(34),-35}│{genreName.Truncate(19),-20}│{Encoding.Default.GetString(track.UnitPrice),-10}│{cartItem.trackCount,-10}│");
            }
            Console.WriteLine("└────┴─────────────────────────────────────────────┴─────────────────────────────────────────────┴───────────────────────────────────┴────────────────────┴──────────┴──────────┘");

        }

    }
    public static class StringExt
    {
        public static string? Truncate(this string? value, int maxLength, string truncationSuffix = "…")
        {
            return value?.Length > maxLength
                ? value.Substring(0, maxLength) + truncationSuffix
                : value;
        }
    }
}
