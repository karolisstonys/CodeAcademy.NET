using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Mokykla
    {
        private static int _identifier = 1;
        private static List<string> _pavadinimai = new List<string>()
        { 
            "Laukuvos Norberto Vėliaus gimnazija", "Lavoriškių gimnazija", "Lavoriškių Stepono Batoro gimnazija", 
            "Lazdijų Motiejaus Gustaičio gimnazija", "Lentvario Henriko Senkevičiaus gimnazija",
            "Lentvario Motiejaus Šimelionio gimnazija", "Lentvario Versmės gimnazija", "Šiaulių Lieporių gimnazija",
            "Lietuvos aklųjų ir silpnaregių ugdymo centras", "Lietuvos kurčiųjų ir neprigirdinčiųjų ugdymo centras",
            "Lietuvos sveikatos mokslų universiteto gimnazija", "Linkuvos gimnazija",
            "Liudvinavo Kazio Borutos gimnazija", "Lukšių Vinco Grybo gimnazija", "Luokės Vytauto Kleivos gimnazija"
        };

        public Mokykla()
        {
            Id = _identifier;
            _identifier++;
            Random rnd = new Random();
            Pavadinimas = _pavadinimai[rnd.Next(_pavadinimai.Count())];
            Mokytojai = new List<Mokytojas>();
        }

        public int Id { get; set; }

        public string Pavadinimas { get; set; }

        public List<Mokytojas> Mokytojai { get; set; }

    }
}
