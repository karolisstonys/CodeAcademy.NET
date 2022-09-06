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
        private EDisks row1;
        private EDisks row2;
        private EDisks row3;
        private EDisks row4;

        public EDisks[] Rows { get; set; } = new EDisks[4];

        public Peg()
        {
            this.row1=EDisks.Empty;
            this.row2=EDisks.Empty;
            this.row3=EDisks.Empty;
            this.row4=EDisks.Empty;
        }

        public Peg(EDisks row1, EDisks row2, EDisks row3, EDisks row4)
        {
            this.row1=row1;
            this.row2=row2;
            this.row3=row3;
            this.row4=row4;
        }
    }
}
