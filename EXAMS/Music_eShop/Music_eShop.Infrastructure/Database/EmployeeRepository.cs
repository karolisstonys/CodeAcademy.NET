using Music_eShop.Domain.Models;
using Music_eShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Infrastructure.Database
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ChinookContext _context;

        public EmployeeRepository() { }

        public EmployeeRepository(ChinookContext context)
        {
            _context = context;
        }

        public Employee Get(long id)
        {
            return _context.Employees.Find(id);
        }
    }
}
