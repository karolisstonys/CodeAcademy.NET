using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Helpers
{
    public class FindGameInLogFileLines
    {
        public static bool TxtLog(string[] allTxtFileLines, string gameDateTime)
        {
            foreach (var line in allTxtFileLines)
            {
                if (line.Contains(gameDateTime))
                    return true;
            } 
            return false;
        }
    }
}
