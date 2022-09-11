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


            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            var path = FileReader.GetFilePath("TowerOfHanoiLogs.txt");
            string[] allTxtFileLines = File.ReadAllLines(path);
            var listDateTime = GetAllUniqueDateTimesFromTxtFileLines(allTxtFileLines);

            foreach (var date in listDateTime)
            {
                if (!gameStatisticList.IsGameExistingWithThisDate(date))
                {
                    gameStatisticList.Add(new GameStatistic() { GameDateTime = date, MovesUntilVictory = "", VictoryStatus = false });
                }
            }

            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
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

            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
            //----------------------------------------------------                              KARTOJASI !!! + (UNIT-TEST)
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




            gameStatisticList.Order();  // ======================================================================================== NEVEIKI ORDER !!!








            for (int gameIndex = 0; gameIndex < gameStatisticList.AllGamesStatistics.Count; gameIndex++)
            {
                string selectedDateTime = gameStatisticList.AllGamesStatistics[gameIndex].GameDateTime.ToString();

                // Going through log files in order (TXT -> HTML -> CSV) to find specific game
                // Checking if game was won and marking accordingly 
                if (FindGameInLogFileLines.IsDateTimeFound(allTxtFileLines, selectedDateTime))
                {
                    // ******************************************************************************************
                    // ************************************* KARTOJASI ******************************************
                    // ******************************************************************************************
                    // Extracting specific game DateTime lines from allTxtFileLines
                    List<string> gameLines = new List<string>();
                    foreach (string line in allTxtFileLines)
                    {
                        if (line.Contains(selectedDateTime))
                            gameLines.Add(line);
                    }

                    // FOR goes backwards from last line up and looks for last placement of every disk
                    var victoryValidator = new VictoryValidator();
                    for (int i = gameLines.Count() - 1; i >= 0; i--)
                    {
                        if (victoryValidator.IsAllDisksLastMovesFoundInTxtLog(gameLines[i]))
                        {
                            if (victoryValidator.IsGameWon())
                            {
                                gameStatisticList.AllGamesStatistics[gameIndex].VictoryStatus = true;
                                gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = MovementCountFinder.FromTxtLine(gameLines[gameLines.Count() - 1]);
                                break;
                            }
                            gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = "N/B";
                            break;
                        }
                        // When not all four disks are found (e.g. Disk4 is never moved)
                        gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = "N/B";
                    }
                }
                else if (FindGameInLogFileLines.IsDateTimeFound(allHtmlFileLines, selectedDateTime))
                {
                    // ******************************************************************************************
                    // ************************************* KARTOJASI ******************************************
                    // ******************************************************************************************
                    // Finds last line of specific selectedDateTime from allHtmlFileLines by going from last line to the top
                    List<string> gameLines = new List<string>();                    
                    for (int i = allHtmlFileLines.Count() - 1; i >= 0; i--)
                    {
                        if (allHtmlFileLines[i].Contains(selectedDateTime))
                        {
                            // When it's found another FOR goes and takes JUST 5 lines with all the data from that last record
                            for (int j = i; j <= i + 5; j++)
                            {
                                gameLines.Add(allHtmlFileLines[j]);
                            }
                            break;
                        }
                    }

                    var victoryValidator = new VictoryValidator();
                    if (gameLines != null && victoryValidator.IsAllDisksLastMovesFoundInHtmlLog(gameLines))
                    {
                        if (victoryValidator.IsGameWon())
                        {
                            gameStatisticList.AllGamesStatistics[gameIndex].VictoryStatus = true;
                            gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = victoryValidator.MovesUntilVictory;
                        }
                        else
                            gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = "N/B";
                    }
                }
                else //if (allCsvFileLines.Contains(gameDateTime))
                {
                    // ******************************************************************************************
                    // ************************************* KARTOJASI ******************************************
                    // ******************************************************************************************
                    // Extracting only selectedDateTime lines from allCsvFileLines
                    List<string> gameLines = new List<string>();
                    foreach (string line in allCsvFileLines)
                    {
                        if (line.Contains(selectedDateTime))
                            gameLines.Add(line);
                    }

                    // Checks if last disk position of Csv log file is victory position 
                    var victoryValidator = new VictoryValidator();
                    if (gameLines != null && victoryValidator.IsAllDisksLastMovesFoundInCsvLog(gameLines[gameLines.Count - 1]))
                    {
                        if (victoryValidator.IsGameWon())
                        {
                            gameStatisticList.AllGamesStatistics[gameIndex].VictoryStatus = true;
                            gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = victoryValidator.MovesUntilVictory;
                        }
                        else
                            gameStatisticList.AllGamesStatistics[gameIndex].MovesUntilVictory = "N/B";
                    }
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