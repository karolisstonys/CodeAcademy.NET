using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Interfaces;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class Statistics
    {
        public static GameStatisticList ShowStatistics(ITower tower)
        {
            var theGameStatisticList = new GameStatisticList();

            // Gathering games from TXT logs
            var path = FileReader.GetFilePath("TowerOfHanoiLogs.txt");
            string[] allTxtFileLines = File.ReadAllLines(path);
            var listOfUniqueGamesInTxtLogs = GetAllUniqueDateTimesFromTxtFileLines(allTxtFileLines);
            AddUniqueGamesFromLogs(theGameStatisticList, listOfUniqueGamesInTxtLogs);


            // Gathering games from HTML logs
            path = FileReader.GetFilePath("TowerOfHanoiLogs.html");
            List<string> allHtmlFileLines = File.ReadAllLines(path).ToList();
            var listOfUniqueGamesInHtmlLogs = GetAllUniqueDateTimesFromHtmlFileLines(allHtmlFileLines);
            AddUniqueGamesFromLogs(theGameStatisticList, listOfUniqueGamesInHtmlLogs);

            // Gathering games from CSV logs
            path = FileReader.GetFilePath("TowerOfHanoiLogs.csv");
            string[] allCsvFileLines = File.ReadAllLines(path);
            var listOfUniqueGamesInCsvLogs = GetAllUniqueDateTimesFromCsvFileLines(allCsvFileLines);
            AddUniqueGamesFromLogs(theGameStatisticList, listOfUniqueGamesInCsvLogs);

            theGameStatisticList.Sort();

            for (int gameIndex = 0; gameIndex < theGameStatisticList.AllGamesStatistics.Count; gameIndex++)
            {
                string selectedDateTime = theGameStatisticList.AllGamesStatistics[gameIndex].GameDateTime.ToString();
                var selectedGameValidator = theGameStatisticList.AllGamesStatistics[gameIndex].VictoryValidator;

                // Going through log files in order (TXT -> HTML -> CSV) to find specific game
                // Checking if game was won and marking accordingly 
                if (FindGameInLogFileLines.IsDateTimeFound(allTxtFileLines, selectedDateTime))
                {
                    // Extracting specific game DateTime lines from allTxtFileLines
                    var gameLines = new List<string>();
                    foreach (string line in allTxtFileLines)
                    {
                        if (line.Contains(selectedDateTime))
                            gameLines.Add(line);
                    }

                    // For when not all four disks are found (e.g. Disk4 is never moved)
                    theGameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = "N/B";
                    // FOR goes backwards from last line up and looks for last placement of every disk
                    for (int i = gameLines.Count() - 1; i >= 0; i--)
                        ValidateIfGameIsVictorious(theGameStatisticList, gameIndex);
                }
                else if (FindGameInLogFileLines.IsDateTimeFound(allHtmlFileLines, selectedDateTime))
                {
                    // Finds last line of specific selectedDateTime from allHtmlFileLines by going from last line to the top
                    var singleGameLines = new List<string>();                    
                    for (int i = allHtmlFileLines.Count() - 1; i >= 0; i--)
                    {
                        if (allHtmlFileLines[i].Contains(selectedDateTime))
                        {
                            // When it's found another FOR goes and takes JUST 5 lines with all the data from that last record
                            for (int j = i; j <= i + 5; j++)
                            {
                                singleGameLines.Add(allHtmlFileLines[j]);
                            }
                            break;
                        }
                    }

                    if (singleGameLines != null && selectedGameValidator.IsAllDisksLastMovesFoundInHtmlLog(singleGameLines))
                        ValidateIfGameIsVictorious(theGameStatisticList, gameIndex);
                }
                else //if (allCsvFileLines.Contains(gameDateTime))
                {
                    // Extracting only selectedDateTime lines from allCsvFileLines
                    var gameLines = new List<string>();
                    foreach (string line in allCsvFileLines)
                    {
                        if (line.Contains(selectedDateTime))
                            gameLines.Add(line);
                    }

                    // Checks if last disk position of Csv log file is victory position 
                    if (gameLines != null && selectedGameValidator.IsAllDisksLastMovesFoundInCsvLog(gameLines[gameLines.Count - 1]))
                        ValidateIfGameIsVictorious(theGameStatisticList, gameIndex);
                }
            }
            return theGameStatisticList;
        }

        // Public for tests only
        public static List<DateTime> GetAllUniqueDateTimesFromTxtFileLines(string[] fileLines)
        {
            var list = new List<DateTime>();

            foreach (var line in fileLines)
            {
                DateTime dateTime = Convert.ToDateTime(line.Substring(23, 19));

                if (!list.Contains(dateTime))
                {
                    list.Add(dateTime);
                }
            }
            return list;
        }

        // Public for tests only
        public static List<DateTime> GetAllUniqueDateTimesFromHtmlFileLines(List<string> fileLines)
        {
            // Making a copy to leave original reffered type object untouched
            // Removing all not needed 9 lines if header
            var copyOfFileLines = fileLines.GetRange(9, fileLines.Count() - 9);         
            var list = new List<DateTime>();

            while (copyOfFileLines.Count >= 8)
            {
                DateTime dateTime = Convert.ToDateTime(copyOfFileLines[0].Substring(4, 19));

                if (!list.Contains(dateTime))
                {
                    list.Add(dateTime);
                }

                copyOfFileLines.RemoveRange(0, 8);
            }
            return list;
        }

        // Public for tests only
        public static List<DateTime> GetAllUniqueDateTimesFromCsvFileLines(string[] fileLines)
        {
            var list = new List<DateTime>();

            foreach (var line in fileLines)
            {
                DateTime dateTime = Convert.ToDateTime(line.Substring(0, 19));

                if (!list.Contains(dateTime))
                {
                    list.Add(dateTime);
                }
            }
            return list;
        }

        private static void AddUniqueGamesFromLogs(GameStatisticList gameStatisticList, List<DateTime> listOfUniqueGamesInLogs)
        {
            foreach (var gameDateTime in listOfUniqueGamesInLogs)
            {
                if (!gameStatisticList.IsGameExistingWithThisDate(gameDateTime))
                {
                    gameStatisticList.Add(new GameStatistic() { GameDateTime = gameDateTime, MovesUntilVictory = "", VictoryStatus = false });
                }
            }
        }

        private static void ValidateIfGameIsVictorious(GameStatisticList gameStatisticList, int gameIndex)
        {
            var game = gameStatisticList.AllGamesStatistics[gameIndex];

            if (game.VictoryValidator.IsGameWon())
            {
                game.VictoryStatus = true;
                game.MovesUntilVictory = game.VictoryValidator.MovesUntilVictory;
            }
            else
                game.MovesUntilVictory = "N/B";
        }





























    }
}











/*
                using StreamReader sr = new StreamReader(path);

                string fileLine;
                int moveCounter = 1;
                string stringDateTime = "";
                string curentDateTimeFormLog = ""; 

                while ((fileLine = sr.ReadLine()) != null)
                {
                    moveCounter++;
                    // Getting DateTime string from TXT log file current line
                    fileLine = fileLine.Remove(0, 23);
                    curentDateTimeFormLog = fileLine.Substring(0, 19);

                    // Updates all moveCounter of currently recorded game when new DateTime is found in new line of StreamReader
                    if (stringDateTime != curentDateTimeFormLog) // || PASKUTINE StreamReader EILUTE 
                    {
                if (stringDateTime != "") allStatistics[Convert.ToDateTime(stringDateTime)] = new string[] { moveCounter.ToString(), "-" };
                stringDateTime = curentDateTimeFormLog;
            }

            // Looking for DateTime from TXT log file in allStatistics dictionary (Key)
            var stringDateTimeExistsInStatisctics = false;
            foreach (var game in allStatistics)
            {
                if (game.Key == Convert.ToDateTime(stringDateTime))
                    stringDateTimeExistsInStatisctics = true;
            }

            // If stringDateTime from TXT log file not found in allStatistics dictionary - it is added
            if (!stringDateTimeExistsInStatisctics)
            {
                allStatistics.Add(Convert.ToDateTime(stringDateTime), new string[] { "?", "?" });
                moveCounter = 1;
            }
        }
                // Processes last line of StreamReader if it exists at all
                if (stringDateTime != "" && allStatistics[Convert.ToDateTime(stringDateTime)] != null)
                allStatistics[Convert.ToDateTime(stringDateTime)] = new string[] { moveCounter.ToString(), "?" };
            */