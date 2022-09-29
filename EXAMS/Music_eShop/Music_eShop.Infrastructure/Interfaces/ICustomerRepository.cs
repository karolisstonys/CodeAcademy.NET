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
    }
}
