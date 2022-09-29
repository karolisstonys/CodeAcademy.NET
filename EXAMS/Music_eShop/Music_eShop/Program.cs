using Music_eShop.Infrastructure;
using System.Text;

namespace Music_eShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Console.WriteLine("Hello, Music eShop!");

            //Scaffold-DbContext "DataSource=I:\CODING\GitHub_CodeAcademy.NET\EXAMS\Music_eShop\Music_eShop.Infrastructure\Database\Chinook.db" Microsoft.EntityFrameworkCore.Sqlite



        }

        protected static IEnumerable<dynamic> GetCustomersByCountry(string country)
        {
            using (var db = new ChinookContext())
            {
                var res = db.Customers.Where(x => x.Country == country).Select(c => new
                {
                    Vardas = c.FirstName,
                    KlientoId = c.CustomerId,
                    SaliesPavadinimas = c.Country,
                });
                return res;
            }
        }



    }
}