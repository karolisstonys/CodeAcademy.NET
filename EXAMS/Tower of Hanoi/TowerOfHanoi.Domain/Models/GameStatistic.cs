
using TowerOfHanoi.Domain.Helpers;

namespace TowerOfHanoi.Domain.Models
{
    public class GameStatistic
    {
        public DateTime GameDateTime { get; set; }

        public string MovesUntilVictory { get; set; }

        public bool VictoryStatus { get; set; }

        public VictoryValidator VictoryValidator { get; set; } = new VictoryValidator();
    }
}
