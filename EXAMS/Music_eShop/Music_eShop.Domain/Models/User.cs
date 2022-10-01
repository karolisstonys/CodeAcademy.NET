using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_eShop.Domain.Models
{
    public class User
    {
        public User() { }

        public User(long customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
        }

        public long CustomerID { get; set; }

        public string Name { get; set; }

        public Dictionary<int, int> Cart { get; set; }
    }
}
