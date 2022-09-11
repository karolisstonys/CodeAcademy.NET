using System.Text;
using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Helpers;

namespace TowerOfHanoi.Domain.Models
{
    public class Tower : ITower
    {
        public Tower() : this(true, true, true) { }

        public Tower(bool logToCSV, bool logToHTML, bool logToTXT)
        {
            var level1 = new Level(EDisks.Disk1);
            var level2 = new Level(EDisks.Disk2);
            var level3 = new Level(EDisks.Disk3);
            var level4 = new Level(EDisks.Disk4);

            Pegs[0] = new Peg(level1, level2, level3, level4);
            Pegs[1] = new Peg();
            Pegs[2] = new Peg();

            LogInCsvFile = logToCSV;
            LogInHtmlFile = logToHTML;
            LogInTxtFile = logToTXT;
        }
        //public Tower(Peg peg1, Peg peg2, Peg peg3)
        //{
        //    Pegs[0] = peg1;
        //    Pegs[1] = peg2;
        //    Pegs[2] = peg3;
        //}

        public DateTime DateAndTime { get; } = DateTime.Now;

        public int MoveCounter { get; set; } = 0;

        public bool LogInCsvFile { get; set; }

        public bool LogInHtmlFile { get; set; }

        public bool LogInTxtFile { get; set; }

        public EDisks? InHand { get; set; } = null;
        public int DiskInHandFromPeg { get; set; }

        public Peg[] Pegs { get; set; } = new Peg[3];



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

        public bool Move(Peg peg, int pegNo)
        {
            if (InHand == null)     // pick up
            {
                int diskIndex = peg.GetTopNonEmptyLevelIndex();
                if (diskIndex > 3) return false;     // out of bounds - nothing valid to pick up

                InHand = peg.Levels[diskIndex].Disk;
                peg.Levels[diskIndex].Disk = EDisks.NoDisk;
                DiskInHandFromPeg = pegNo;
            }
            else        // put down
            {
                int emptyIndex = peg.GetBottomEmptyLevelIndex();
                if (!MovementValidator.IsDiskBelowLarger(emptyIndex, peg, InHand)) return false;   // cannot put larger disk on smaller disk

                peg.Levels[emptyIndex].Disk = InHand.Value;
                MoveCounter++;
                Logger.Log(this, pegNo);
                InHand = null;
            }
            return true;
        }

        public int FindDisk(EDisks disk)
        {
            int pegNo = 0;
            foreach (var peg in this.Pegs)
            {
                pegNo++;
                foreach (var level in peg.Levels)
                {
                    if (level.Disk == disk) return pegNo;
                }
            }
            return pegNo;
        }



    }
}
