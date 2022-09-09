using System.Text;
using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Helpers;

namespace TowerOfHanoi.Domain.Models
{
    public class Tower : ITower
    {
        public DateTime DateAndTime { get; } = DateTime.Now;

        //public int Disk1Peg { get; set; } = 1;
        //public int Disk2Peg { get; set; } = 1;
        //public int Disk3Peg { get; set; } = 1;
        //public int Disk4Peg { get; set; } = 1;


        public EDisks? InHand { get; set; } = null;


        public Peg[] Pegs { get; set; } = new Peg[3];


        public Tower(Peg peg1, Peg peg2, Peg peg3)
        {
            Pegs[0] = peg1;
            Pegs[1] = peg2;
            Pegs[2] = peg3;
        }


        public StringBuilder StringBuildTower(Peg peg1, Peg peg2, Peg peg3)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1eil.       |            |            |       ");
            sb.AppendLine($"2eil.   {peg1.Levels[0].Disk}    {peg2.Levels[0].Disk}    {peg3.Levels[0].Disk}   ");
            sb.AppendLine($"3eil.   {peg1.Levels[1].Disk}    {peg2.Levels[1].Disk}    {peg3.Levels[1].Disk}   ");
            sb.AppendLine($"4eil.   {peg1.Levels[2].Disk}    {peg2.Levels[2].Disk}    {peg3.Levels[2].Disk}   ");
            sb.AppendLine($"5eil.   {peg1.Levels[3].Disk}    {peg2.Levels[3].Disk}    {peg3.Levels[3].Disk}   ");
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
            if (InHand == null)     // pick up
            {
                int diskIndex = peg.GetTopNonEmptyLevelIndex();
                if (diskIndex > 3) return false;     // out of bounds - nothing valid to pick up

                InHand = peg.Levels[diskIndex].Disk;
                peg.Levels[diskIndex].Disk = EDisks.NoDisk;
            }
            else        // put down
            {
                int emptyIndex = peg.GetBottomEmptyLevelIndex();
                if (!MovementValidator.IsDiskBelowLarger(emptyIndex, peg, InHand)) return false;   // cannot put larger disk on smaller disk

                peg.Levels[emptyIndex].Disk = InHand.Value;
                InHand = null;
            }
            return true;
        }



    }
}
