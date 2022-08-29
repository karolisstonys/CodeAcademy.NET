using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L042_Practice.Models.Abstract
{
    public abstract class Book
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public long BooksSold { get; set; }
        public int? Qtty { get; set; }
        public double? Price { get; set; }
    }
}
