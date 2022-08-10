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
            TextLT = "-";
            Text = "-";
        }

        public Profession(int id, string textLT, string text)
        {
            Id = id;
            TextLT = textLT;
            Text = text;
        }

        public int Id { get; private set; }
        public string TextLT { get; private set; }
        public string Text { get; set; }





    }
}
