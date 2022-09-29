using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Infrastructure.Database
{
    public class CustomerRepository : ICustomerRepository
    {

        public List<Customer> Get()
        {
            using (var db = new ChinookContext())
            {
                //return db.Customers.Select(c => c).ToList();

                var result = from c in db.Customers
                             select c;
                return result.ToList();

            }
        }
    }
}
