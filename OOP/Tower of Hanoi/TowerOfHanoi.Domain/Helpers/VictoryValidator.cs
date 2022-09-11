﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Helpers
{
    public class VictoryValidator
    {
        internal int _disk1 = 0;
        internal int _disk2 = 0;
        internal int _disk3 = 0;
        internal int _disk4 = 0;

        public string MovesUntilVictory { get; internal set; } = "";

        public bool IsAllDisksLastMovesFoundInTxtLog(string line)
        {
            // žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 11, 2 dalių diskas buvo paimtas iš trečio sulpelio ir padėtas į pirmą
            // žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 13, 4 dalių diskas buvo paimtas iš pirmo sulpelio ir padėtas į antrą
            // žaidime kuris pradėtas 2022-09-11 12:13:28, ėjimu nr 15, 1 dalių diskas buvo paimtas iš antro sulpelio ir padėtas į trečią

            int notNeededBegining = 53;
            line = line.Remove(0, notNeededBegining);
            string[] splitLine = line.Split(", ");
            int foundDiskNo = Convert.ToInt32(splitLine[1].Substring(0, 1));
            string putToPeg = splitLine[1].Split(" sulpelio ir padėtas į ")[1];

            if (_disk1 == 0 && foundDiskNo == 1)
                _disk1 = Converter.ToPegWordConvertToNumber(putToPeg);
            if (_disk2 == 0 && foundDiskNo == 2)
                _disk2 = Converter.ToPegWordConvertToNumber(putToPeg);
            if (_disk3 == 0 && foundDiskNo == 3)
                _disk3 = Converter.ToPegWordConvertToNumber(putToPeg);
            if (_disk4 == 0 && foundDiskNo == 4)
                _disk4 = Converter.ToPegWordConvertToNumber(putToPeg);

            return IsAllDisksFound();
        }

        public bool IsAllDisksLastMovesFoundInHtmlLog(List<string> lines)
        {
            //<td>2022-09-10 16:35:02</td>
            //<td>4</td>
            //<td>2</td>
            //<td>2</td>
            //<td>1</td>
            //<td>1</td>

            for (int i = 0; i < lines.Count(); i++) lines[i] = lines[i].Replace("<td>", "").Replace("</td>", "");
            MovesUntilVictory = lines[1];
            _disk1 =  Convert.ToInt32(lines[2]);
            _disk2 =  Convert.ToInt32(lines[3]);
            _disk3 =  Convert.ToInt32(lines[4]);
            _disk4 =  Convert.ToInt32(lines[5]);

            return IsAllDisksFound();
        }


        internal bool IsAllDisksFound() => _disk1 != 0 && _disk2 != 0 && _disk3 != 0 && _disk4 != 0;
        internal bool IsGameWon() => _disk1 == 3 && _disk2 == 3 && _disk3 == 3 && _disk4 == 3;
    }
}
