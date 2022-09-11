using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class Statistics
    {
        public static GameStatisticList ShowStatistics(Tower tower)
        {
            var gameStatisticList = new GameStatisticList();
            //var allStatistics = new Dictionary<DateTime, string[]>();

            string path = "";
            var listDateTime = new List<DateTime>();

            //----------------------------------------------------                              KARTOJASI !!!
            path = FileReader.GetFilePath("TowerOfHanoiLogs.txt");
            string[] allTxtFileLines = File.ReadAllLines(path);
            listDateTime = GetAllUniqueDateTimesFromTxtFileLines(allTxtFileLines);

            foreach (var date in listDateTime)
            {
                if (!gameStatisticList.IsGameExistingWithThisDate(date))
                {
                    gameStatisticList.Add(new GameStatistic() { GameDateTime = date, MovesUntilVictory = "", VictoryStatus = false });
                }
            }

            //----------------------------------------------------                              KARTOJASI !!!
            path = FileReader.GetFilePath("TowerOfHanoiLogs.html");
            List<string> allHtmlFileLines = File.ReadAllLines(path).ToList();
            listDateTime = GetAllUniqueDateTimesFromHtmlFileLines(allHtmlFileLines);

            foreach (var date in listDateTime)
            {
                if (!gameStatisticList.IsGameExistingWithThisDate(date))
                {
                    gameStatisticList.Add(new GameStatistic() { GameDateTime = date, MovesUntilVictory = "", VictoryStatus = false });
                }
            }

            //----------------------------------------------------                              KARTOJASI !!!
            path = FileReader.GetFilePath("TowerOfHanoiLogs.csv");
            string[] allCsvFileLines = File.ReadAllLines(path);
            listDateTime = GetAllUniqueDateTimesFromCsvFileLines(allCsvFileLines);

            foreach (var date in listDateTime)
            {
                if (!gameStatisticList.IsGameExistingWithThisDate(date))
                {
                    gameStatisticList.Add(new GameStatistic() { GameDateTime = date, MovesUntilVictory = "", VictoryStatus = false });
                }
            }

            gameStatisticList.Order();

            for (int i = 0; i < gameStatisticList.AllGamesStatistics.Count; i++)
            {
                string gameDateTime = gameStatisticList.AllGamesStatistics[i].GameDateTime.ToString();

                // Going through log files in order (TXT -> HTML -> CSV) to find specific game
                // Checking if game was won and marking accordingly 
                var victoryValidator = new VictoryValidator();
                if (FindGameInLogFileLines.TxtLog(allTxtFileLines, gameDateTime))
                {
                    // Extracting specific game DateTime lines from allTxtFileLines
                    List<string> gameLines = new List<string>();
                    foreach (string line in allTxtFileLines)
                    {
                        if (line.Contains(gameDateTime))
                            gameLines.Add(line);
                    }

                    for (int j = gameLines.Count() - 1; j >= 0; j--)
                    {
                        if (victoryValidator.IsAllDisksLastMovesFound(gameLines[j]))
                        {
                            if (victoryValidator.IsWon())
                            {
                                gameStatisticList.AllGamesStatistics[i].VictoryStatus = true;
                                gameStatisticList.AllGamesStatistics[i].MovesUntilVictory = MovementCountFinder.FromTxtLine(gameLines[gameLines.Count() - 1]);
                                break;
                            }
                            gameStatisticList.AllGamesStatistics[i].MovesUntilVictory = "N/B";
                            break;
                        }
                        gameStatisticList.AllGamesStatistics[i].MovesUntilVictory = "N/B";
                    }
                }
                else if (allHtmlFileLines.Contains(gameDateTime))
                {

                }
                else //if (allCsvFileLines.Contains(gameDateTime))
                {

                }
            }





            return gameStatisticList;
        }

        internal static List<DateTime> GetAllUniqueDateTimesFromTxtFileLines(string[] fileLines)
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

        internal static List<DateTime> GetAllUniqueDateTimesFromHtmlFileLines(List<string> fileLines)
        {
            var list = new List<DateTime>();

            // Removing all not needed Header
            fileLines.RemoveRange(0, 9);

            while (fileLines.Count >= 8)
            {
                DateTime dateTime = Convert.ToDateTime(fileLines[0].Substring(4, 19));

                if (!list.Contains(dateTime))
                {
                    list.Add(dateTime);
                }

                fileLines.RemoveRange(0, 8);
            }
            return list;
        }

        internal static List<DateTime> GetAllUniqueDateTimesFromCsvFileLines(string[] fileLines)
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