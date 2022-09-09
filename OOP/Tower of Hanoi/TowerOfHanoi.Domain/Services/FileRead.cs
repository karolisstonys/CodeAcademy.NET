using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Services
{
    public class FileRead : IFileRead
    {
        public bool CheckIfFileIsEmpty(string fileAddress)
        {
            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Logs\\" + fileAddress;
            string allText = File.ReadAllText(path);
            return allText.Length == 0;
        }
    }
}
