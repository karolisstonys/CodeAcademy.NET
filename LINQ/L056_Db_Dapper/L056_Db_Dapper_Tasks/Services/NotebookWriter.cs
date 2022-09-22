using L056_Db_Dapper_Tasks.Database;
using L056_Db_Dapper_Tasks.Database.Dapper;
using L056_Db_Dapper_Tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper_Tasks.Services
{
    public class NotebookWriter : INotebookWriter
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly NotebookRepository _notebookRepository;

        public NotebookWriter()
        {
            _databaseConfig = new DatabaseConfig();
            _notebookRepository = new NotebookRepository(_databaseConfig);
        }


        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add note");
                Console.WriteLine("2. List all notes");
                Console.WriteLine("3. Remove note by title");
                Console.WriteLine("4. Update note by Id");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddNotebook();
                        break;
                    case '2':
                        DisplayNotebooks();
                        break;
                    case '3':
                        RemoveNotebook();
                        break;
                    case '4':
                        UpdateNotebook();
                        break;
                    case 'q' or 'Q':
                        return;
                    default:
                        break;
                }
                PauseScreen();
            }
        }

        private void UpdateNotebook()
        {
            Console.WriteLine("\n\nPlease enter id of the notebook you want to update:");
            DisplayNotebooks();

            int updateNotebookId = Convert.ToInt32(Console.ReadLine());
            Notebook notebook = _notebookRepository.Get(updateNotebookId);

            if (notebook == null)
            {
                Console.WriteLine($"No notebook found with ID - {updateNotebookId}");
                return;
            }


            Console.WriteLine("\n\nPlease enter NEW title of the notebook:");
            notebook.Title = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter NEW description of the notebook:");
            notebook.Description = Console.ReadLine();

            _notebookRepository.Update(notebook);

            Console.WriteLine($"\n{notebook.Title} - {notebook.Description} updated\n");


        }

        public void DisplayNotebooks()
        {
            var notebooks = _notebookRepository.Get();

            Console.WriteLine();

            foreach (var notebook in notebooks)
            {
                Console.WriteLine($"{notebook.Id}. {notebook.Title} ({notebook.CreationDateTime}) - {notebook.Description}");
            }
        }


        public void AddNotebook()
        {
            var newNotebook = new Notebook();
            Console.WriteLine("\n\nPlease enter title of the notebook:");
            newNotebook.Title = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter description of the notebook:");
            newNotebook.Description = Console.ReadLine();
            Console.WriteLine("\n\nPlease enter priority of the notebook:");
            newNotebook.Priority = Console.ReadLine();

            _notebookRepository.Create(newNotebook);

            Console.WriteLine($"\n{newNotebook.Title} - {newNotebook.Description} added to the database\n");
        }


        public void RemoveNotebook()
        {
            Console.WriteLine("\n\nPlease enter name of the notebook that should be deleted:");
            string notebookNameToDelete = Console.ReadLine();

            int notebookDeletedCount = _notebookRepository.Delete(notebookNameToDelete);

            Console.WriteLine($"\n{notebookDeletedCount} called {notebookNameToDelete} were removed.\n");
        }


        private void PauseScreen()
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }

    }
}
