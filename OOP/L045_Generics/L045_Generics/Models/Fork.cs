using L045_Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L045_Generics.Models
{
    public class Fork : Tool, ITool
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("This is a fork which is used for eating hard food.");
        }


        public override string ToString()
        {
            return "Labas rytas stai ir as!";
        }
    }
}
