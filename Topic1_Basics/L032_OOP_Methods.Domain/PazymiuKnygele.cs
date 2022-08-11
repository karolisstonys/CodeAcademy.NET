using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class PazymiuKnygele
    {
        private static int _identifier = 1;

        public PazymiuKnygele()
        {
            Id = _identifier;
            _identifier++;
            Pazymiai = new Dictionary<Pamoka, List<int>>();
        }

        public PazymiuKnygele(Studentas studentas)
        {
            Studentas = studentas;
            //StudentoId = Studentas.Id;
        }

        public int Id { get; set; }

        public Studentas Studentas { get; set; }

        public int StudentoId { get; set; }

        public Dictionary<Pamoka, List<int>> Pazymiai { get; set; }

    }
}
