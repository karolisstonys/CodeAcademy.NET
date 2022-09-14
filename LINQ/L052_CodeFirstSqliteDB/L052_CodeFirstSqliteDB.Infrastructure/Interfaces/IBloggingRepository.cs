using L052_CodeFirstSqliteDB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L052_CodeFirstSqliteDB.Infrastructure.Interfaces
{
    public interface IBloggingRepository
    {
        void AddPerson(Person person);

        void AddPerson(string firstName, string lastName, int age);
    }
}
