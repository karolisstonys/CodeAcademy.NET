using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L038_Practice.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }

        public Hobby() { }

        public Hobby(int id, string text, string textLt)
        {
            Id = id;
            Text = text;
            TextLt = textLt;
        }

        public void HobbyExtractor(string value)
        {
            var arr = value.Split(',');

            if (arr.Length != 3)
                return;
            if (!int.TryParse(arr[0], out int intId))
                return;

            Id = intId;
            Text = arr[1];
            TextLt = arr[2];
        }
    }
}
