using TowerOfHanoi.Domain.Enums;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class PlayerHelper
    {
        public static string GiveNextBestMove(ITower tower)
        {
            string help = "PAGALBA NEGALIMA";
            List<string> foundPossibleHelpList = new List<string>();
            string foundHelp = "";
            int foundHelpIndex = 0;

            // Find all disk positions in current tower
            var disk1Position = tower.FindDisk(EDisks.Disk1).ToString();
            var disk2Position = tower.FindDisk(EDisks.Disk2).ToString();
            var disk3Position = tower.FindDisk(EDisks.Disk3).ToString();
            var disk4Position = tower.FindDisk(EDisks.Disk4).ToString();

            // "paimkite diską iš ...... stulpelio padėkite į ......."
            if (AreDisksInStartingPosition(disk1Position, disk2Position, disk3Position, disk4Position)) return "paimkite diską iš pirmo stulpelio padėkite į antrą";
            // Get all previous games statistics and sort it by MovesUntilVictory
            var allStatistics = Statistics.ShowStatistics(tower);
            allStatistics.SortByMovesUntilVictory();

            //PRIORITETAS: CSV → HTML → TXT

            // Build CSV search term
            string CsvSearchTerm = $"{disk1Position},{disk2Position},{disk3Position},{disk4Position}";
            string[] allCsvFileLines = FileReader.GetAllCsvFileLines();

            // Find all possible helper moves from allCsvFileLines
            for (int i = 0; i < allCsvFileLines.Length; i++)
            {
                if (allCsvFileLines[i].Contains(CsvSearchTerm))
                    foundPossibleHelpList.Add(allCsvFileLines[i]);
            }

            for (int i = 0; i < allStatistics.AllGamesStatistics.Count; i++)
            {
                if (IsHelpFound(foundHelp)) break;
                for (int j = 0; j < foundPossibleHelpList.Count; j++)
                {
                    var dateFrompossibleHelpList = Convert.ToDateTime(foundPossibleHelpList[j].Substring(0, 19));
                    if (allStatistics.AllGamesStatistics[i].GameDateTime == dateFrompossibleHelpList)
                    {
                        foundHelp = foundPossibleHelpList[j];
                    }
                }
            }

            if (IsHelpFound(foundHelp))
            {
                int helpIndexInAllCsvFileLines = FindHelpIndex(foundHelp, allCsvFileLines);
                string temp = GiveHelpInWords(allCsvFileLines, helpIndexInAllCsvFileLines);
            }


            List<string> allHtmlFileLines = FileReader.GetAllHtmlFileLines();
            string[] allTxtFileLines = FileReader.GetAllTxtFileLines();




            return help;
        }

        private static string GiveHelpInWords(string[] allCsvFileLines, int helpIndexInAllCsvFileLines)
        {
            string helpInWords = "";

            string moveFrom = allCsvFileLines[helpIndexInAllCsvFileLines];
            moveFrom = moveFrom.Substring(moveFrom.Length -7, 7);
            string moveTo = allCsvFileLines[helpIndexInAllCsvFileLines + 1];
            moveTo = moveTo.Substring(moveTo.Length -7, 7);

            var disk1a = moveFrom.Substring(0, 1);
            var disk2a = moveFrom.Substring(2, 1);
            var disk3a = moveFrom.Substring(4, 1);
            var disk4a = moveFrom.Substring(6, 1);

            var disk1b = moveTo.Substring(0, 1);
            var disk2b = moveTo.Substring(2, 1);
            var disk3b = moveTo.Substring(4, 1);
            var disk4b = moveTo.Substring(5, 1);






            return helpInWords;
        }

        private static int FindHelpIndex(string foundHelp, string[] allCsvFileLines)
        {
            int helpIndex = 0;
            for (int i = 0; i < allCsvFileLines.Length; i++)
            {
                if (allCsvFileLines[i] == foundHelp)
                    helpIndex = i;
            }
            return helpIndex; 
        }

        private static bool IsHelpFound(string foundHelp) => foundHelp != "";

        private static bool AreDisksInStartingPosition(string disk1Position, string disk2Position, string disk3Position, string disk4Position) =>
            disk1Position == "1" && 
            disk2Position == "1" && 
            disk3Position == "1" && 
            disk4Position == "1";
    }
}
