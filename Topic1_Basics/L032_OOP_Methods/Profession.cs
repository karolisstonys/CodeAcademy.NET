using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods
{
    public class Profession
    {
        public Profession()
        {
            Id = 0;
            TekstasLietuviskai = "";
            Tekstas = "";
        }

        public Profession(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }

        public int Id { get; private set; }
        public string TekstasLietuviskai { get; private set; }
        public string Tekstas { get; set; }





    }
}
