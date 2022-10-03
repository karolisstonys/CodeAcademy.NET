using Music_eShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Infrastructure.Interfaces
{
    public interface ICustomerRepository
    {
        public List<Customer> Get();

        public Customer? Get(string customerId);

        public void Add(string customerFirtName, string customerLastName, string customerEmail);

        public void Update(long customerId, string firstName, string lastName, string? company, string? address, string? city, string? state, string? county, string? postalCode, string? phone, string? fax, string email, long? employeeId);

        public void Delete(long customerId);
    }
}
