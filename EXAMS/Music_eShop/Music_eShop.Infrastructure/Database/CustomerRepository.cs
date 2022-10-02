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
        private readonly ChinookContext _context;

        public CustomerRepository() { }

        public CustomerRepository(ChinookContext context)
        {
            _context = context;
        }

        public List<Customer> Get()
        {
                var customers = new List<Customer>();                
                
                if (!_context.Customers.Any()) return customers;

                return (from c in _context.Customers
                              select c).ToList();;
        }

        public void Add(string customerFirtName, string customerLastName, string customerEmail)
        {
            var newCustomer = new Customer()
            {
                FirstName = customerFirtName,
                LastName = customerLastName,
                Email = customerEmail,
            };
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
        }

        public void Update(int customerId, string customerFirtName, string customerLastName)
        {
            //using (var context = new BloggingContext())
            //{
            //    var blog = context.Blogs.Find(blogId);
            //    blog.Name = name;
            //    context.SaveChanges();
            //}
        }
    }
}
