using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Skaiciuoklis
    {
        private int skaicius;

        private int Skaicius
        {
            get { return skaicius; }
            set { skaicius = value; }
        }


        public Skaiciuoklis(int skaicius)
        {
            Skaicius = skaicius;
        }

        public void Didinti()
        {
            Skaicius++;
        }
        public void Mazinti()
        {
            if (Skaicius > 0)
            Skaicius--;
        }

        public void Atspausdinti()
        {
            Console.WriteLine(Skaicius);
        }

        public void Perkrauti()
        {
            Skaicius = skaicius;
        }
    }
}
