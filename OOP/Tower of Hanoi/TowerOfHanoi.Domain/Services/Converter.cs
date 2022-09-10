using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Services
{
    public class Converter
    {
        public string DiskNumberToWord(int number)
        {
            return number switch
            {
                1 => "1 dalies diskas",
                2 or 3 => number.ToString() + " dalių diskas",
                _ => throw new NotImplementedException()
            };
        }

        public string FromPegNumberInWords(int number)
        {
            return number switch
            {
                1 => "pirmo",
                2 => "antro",
                3 => "trečio",
                _ => throw new NotImplementedException()
            };
        }

        public string ToPegNumberInWords(int number)
        {
            return number switch
            {
                1 => "pirmą",
                2 => "antrą",
                3 => "trečią",
                _ => throw new NotImplementedException()
            };
        }

    }
}
