using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Helpers
{
    public static class FileReader
    {
        // Move to other class maybe? Helpers\FileValidator.cs ?
        public static bool CheckIfFileIsEmpty(string fileName)
        {
            string path = GetFilePath(fileName);
            string allText = File.ReadAllText(path);
            return allText.Length == 0;
        }

        public static string GetFilePath(string fileName)
        {
            return new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.FullName + "\\TowerOfHanoi.Domain\\Logs\\" + fileName;
        }

        public static string[] GetAllCsvFileLines()
        {
            var path = FileReader.GetFilePath("TowerOfHanoiLogs.csv");
            string[] allCsvFileLines = File.ReadAllLines(path);
            return allCsvFileLines;
        }
        public static List<string> GetAllHtmlFileLines()
        {
            var path = FileReader.GetFilePath("TowerOfHanoiLogs.html");
            List<string> allHtmlFileLines = File.ReadAllLines(path).ToList();
            return allHtmlFileLines;
        }
        public static string[] GetAllTxtFileLines()
        {
            var path = FileReader.GetFilePath("TowerOfHanoiLogs.txt");
            string[] allTxtFileLines = File.ReadAllLines(path);
            return allTxtFileLines;
        }

    }
}
