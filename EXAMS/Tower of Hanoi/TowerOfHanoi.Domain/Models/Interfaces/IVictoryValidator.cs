namespace TowerOfHanoi.Domain.Models.Interfaces
{
    public interface IVictoryValidator
    {
        public bool IsAllDisksLastMovesFoundInTxtLog(string line);

        public bool IsAllDisksLastMovesFoundInHtmlLog(List<string> lines);

        public bool IsAllDisksLastMovesFoundInCsvLog(string line);

        public bool IsAllDisksFound();

        public bool IsGameWon();
    }
}