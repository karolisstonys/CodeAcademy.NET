using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Models
{
    public class Peg : IPeg
    {
		//public EDisks[] Levels { get; set; } //= new EDisks[4];

		//public Peg()
		//{
		//    Levels = new EDisks[4]{ EDisks.NoDisk, EDisks.NoDisk, EDisks.NoDisk, EDisks.NoDisk };
		//}

		//public Peg(EDisks row1, EDisks row2, EDisks row3, EDisks row4)
		//{
		//    Levels = new EDisks[4] { row1, row2, row3, row4 };
		//}

		public readonly Level[] Levels = new Level[4];

		public Peg()
		{
			Levels[0] = new Level();
			Levels[1] = new Level();
			Levels[2] = new Level();
			Levels[3] = new Level();
		}

		public Peg(Level level1, Level level2, Level level3, Level level4)
		{
			Levels[0] = level1;
			Levels[1] = level2;
			Levels[2] = level3;
			Levels[3] = level4;
		}

		public int GetTopNonEmptyLevelIndex()
		{
			for (int i = 0; i < Levels.Length; i++)
			{
				if (Levels[i].Disk != EDisks.NoDisk) 
					return i;
			}
			return 4;
		}

		public int GetBottomEmptyLevelIndex() => GetTopNonEmptyLevelIndex() - 1;


	}
}
