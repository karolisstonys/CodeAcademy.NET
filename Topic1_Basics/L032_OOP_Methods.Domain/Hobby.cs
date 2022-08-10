using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Hobby
    {
        public Hobby() 
        {
            Id = 0;
            TekstasLietuviskai = "nėra teksto lietuviškai";
            Tekstas = "nėra teksto";
        }

        public Hobby(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }

        public int Id { get; set; }
        public string TekstasLietuviskai { get; private set; }
        public string Tekstas { get; private set; }
    }
}
