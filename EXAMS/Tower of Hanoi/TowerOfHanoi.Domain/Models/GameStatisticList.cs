using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class GameStatisticList
    {
        public GameStatisticList()
        {
            AllGamesStatistics = new List<GameStatistic>();
        }
        public List<GameStatistic> AllGamesStatistics { get; set; }

        public bool IsGameExistingWithThisDate(DateTime date)
        {
            foreach (var statistic in AllGamesStatistics)
            {
                if (statistic.GameDateTime == date) return true;
            }             
            return false;
        }

        public void Add(GameStatistic gameStatistic)
        {
            AllGamesStatistics.Add(gameStatistic);
        }

        public void Sort() => AllGamesStatistics.Sort((a, b) => a.GameDateTime.CompareTo(b.GameDateTime));

        public void SortByMovesUntilVictory() => AllGamesStatistics.Sort((a, b) => a.MovesUntilVictory.CompareTo(b.MovesUntilVictory));

    }
}
