using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class House
    {
        public House()
        {
            PeopleNames = new List<string>();
            People = new List<People>()
            {
                new People() { Name = "Petras" },
                new People() { Name = "Ieva" },
                new People() { Name = "Jonas" },
            };

            foreach (var ppl in People)
            {
                PeopleNames.Add(ppl.Name);
            }
        }

        public House(int roomCount) : this()
        {
            RoomCount = roomCount;
        }

        internal List<People> People { get; set; }
        
        private List<string> peopleNames;

        public List<string> PeopleNames
        {
            get { return peopleNames; }
            set { peopleNames = value; }
        }

        public int RoomCount { get; private set; }
    }
}
