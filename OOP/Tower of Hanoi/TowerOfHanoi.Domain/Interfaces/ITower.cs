
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Interfaces
{
	public interface ITower
	{
		public bool Move(Peg Peg);
	}
}
