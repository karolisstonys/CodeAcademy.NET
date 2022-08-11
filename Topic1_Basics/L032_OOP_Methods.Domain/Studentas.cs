using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{
    public class Studentas
    {
        private static int _identifier = 1;
        private static List<string> _vardai = new List<string>()
        {
            "Otrėja", "Dijara", "Graziella", "Hinda", "Adeilė", "Samogitė", "Tikvėja", "Ileta", "Kantrė", "Kopa", "Lėsia", "Zeynab", "Liela", "Avia", "Indiana", "Miel", "Sevena", "Deilina", "Nellė", "Ornella", "Daminika", "Elaira", "Dua", "Aisnė", "Erieta", "Itanė", "Dolija", "Shahnoor", "Smėja", "Rayhan", "Arana", "Sare", "Zakia", "Manilla", "Simdeilė", "Tomėja", "Rianna", "Miryel", "Cilla", "Minelė", "Dorotilė", "Aleina", "Eividė", "Iza", "Zelda", "Olimpia", "Ergeida", "Simha", "Ateitis", "Braina", "Guna", "Arfėja", "Nikolettė", "Melitina", "Mirgėja", "Maneila", "Romi", "Jelija", "Militina", "Eularija", "Francisca", "Amielija", "Krėja", "Aramesh", "Caramela", "Adrina", "Stefanė", "Einera", "Teseja", "Manuelia", "Ameira", "Luize", "Aldera", "Noeva", "Maribela", "Iesenija", "Rivelė", "Kasiopėja", "Vivita", "Keitlina", "Railė", "Alaiza", "Sevastiana", "Osėja", "Teiva", "Miray", "Boneta", "Julinga", "Melea", "Gabytė", "Laja", "Sundari", "Tulpė", "Ėmilė", "Iuliana",
            "Ibragimas", "Goras", "Safeer", "Haidaras", "Pablas", "Nill", "Eidrianas", "Damil", "Younis", "Usmon", "Džulian", "Odysseas", "Sraunius", "Zeus", "Gatas", "Helbertas", "Merfis", "Izmir", "Venjamin", "Everardas", "Maksym", "Kristiaan", "Svėnas", "Arseniuš", "Agat", "Marks", "Felipe", "Sevold", "Ezekėlius", "Liran", "Maddoxx", "Matajus", "Maksimilijanas", "Reimonas", "Limas", "Emar", "Taurus", "Kemal", "Džerodas", "Sarek", "Damodaras", "Roald", "Amžius", "Ramilius", "Milkyas", "Leanid", "Vilenas", "Džailanas", "Nael", "Ardijus", "Volfgang", "Naggar", "Miraj", "Amelis", "Kaidas", "Bahram", "Darvin", "Aratėjus", "Jamal", "Liavon", "Mėlius", "Akeras", "Emitas", "Ozan", "Seven", "Ratibor", "Arok", "Kostya", "Atijus", "Gaudridas", "Eliyah", "Nilan", "Imandas", "Nolan", "Raenas", "Uras", "Tovit", "Tamirlanas", "Fabricijus", "Elijius", "Mikus", "Tadevush", "Josufas", "Dasij", "Altair", "Govinda", "Gilis", "Šerif"
        };

        public Studentas()
        {
            Id = _identifier;
            _identifier++;
            Random rnd = new Random();
            Vardas = _vardai[rnd.Next(_vardai.Count())];
            Mokytojai = new List<Mokytojas>();
        }

        public Studentas(Mokytojas Mokytojas) :this()
        {
            Mokytojai.Add(Mokytojas);
        }

        public int Id { get; set; }

        public string Vardas { get; set; }

        public List<Mokytojas> Mokytojai { get; set; }

        public PazymiuKnygele PazymiuKnygele { get; set; }

        public int PazymiuKnigelesId { get; set; }

    }
}
