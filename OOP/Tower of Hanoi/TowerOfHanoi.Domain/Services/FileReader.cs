using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Services
{
    public class FileReader
    {
        public bool CheckIfFileIsEmpty(string fileName)
        {
            string path = GetFilePath(fileName);
            string allText = File.ReadAllText(path);
            return allText.Length == 0;
        }

        public string GetFilePath(string fileName)
        {
            return new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.FullName + "\\TowerOfHanoi.Domain\\Logs\\" + fileName;
        }
    }
}
