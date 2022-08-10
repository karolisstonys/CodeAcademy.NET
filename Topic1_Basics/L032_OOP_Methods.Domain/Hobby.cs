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
            TextLT = "nėra teksto lietuviškai";
            Text = "nėra teksto";
        }

        public Hobby(int id, string textLT, string text)
        {
            Id = id;
            TextLT = textLT;
            Text = text;
        }

        public int Id { get; set; }
        public string TextLT { get; private set; }
        public string Text { get; private set; }
    }
}
