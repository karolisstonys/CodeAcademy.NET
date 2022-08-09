using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L031_OOP_Constructor
{
    public class Country
    {
        public Country()
        {
            Name = "Lietuva";
        }

        public Country(string name, long population, decimal areaInSqrKm, FriendlyCountry friendlyCountry)
        {
            Name = name;
            Population = population;
            AreaInSqrKm = areaInSqrKm;
            FriendlyCountry = friendlyCountry;
        }

        public Country(Country country)
        {
            Name = country.Name;
            Population = country.Population;
            AreaInSqrKm = country.AreaInSqrKm;
            FriendlyCountry = country.FriendlyCountry;
        }

        public string Name { get; set; }
        public long Population { get; set; } = 0;
        public decimal AreaInSqrKm { get; set; } = 0M;

        public FriendlyCountry FriendlyCountry;
    }
}
