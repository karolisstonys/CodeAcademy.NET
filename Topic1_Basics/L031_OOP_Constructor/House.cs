using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L031_OOP_Constructor
{
    public class House
    {
        public House()
        {
            country = "unknown country";
            city = "unknown city";
            postCode = "unknown post code";
            streetName = "unknown street name";
            houseNumber = "unknown house number";
        }

        public House(string country, string city, string postCode, string streetName, string houseNumber, DateTime buildDate, int numberOfFloors, bool isBasemnt, Garage garage)
        {
            this.country = country;
            this.city = city;
            this.postCode = postCode;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
            this.buildDate = buildDate;
            this.numberOfFloors = numberOfFloors;
            this.isBasemnt = isBasemnt;
            this.Garage = garage;
        }

        public House(House house)
        {
            country = house.country;
            city = house.city;
            postCode = house.postCode;
            streetName = house.streetName;
            houseNumber = house.houseNumber;
            buildDate = house.buildDate;
            numberOfFloors = house.numberOfFloors;
            isBasemnt = house.isBasemnt;
            Garage = house.Garage;
        }

        // Klase aprasome tik public fieldais
        public string country;
        public string city;
        public string postCode;
        public string streetName;
        public string houseNumber;
        public DateTime buildDate = new DateTime(1900, 01, 01);
        public int numberOfFloors = 1;
        public bool isBasemnt = false;

        public Garage Garage;
    }
}
