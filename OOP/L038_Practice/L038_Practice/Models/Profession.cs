using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }

        public Profession() { }

        public Profession(int id)
        {
            Id = id;
        }
    }
}
