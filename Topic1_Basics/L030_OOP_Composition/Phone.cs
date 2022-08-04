using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030_OOP_Composition
{
    internal class Phone
    {
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        private decimal dimension;

        public decimal Dimension
        {
            get { return dimension; }
            set { dimension = value; }
        }

        private decimal weight;

        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }




    }
}
