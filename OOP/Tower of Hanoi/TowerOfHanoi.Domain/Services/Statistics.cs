using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Services
{
    public class Statistics
    {
        public static Dictionary<DateTime, string[]> ShowStatistics(Tower tower)
        {
            Dictionary<DateTime, string[]> dictionary = new Dictionary<DateTime, string[]>();

            dictionary.Add(Convert.ToDateTime("2022-09-10 17:00"), new string[] { "22", "N/G" });

            //foreach (var zaidejas in zaidejuTaskuZodynas)
            //{
            //    Console.Write(zaidejas.Key + " ");
            //    foreach (var taskai in zaidejas.Value)
            //    {
            //        Console.Write(taskai + " ");
            //    }
            //    Console.WriteLine();
            //}




            if (tower.LogInTxtFile)
            {

            }


            return dictionary;
        }

    }
}
