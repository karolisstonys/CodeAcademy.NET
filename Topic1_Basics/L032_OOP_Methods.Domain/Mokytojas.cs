using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Mokytojas
    {
        private static int _identifier = 1;
        private static List<string> _vardai = new List<string>()
        {
            "Lukas", "Matas", "Nojus", "Dominykas", "Dovydas", "Rokas", "Mantas", "Jokūbas", "Jonas", "Kajus",
            "Gabija", "Emilija", "Gabrielė", "Kamilė", "Ugnė", "Austėja", "Ieva", "Viktorija", "Viltė", "Urtė"
        };

        public Mokytojas()
        {
            Id = _identifier;
            _identifier++;
            Random rnd = new Random();
            Vardas = _vardai[rnd.Next(_vardai.Count())];
            Pamoka = new Pamoka();
            PamokosId = Pamoka.Id;
            Studentai = new List<Studentas>();  //temp
        }

        public Mokytojas(Mokykla mokykla) : this()
        {
            Mokykla = mokykla;
            Mokykla.Mokytojai.Add(this);
            MokyklosId = Mokykla.Id;
        }

        public int Id { get; set; }

        public string Vardas { get; set; }

        public Mokykla Mokykla { get; set; }

        public int MokyklosId { get; set; }

        public Pamoka Pamoka { get; set; }

        public int PamokosId { get; set; }

        public List<Studentas> Studentai { get; set; }


    }
}
