using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Models
{
    public class Peg
    {
        public EDisks[] Levels { get; set; } //= new EDisks[4];

        public Peg()
        {
            Levels = new EDisks[4]{ EDisks.NoDisk, EDisks.NoDisk, EDisks.NoDisk, EDisks.NoDisk };
        }

        public Peg(EDisks row1, EDisks row2, EDisks row3, EDisks row4)
        {
            Levels = new EDisks[4] { row1, row2, row3, row4 };
        }
    }
}
