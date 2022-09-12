using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class FindGameInLogFileLines
    {
        public static bool IsDateTimeFound(IEnumerable<string> allFileLines, string gameDateTime)
        {
            foreach (var line in allFileLines)
            {
                if (line.Contains(gameDateTime))
                    return true;
            }
            return false;
        }
        
    }
}
