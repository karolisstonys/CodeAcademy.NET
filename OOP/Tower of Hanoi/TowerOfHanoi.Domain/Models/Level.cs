using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Models
{
	public class Level : ILevel
    {
        public EDisks Disk { get; set; }

		public Level()
		{
			Disk = EDisks.NoDisk;
		}

		public Level(EDisks disk)
		{
			Disk = disk;
		}
	}
}
