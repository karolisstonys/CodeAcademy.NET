using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class Converter
    {
        //public static string DiskNumberToWords(int number)
        //{
        //    return number switch
        //    {
        //        1 => "1 dalies diskas",
        //        2 or 3 => number.ToString() + " dalių diskas",
        //        _ => throw new NotImplementedException()
        //    };
        //}

        public static string FromPegNumberConvertToWord(int number)
        {
            return number switch
            {
                1 => "pirmo",
                2 => "antro",
                3 => "trečio",
                _ => throw new NotImplementedException()
            };
        }

        public static string ToPegNumberConvertToWord(int number)
        {
            return number switch
            {
                1 => "pirmą",
                2 => "antrą",
                3 => "trečią",
                _ => throw new NotImplementedException()
            };
        }

        public static int ToPegWordConvertToNumber(string word)
        {
            return word switch
            {
                "pirmą" => 1,
                "antrą" => 2,
                "trečią" => 3,
                _ => throw new NotImplementedException()
            };
        }

    }
}
