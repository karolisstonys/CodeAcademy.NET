using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Dormitory
    {
        internal static int dormId = 1;
        public Dormitory()
        {
            DormitoryId = dormId;
            dormId++;
            RoomCount = 1;
            Price = 10;
        }

        public Dormitory(int roomCount, decimal price)
        {
            DormitoryId = dormId;
            dormId++;
            RoomCount = roomCount;
            Price = price;
        }

        public int DormitoryId { get; private set; }
        public int RoomCount { get; set; }
        public decimal Price { get; set; }

        public List<Person> Persons { get; set; }
    }
}
