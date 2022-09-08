using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers
{
    public class MovementValidator
    {
        public static bool IsDiskBelowLarger(int emptyIndex, Peg peg) => emptyIndex < 3 && peg.Levels[emptyIndex].Disk < peg.Levels[emptyIndex + 1].Disk;
        
    }
}
