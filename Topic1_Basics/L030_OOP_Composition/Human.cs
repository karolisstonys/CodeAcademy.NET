using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030_OOP_Composition
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public List<string> Language { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
