using L056_Db_Dapper_Tasks.Models;

namespace L056_Db_Dapper_Tasks.Database
{
    public interface INotebookRepository
    {
        public void Create(Notebook notebook);

        public IEnumerable<Notebook> Get();

        public Notebook Get(int notebookId);

        public int Delete(string notebookTitle);

        public void Update(Notebook notebook);
    }
}