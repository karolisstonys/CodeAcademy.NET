using System.Text;
using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Interfaces
{
	public interface ITower
	{
        public DateTime DateAndTime { get; }

        public int MoveCounter { get; set; }

        public bool LogInCsvFile { get; set; }

        public bool LogInHtmlFile { get; set; }

        public bool LogInTxtFile { get; set; }

        public EDisks? InHand { get; set; }
        public int DiskInHandFromPeg { get; set; }

        public Peg[] Pegs { get; set; }

        public StringBuilder StringBuildTower(Peg peg1, Peg peg2, Peg peg3);

		public bool Move(Peg Peg, int pegNo);

		public int FindDisk(EDisks disk);
	}
}
