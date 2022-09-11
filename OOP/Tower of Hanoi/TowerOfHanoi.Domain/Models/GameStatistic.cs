using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class GameStatistic
    {
        public DateTime GameDateTime { get; set; }
        public string MovesUntilVictory { get; set; }
        public bool VictoryStatus { get; set; }
    }
}
