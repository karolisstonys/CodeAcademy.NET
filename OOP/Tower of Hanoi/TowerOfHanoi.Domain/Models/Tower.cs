using System.Text;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Models
{
    public class Tower
    {
        public DateTime DateAndTime { get; } = DateTime.Now;
        public int Disk1Peg { get; set; } = 1;
        public int Disk2Peg { get; set; } = 1;
        public int Disk3Peg { get; set; } = 1;
        public int Disk4Peg { get; set; } = 1;

        public EDisks[] Peg1 { get; set; } = { EDisks.Disk1, EDisks.Disk2, EDisks.Disk3, EDisks.Disk4 };
        public EDisks[] Peg2 { get; set; } = { EDisks.Empty, EDisks.Empty, EDisks.Empty, EDisks.Empty };
        public EDisks[] Peg3 { get; set; } = { EDisks.Empty, EDisks.Empty, EDisks.Empty, EDisks.Empty };

        public EDisks? InHand { get; set; } = null;

        public StringBuilder BuildTower()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1eil.       |            |            |       ");
            sb.AppendLine($"2eil.   {Peg1[0]}    {Peg2[0]}    {Peg3[0]}   ");
            sb.AppendLine($"3eil.   {Peg1[1]}    {Peg2[1]}    {Peg3[1]}   ");
            sb.AppendLine($"4eil.   {Peg1[2]}    {Peg2[2]}    {Peg3[2]}   ");
            sb.AppendLine($"5eil.   {Peg1[3]}    {Peg2[3]}    {Peg3[3]}   ");
            sb.AppendLine("-----------[1]----------[2]----------[3]------");
            
            return sb;
        }

        public void Move(EDisks[] peg, int num)
        {
            int i = 0;
            if (InHand == null)                 // take out
            {
                foreach (var s in peg)
                {
                    if (s != null) 
                    { 
                        InHand = s;
                        peg[i] = EDisks.Empty;
                        break;
                    }
                    i++;
                }
            }
            else                                // put in
            {
                foreach (var s in peg)
                {
                    if (s != EDisks.Empty && i < 4)
                    {
                        peg[i-1] = InHand.Value;
                        InHand = null;
                        break;
                    }
                    i++;
                }
            }
        }

    }
}
