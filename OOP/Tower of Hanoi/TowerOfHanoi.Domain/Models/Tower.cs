using System.Text;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Models
{
    public class Tower
    {
        public DateTime DateAndTime { get; } = DateTime.Now;

        //public int Disk1Peg { get; set; } = 1;
        //public int Disk2Peg { get; set; } = 1;
        //public int Disk3Peg { get; set; } = 1;
        //public int Disk4Peg { get; set; } = 1;


        public EDisks? InHand { get; set; } = null;

        public StringBuilder BuildTower(Peg peg1, Peg peg2, Peg peg3)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1eil.       |            |            |       ");
            sb.AppendLine($"2eil.   {peg1.Levels[0]}    {peg2.Levels[0]}    {peg3.Levels[0]}   ");
            sb.AppendLine($"3eil.   {peg1.Levels[1]}    {peg2.Levels[1]}    {peg3.Levels[1]}   ");
            sb.AppendLine($"4eil.   {peg1.Levels[2]}    {peg2.Levels[2]}    {peg3.Levels[2]}   ");
            sb.AppendLine($"5eil.   {peg1.Levels[3]}    {peg2.Levels[3]}    {peg3.Levels[3]}   ");
            sb.AppendLine("-----------[1]----------[2]----------[3]------");

            sb.Replace("NoDisk", "    |    ")
               .Replace("Disk1", "   #|#   ")
               .Replace("Disk2", "  ##|##  ")
               .Replace("Disk3", " ###|### ")
               .Replace("Disk4", "####|####");

            return sb;
        }

        public bool Move(Peg peg)
        {
            int i = 0;
            if (InHand == null)                 // take out
            {
                foreach (var level in peg.Levels)
                {
                    if (level != EDisks.NoDisk) 
                    { 
                        InHand = level;
                        peg.Levels[i] = EDisks.NoDisk;
                        return true;
                    }

                    if (level == EDisks.NoDisk && i == 3)
                    {
                        return false;
                    }
                    i++;
                }
            }
            else                                // put in
            {
                foreach (var level in peg.Levels)
                {
                    if (level != EDisks.NoDisk && i <= 3)
                    {
                        if (InHand > level)
                            return false;
                        peg.Levels[i-1] = InHand.Value;
                        InHand = null;
                        return true;
                    }

                    if (level == EDisks.NoDisk && i == 3)
                    {
                        peg.Levels[i] = InHand.Value;
                        InHand = null;
                        return true;
                    }
                    i++;
                }
            }
            return false;
        }

    }
}
