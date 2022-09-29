using Music_eShop.Domain.Services;
using Music_eShop.Infrastructure;
using Music_eShop.Infrastructure.Database;
using Music_eShop.Infrastructure.Interfaces;
using System.Text;

namespace Music_eShop
{
    internal class Program
    {
        private static ICustomerRepository _customerRepository = new CustomerRepository();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            IShopConsole eShop = new ShopConsole();
            eShop.Run();

        }

        //protected static IEnumerable<dynamic> GetCustomersByCountry(string country)
        //{
        //    using (var db = new ChinookContext())
        //    {
        //        var res = db.Customers.Where(x => x.Country == country).Select(c => new
        //        {
        //            Vardas = c.FirstName,
        //            KlientoId = c.CustomerId,
        //            SaliesPavadinimas = c.Country,
        //        });
        //        return res;
        //    }
        //}



    }
}