using TowerOfHanoi.Domain.Models;
using TowerOfHanoi.Domain.Enums;
using System.Text;

namespace TowerOfHanoi.Domain.Services
{
    public class Logger
    {
        public static void Log(Tower tower, int movedToPegNo)
        {
            string[] logData = GetLogData(tower);

            var fileReader = new FileReader();

            if (tower.LogInCsvFile) 
            {
                string path = fileReader.GetFilePath("TowerOfHanoiLogs.csv");
                string line = CreateStringForCsv(logData);
                using StreamWriter file = new(path, append: true);
                file.WriteLine(line);
            }
            if (tower.LogInHtmlFile)
            {
                string path = fileReader.GetFilePath("TowerOfHanoiLogs.html");
                string buildHtml = CreateStringForHtml(logData, fileReader, path);
                using StreamWriter file = new(path, append: false);
                file.WriteLine(buildHtml);
            }
            if (tower.LogInTxtFile)
            {
                string path = fileReader.GetFilePath("TowerOfHanoiLogs.txt");
                string line = CreateStringForTxt(logData, tower.InHand.ToString(), tower.DiskInHandFromPeg, movedToPegNo);
                using StreamWriter file = new(path, append: true);
                file.WriteLine(line);
            }
        }

        public static string[] GetLogData(Tower tower)
        {
            var startDate = tower.DateAndTime.ToString("yyyy-MM-dd HH:mm:ss");
            var moveCount = tower.MoveCounter.ToString();
            var disk1Position = tower.FindDisk(EDisks.Disk1).ToString();
            var disk2Position = tower.FindDisk(EDisks.Disk2).ToString();
            var disk3Position = tower.FindDisk(EDisks.Disk3).ToString();
            var disk4Position = tower.FindDisk(EDisks.Disk4).ToString();
            return new string[] { startDate, moveCount, disk1Position, disk2Position, disk3Position, disk4Position };
        }

        public static string CreateStringForCsv(string[] logData)
        {         
            return logData[0] + "," + logData[1] + "," + logData[2] + "," + logData[3] + "," + logData[4] + "," + logData[5];
        }

        public static string CreateStringForHtml(string[] logData, FileReader fileReader, string path)
        {
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

            return buildHtml.ToString();
        }

        public static string CreateStringForTxt(string[] logData, string inHand, int movedFromPegNo, int movedToPegNo)
        {
            var converter = new Converter();
            string line = $"žaidime kuris pradėtas {logData[0]}, ";
            line += $"ėjimu nr {logData[1]}, ";
            line += $"{inHand.Substring(4,1)} dalių diskas ";
            line += $"buvo paimtas iš {converter.FromPegNumberInWords(movedFromPegNo)} sulpelio ";
            line += $"ir padėtas į {converter.ToPegNumberInWords(movedToPegNo)}";
            return line;
        }
    }
}
