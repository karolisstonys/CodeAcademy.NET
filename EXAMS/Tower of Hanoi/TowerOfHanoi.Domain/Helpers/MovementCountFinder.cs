using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class MovementCountFinder
    {

        // žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 11, 2 dalių diskas buvo paimtas iš trečio sulpelio ir padėtas į pirmą
        // žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 13, 4 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą
        // žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 15, 1 dalių diskas buvo paimtas iš antro sulpelio ir padėtas į trečią

        public static string FromTxtLine(string line)
        {
            string moves = "";
            line = line.Substring(53);

            return moves = line.Split(", ")[0];
        }

    }
}
