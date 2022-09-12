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

            // Find all disk positions in current tower
            var disk1Position = tower.FindDisk(EDisks.Disk1).ToString();
            var disk2Position = tower.FindDisk(EDisks.Disk2).ToString();
            var disk3Position = tower.FindDisk(EDisks.Disk3).ToString();
            var disk4Position = tower.FindDisk(EDisks.Disk4).ToString();

            // If disks are in starting position
            if (AreDisksInStartingPosition(disk1Position, disk2Position, disk3Position, disk4Position)) return "paimkite diską iš pirmo stulpelio padėkite į antrą";
            
            // Get all previous games statistics and sort it by MovesUntilVictory
            var allStatistics = Statistics.ShowStatistics(tower);
            allStatistics.SortByMovesUntilVictory();


            // CSV -----------------------------------------------------------------------------------
            // Build CSV search term
            string CsvSearchTerm = $"{disk1Position},{disk2Position},{disk3Position},{disk4Position}";
            string[] allCsvFileLines = FileReader.GetAllCsvFileLines();

            string helpInCsv = LookForHelpInCsv(CsvSearchTerm, allCsvFileLines, allStatistics);            
            if (helpInCsv != "") return helpInCsv;


            // HTML ----------------------------------------------------------------------------------
            //string helpInHtml = LookForHelpInHtml(HtmlSearchTerm, allHtmlFileLines, allStatistics);
            //if (helpInHtml != "") return helpInHtml;


            // TXT -----------------------------------------------------------------------------------
            //string helpInTxt = LookForHelpInTxt(TxtSearchTerm, allTxtFileLines, allStatistics);
            //if (helpInTxt != "") return helpInTxt;


            return help;
        }

        private static bool AreDisksInStartingPosition(string disk1Position, string disk2Position, string disk3Position, string disk4Position) =>
            disk1Position == "1" && 
            disk2Position == "1" && 
            disk3Position == "1" && 
            disk4Position == "1";

        // Public for tests only
        public static string LookForHelpInCsv(string csvSearchTerm, string[] allCsvFileLines, GameStatisticList allStatistics)
        {
            string help = "";
            List<string> foundPossibleHelpList = new List<string>();
            string foundHelpLine = "";

            // Find all possible helper moves from allCsvFileLines
            for (int i = 0; i < allCsvFileLines.Length; i++)
            {
                if (allCsvFileLines[i].Contains(csvSearchTerm))
                    foundPossibleHelpList.Add(allCsvFileLines[i]);
            }

            for (int i = 0; i < allStatistics.AllGamesStatistics.Count; i++)
            {
                if (IsHelpFound(foundHelpLine)) break;
                for (int j = 0; j < foundPossibleHelpList.Count; j++)
                {
                    var dateFrompossibleHelpList = Convert.ToDateTime(foundPossibleHelpList[j].Substring(0, 19));
                    if (allStatistics.AllGamesStatistics[i].GameDateTime == dateFrompossibleHelpList)
                    {
                        foundHelpLine = foundPossibleHelpList[j];
                    }
                }
            }

            if (IsHelpFound(foundHelpLine))
            {
                var helpIndexInAllCsvFileLines = FindHelpIndex(foundHelpLine, allCsvFileLines);
                help = GiveHelpInWords(allCsvFileLines, helpIndexInAllCsvFileLines);
            }

            return help;
        }

        private static bool IsHelpFound(string foundHelp) => foundHelp != "";
        
        private static int FindHelpIndex(string foundHelpLine, string[] allCsvFileLines)
        {
            int helpIndex = 0;
            for (int i = 0; i < allCsvFileLines.Length; i++)
            {
                if (allCsvFileLines[i] == foundHelpLine)
                    helpIndex = i;
            }
            return helpIndex; 
        }
        
        private static string GiveHelpInWords(string[] allCsvFileLines, int helpIndexInAllCsvFileLines)
        {
            string helpInWords = "";

            string moveFrom = allCsvFileLines[helpIndexInAllCsvFileLines];
            moveFrom = moveFrom.Substring(moveFrom.Length -7, 7);

            string moveTo = allCsvFileLines[helpIndexInAllCsvFileLines + 1];
            moveTo = moveTo.Substring(moveTo.Length -7, 7);

            int pegMoveFrom = 0;
            int pegMoveTo = 0;

            for (int i = 0; i <= 6; i+=2)
            {
                pegMoveFrom = Convert.ToInt32(moveFrom.Substring(i, 1));
                pegMoveTo = Convert.ToInt32(moveTo.Substring(i, 1));
                if (IsMovement(pegMoveFrom, pegMoveTo)) break;
            }

            // "paimkite diską iš pirmo stulpelio padėkite į antrą"

            helpInWords = "paimkite diską iš " + Converter.FromPegNumberConvertToWord(pegMoveFrom) + " stulpelio padėkite į " + Converter.ToPegNumberConvertToWord(pegMoveTo);

            return helpInWords;
        }

        private static bool IsMovement(int pegMoveFrom, int pegMoveTo) => pegMoveFrom != pegMoveTo;





    }
}
