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
            list.Add("║ Žaidimo data\t      │ Ėjimų kiekis iki laimėjimo │ Pokytis ║");
            list.Add("╠═════════════════════╪════════════════════════════╪═════════╣");

            for (int i = 0; i < allStatistics.AllGamesStatistics.Count; i++)
            {




                var change = "N/G";
                int change1 = 0;
                int j = i;


                if (allStatistics.AllGamesStatistics[i].VictoryStatus)
                {
                    while (i > 0 && !allStatistics.AllGamesStatistics[j-1].VictoryStatus)
                    {
                        j--;
                        if (j < 1) break;
                    }
                    if (j > 1)
                        change1 = Int32.Parse(allStatistics.AllGamesStatistics[j-1].MovesUntilVictory);


                    if (Int32.TryParse(allStatistics.AllGamesStatistics[i].MovesUntilVictory, out int change2))
                    {
                        string positive = "";
                        if (change2 > change1)
                            positive = "+";
                        change = positive + (change2 - change1).ToString();
                    }
                }


                var line = $"║ {allStatistics.AllGamesStatistics[i].GameDateTime} │ {allStatistics.AllGamesStatistics[i].MovesUntilVictory}\t\t\t   │ {change,-8}║";
                list.Add(line);
            }

            list.Add("╚═════════════════════╧════════════════════════════╧═════════╝");
            return list;
        }
    }
}
