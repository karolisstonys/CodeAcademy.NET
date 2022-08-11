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
            Name = "nezinomas";
            Random rnd = new Random();
            RoomCount = rnd.Next(1, 20);
            Price = rnd.Next(20, 200);
            Persons = new List<Person>();
        }
        public Dormitory(Person person) : this()
        {
            Persons.Add(person);
        }

        public Dormitory(string name) : this()
        {
            Name = name;
        }

        public int DormitoryId { get; private set; }

        public string Name { get; set; }

        public int RoomCount { get; set; }

        public decimal Price { get; set; }

        public List<Person> Persons { get; set; }

    }
}
