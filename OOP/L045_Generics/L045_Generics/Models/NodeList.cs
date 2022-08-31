using L045_Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L045_Generics.Models
{
    // Kad nurodyti jog klase yra generic sintakse musu praso nurodyti <T> prierasa
    // <T> siuo atveju gali buti betkoks duomenu tipas (string, DateTime, int, decimal etc)

    public class NodeList<T> : ICustomList<T>
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

    public class NodeListFilterStruct<T> where T : struct
    {
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

    public class NodeListFilterClass<T> where T : class
    {
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

    public class NodeListFilterClassNew<T> where T : class, new()
    {
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

    public class NodeListFilterSpecifiedClass<T> where T : Tool
    {
        private List<T> _nodes;

        public void Add(T node)
        {
            node.Id = 3000;
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

    public class NodeListFilterSpecifiedInterface<T> where T : ITool
    {
        private List<T> _nodes;

        public void Add(T node)
        {
            node.Id = 3000;
            node.Name = "DefaultName";
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
