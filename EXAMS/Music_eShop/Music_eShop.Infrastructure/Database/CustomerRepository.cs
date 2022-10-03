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
                    select c).ToList(); ;
        }

        public Customer? Get(string customerId)
        {
            long id = 0;
            while (!long.TryParse(customerId, out id))
            {
                Console.Write("Blogas pasirinkimas, bandykite dar kartą: ");
                customerId = Console.ReadLine();
            }
            var customer = new Customer();

            if (!_context.Customers.Any()) return customer;

            return (from c in _context.Customers
                    where c.CustomerId == id
                    select c).FirstOrDefault();
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

        public void Update(long customerId, string firstName, string lastName, string? company, string? address, string? city, string? state, string? county, string? postalCode, string? phone, string? fax, string email, long? employeeId)
        {
            var customer = _context.Customers.Find(customerId);
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Company = company;
            customer.Address = address;
            customer.City = city;
            customer.State = state;
            customer.Country = county;
            customer.PostalCode = postalCode;
            customer.Phone = phone;
            customer.Fax = fax;
            customer.Email = email;
            customer.SupportRepId = employeeId;
            _context.SaveChanges();
        }

        public void Delete(long customerId)
        {
            throw new NotImplementedException();
        }
    }
}
