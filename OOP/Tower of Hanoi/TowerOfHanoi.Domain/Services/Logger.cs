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
            //if (tower.LogInHtmlFile) LogInHtmlFile(tower);
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
            var disk1Position = tower.FindDisk(EDisks.Disk1);
            var disk2Position = tower.FindDisk(EDisks.Disk2);
            var disk3Position = tower.FindDisk(EDisks.Disk3);
            var disk4Position = tower.FindDisk(EDisks.Disk4);

            string line = startDate + "," + moveCount + "," + disk1Position + "," + disk2Position + "," + disk3Position + "," + disk4Position;
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Logs\\TowerOfHanoiLogs.csv";

            using StreamWriter file = new(path, append: true);
            file.WriteLine(line);


        }

        public static void LogInHtmlFile(Tower tower)
        {

        }

        public static void LogInTxtFile(Tower tower)
        {

        }
    }
}
