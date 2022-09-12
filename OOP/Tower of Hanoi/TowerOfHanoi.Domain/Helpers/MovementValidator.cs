using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class MovementValidator
    {
        public static bool IsDiskBelowLarger(int emptyIndex, Peg peg, EDisks? inHand)
        {
            if (emptyIndex == 3) 
                return true;
            bool result = emptyIndex < 3 && inHand.Value < peg.Levels[emptyIndex + 1].Disk;
            return result;
        }
        
    }
}
