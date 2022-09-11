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
    }
}
