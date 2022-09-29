using DB_Music_Shop.Infrastructure.Database;

namespace DB_Music_Shop.Domain.Services

{
    public class Temp
    {
        public IEnumerable<dynamic> GetCustomersByCountry(string country)
        {
            using (var ctx = new ChinookContext())
            {
                var res = ctx.Customers.Where(x => x.Country == country).Select(c => new
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
