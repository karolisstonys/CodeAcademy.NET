using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Pamoka
    {
        private static int _identifier = 1;
        private static List<string> _pamokos = new List<string>()
        {
            "Matematika A", "Matematika B", "Biologija", "Lietuvių kalba", "Anglų kalba A", "Anglų kalba B", "Lietuvių kalba A", 
            "Lietuvių kalba B", "Chemija", "Istorija", "Technologijos", "Žmogaus sauga", "Kūno kultūra", "Pilietiškumo pagrindai",
             "Pamoka X", "Pamoka Y", "Pamoka Z", "Pamoka W", "Pamoka Q", "Pamoka S", "Pamoka K", "Pamoka 1", "Pamoka 2", "Pamoka 3"
        };

        public Pamoka()
        {
            Id = _identifier;
            _identifier++;
            Random rnd = new Random();
            Pavadinimas = _pamokos[rnd.Next(_pamokos.Count())];
        }

        public Pamoka(Mokytojas mokytojas) :this()
        {
            Mokytojas = mokytojas;
        }

        public int Id { get; set; }

        public string Pavadinimas { get; set; }

        public Mokytojas Mokytojas { get; set; }
    }
}
