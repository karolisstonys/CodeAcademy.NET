using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030_OOP_Composition
{
    public class Country
    {
        public string Name { get; set; }
        public long  Population { get; set; }
        public decimal AreaInSqrKm { get; set; }

        public FriendlyCountry FriendlyCountry;
    }
}
