using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;
using System.IO;
using TowerOfHanoi.Domain.Enums;

namespace TowerOfHanoi.Domain.Services
{
    public class Logger
    {
        public static void Log(Tower tower)
        {
            if (tower.LogInCsvFile) LogInCsvFile(tower);
            if (tower.LogInHtmlFile) LogInHtmlFile(tower);
            //if (tower.LogInTxtFile) LogInTxtFile(tower);
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file

        public static void LogInCsvFile(Tower tower)
        {
            /* CSV KONTRAKTAS
            zaidimo_pradzios_data, ejimo_nr, disko_1_vieta, disko_2_vieta, disko_3_vieta, disko_4_vieta
            PVZ:
            2022-01-01 12:00,1,2,1,1,1
            2022-01-01 12:00,2,2,3,1,1 */

            var startDate = tower.DateAndTime.ToString("yyyy-MM-dd HH:mm");
            var moveCount = tower.MoveCounter.ToString();
            var disk1Position = tower.FindDisk(EDisks.Disk1).ToString();
            var disk2Position = tower.FindDisk(EDisks.Disk2).ToString();
            var disk3Position = tower.FindDisk(EDisks.Disk3).ToString();
            var disk4Position = tower.FindDisk(EDisks.Disk4).ToString();

            string line = startDate + "," + moveCount + "," + disk1Position + "," + disk2Position + "," + disk3Position + "," + disk4Position;
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Logs\\TowerOfHanoiLogs.csv";

            using StreamWriter file = new(path, append: true);
            file.WriteLine(line);


        }

        public static void LogInHtmlFile(Tower tower)
        {
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Logs\\TowerOfHanoiLogs.html";

            var startDate = tower.DateAndTime.ToString("yyyy-MM-dd HH:mm");
            var moveCount = tower.MoveCounter.ToString();
            var disk1Position = tower.FindDisk(EDisks.Disk1).ToString();
            var disk2Position = tower.FindDisk(EDisks.Disk2).ToString();
            var disk3Position = tower.FindDisk(EDisks.Disk3).ToString();
            var disk4Position = tower.FindDisk(EDisks.Disk4).ToString();

            StringBuilder buildHtml = new StringBuilder();

            var fileReader = new FileRead();
            if (fileReader.CheckIfFileIsEmpty("TowerOfHanoiLogs.html"))
            {            
                string tableHeader = @"<table border>
<tr>
<th>ŽAIDIMO PRADŽIOS DATA</th>
<th>ĖJIMO NR</td>
<th>DISKO 1 VIETA</th>
<th>DISKO 2 VIETA</th>
<th>DISKO 3 VIETA</th>
<th>DISKO 4 VIETA</th>
</tr>";
                buildHtml.Append(tableHeader);
            }
            else
            {
                // reikia pasiimti html faila nuskaityti, split per </table> ir pirma index prideti i pradzia (antra kaip ir ismetant), toliau testi su standartiniu buildHTML kodu apacioje
            }


            buildHtml.AppendLine("<tr>");
            buildHtml.AppendLine("<td>" + startDate + "</td>");
            buildHtml.AppendLine("<td>" + moveCount + "</td>");
            buildHtml.AppendLine("<td>" + disk1Position + "</td>");
            buildHtml.AppendLine("<td>" + disk2Position + "</td>");
            buildHtml.AppendLine("<td>" + disk3Position + "</td>");
            buildHtml.AppendLine("<td>" + disk4Position + "</td>");
            buildHtml.AppendLine("</tr>");
            buildHtml.AppendLine("</table>");



            string stringHtml = buildHtml.ToString();





            using StreamWriter file = new(path, append: true);
            file.WriteLine(stringHtml);




        }

        public static void LogInTxtFile(Tower tower)
        {

        }
    }
}
