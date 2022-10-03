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

        public User(long? customerID, long? employeeID, string name)
        {
            CustomerID = customerID;
            EmoloyeeID = employeeID;
            Name = name;
        }

        public long? CustomerID { get; set; }

        public long? EmoloyeeID { get; set; }

        public string Name { get; set; }

        public Cart Cart { get; set; } = new Cart();
    }

    public class Cart : List<CartTrack> { }

    public class CartTrack
    {
        public long trackId;

        public int trackCount;
    }

}
