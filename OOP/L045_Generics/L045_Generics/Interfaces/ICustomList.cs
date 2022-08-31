using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L045_Generics.Interfaces
{
    public interface ICustomList<T>
    {
        public void Add(T item);
        public void DeleteNode(T item);
        public void ProcessAllNodes();
    }
}
