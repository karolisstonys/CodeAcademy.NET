using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Enums;
using System.Text;

namespace TowerOfHanoi.Domain.Services
{
    public class Logger
    {
        public static void Log(Tower tower, int movedToPegNo)
        {
            string[] logData = new string[6];
            logData = GetLogData(tower);

            if (tower.LogInCsvFile) LogInCsvFile(logData);
            if (tower.LogInHtmlFile) LogInHtmlFile(logData);
            if (tower.LogInTxtFile) LogInTxtFile(logData, tower.InHand.ToString(), tower.DiskInHandFromPeg, movedToPegNo);
        }

        private static string[] GetLogData(Tower tower)
        {
            var startDate = tower.DateAndTime.ToString("yyyy-MM-dd HH:mm:ss");
            var moveCount = tower.MoveCounter.ToString();
            var disk1Position = tower.FindDisk(EDisks.Disk1).ToString();
            var disk2Position = tower.FindDisk(EDisks.Disk2).ToString();
            var disk3Position = tower.FindDisk(EDisks.Disk3).ToString();
            var disk4Position = tower.FindDisk(EDisks.Disk4).ToString();
            return new string[] { startDate, moveCount, disk1Position, disk2Position, disk3Position, disk4Position };
        }

        public static void LogInCsvFile(string[] logData)
        {
            var fileReader = new FileReader();
            string path = fileReader.GetFilePath("TowerOfHanoiLogs.csv");

            string line = logData[0] + "," + logData[1] + "," + logData[2] + "," + logData[3] + "," + logData[4] + "," + logData[5];
            using StreamWriter file = new(path, append: true);
            file.WriteLine(line);
        }

        public static void LogInHtmlFile(string[] logData)
        {
            var fileReader = new FileReader();
            string path = fileReader.GetFilePath("TowerOfHanoiLogs.html");
            StringBuilder buildHtml = new StringBuilder();

            if (fileReader.CheckIfFileIsEmpty("TowerOfHanoiLogs.html"))
            {            
                string tableHeader = "<table border>\n<tr>\n<th>ŽAIDIMO PRADŽIOS DATA</th>\n<th>ĖJIMO NR</td>\n<th>DISKO 1 VIETA</th>\n<th>DISKO 2 VIETA</th>\n<th>DISKO 3 VIETA</th>\n<th>DISKO 4 VIETA</th>\n</tr>";
                buildHtml.Append(tableHeader);
            }
            else
            {
                string oldHtmlFile = File.ReadAllText(path);
                string[] oldHtmlText = oldHtmlFile.Split("</table>");
                buildHtml.Append(oldHtmlText[0]);
            }

            buildHtml.AppendLine("<tr>");
            buildHtml.AppendLine("<td>" + logData[0] + "</td>");
            buildHtml.AppendLine("<td>" + logData[1] + "</td>");
            buildHtml.AppendLine("<td>" + logData[2] + "</td>");
            buildHtml.AppendLine("<td>" + logData[3] + "</td>");
            buildHtml.AppendLine("<td>" + logData[4] + "</td>");
            buildHtml.AppendLine("<td>" + logData[5] + "</td>");
            buildHtml.AppendLine("</tr>");
            buildHtml.AppendLine("</table>");

            using StreamWriter file = new(path, append: false);
            file.WriteLine(buildHtml.ToString());
        }

        public static void LogInTxtFile(string[] logData, string inHand, int movedFromPegNo, int movedToPegNo)
        {
            var fileReader = new FileReader();
            string path = fileReader.GetFilePath("TowerOfHanoiLogs.txt");

            // "žaidime kuris pradėtas {zaidimo_pradzios_data}, ėjimu nr {ejimo_nr} {disko_dydis} dalių diskas buvo paimtas iš {is_stulpelio_nr_zodziu} sulpelio ir padėtas į {i_stulpelio_nr_zodziu}"

            var converter = new Converter();
            string line = $"žaidime kuris pradėtas {logData[0]}, ";
            line += $"ėjimu nr {logData[1]}, ";
            line += $"{inHand} dalių diskas ";
            line += $"buvo paimtas iš {converter.FromPegNumberInWords(movedFromPegNo)} sulpelio ";
            line += $"ir padėtas į {converter.ToPegNumberInWords(movedToPegNo)}";

            using StreamWriter file = new(path, append: true);
            file.WriteLine(line);
        }
    }
}
