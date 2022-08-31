using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L045_Generics.Models
{
    // Kad nurodyti jog klase yra generic sintakse musu praso nurodyti <T> prierasa
    // <T> siuo atveju gali buti betkoks duomenu tipas (string, DateTime, int, decimal etc)
    public class NodeList<T>
    {
        public NodeList()
        {
            _nodes = new List<T>();
        }

        // Nurodome, jog musu List bus sudarytas is T duomenu tipo reiksmiu
        private List<T> _nodes;

        public void Add(T node)
        {
            _nodes.Add(node);
        }

        public void DeleteNode(T nodeToRemove)
        {
            _nodes.Remove(nodeToRemove);
        }




        public void ProcessAllNodes()
        {
            foreach (var node in _nodes)
            {
                Console.WriteLine(node);
            }
        }
    }
}
