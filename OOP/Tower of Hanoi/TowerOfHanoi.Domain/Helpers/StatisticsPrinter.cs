using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class StatisticsPrinter
    {
        public static List<string> BuildAllStatistics(GameStatisticList allStatistics)
        {
            var list = new List<string>();
            list.Add("╔═════════════════════╤════════════════════════════╤═════════╗");  // ─ ┼ │ ╟ ╚ ╧ ╝ ╢
            list.Add("║ Žaidimo data\t      │ Ėjimų kiekis iki laimėjimo │ Pokytis ║  ");
            list.Add("╠═════════════════════╪════════════════════════════╪═════════╣");

            for (int i = 0; i < allStatistics.AllGamesStatistics.Count; i++)
            {
                var line = "";
                var change = "N/G";

                if (i > 0 && Int32.TryParse(allStatistics.AllGamesStatistics[i-1].MovesUntilVictory, out int change1))
                {
                    var IsChange2Int = Int32.TryParse(allStatistics.AllGamesStatistics[i].MovesUntilVictory, out int change2);
                    change = (change2 - change1).ToString();
                }

                line = $"║ {allStatistics.AllGamesStatistics[i].GameDateTime} │ {allStatistics.AllGamesStatistics[i].MovesUntilVictory}\t\t\t   │ {change,-8}║";
                list.Add(line);
            }

            list.Add("╚═════════════════════╧════════════════════════════╧═════════╝");
            return list;
        }
    }
}
