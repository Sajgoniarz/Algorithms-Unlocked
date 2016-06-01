using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topological_Sort
{
    class Graph
    {
        public List<int>[] g;

        public Graph(int size)
        {
            g = new List<int>[size];

            for(int i = 0; i < g.Length; i++)
            {
                g[i] = new List<int>();
            }
        }

        public void AddEdge(int u, int v)
        {
            g[u].Add(v);
            Console.WriteLine("{0} - {1}", u, v);
        }
    }
}
