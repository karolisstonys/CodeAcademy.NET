using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L056_Db_Dapper_Tasks.Models
{
    public class Notebook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
    }
}
