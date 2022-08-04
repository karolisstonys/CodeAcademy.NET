using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030_OOP_Composition
{
    public class House
    {
        // Klase aprasome tik public fieldais
        public string country;
        public string city;
        public string postCode;
        public string streetName;
        public string houseNumber;
        public DateOnly buildDate;
        public int numberOfFloors;
        public bool isBasemnt;

        public Garage Garage;
    }
}
