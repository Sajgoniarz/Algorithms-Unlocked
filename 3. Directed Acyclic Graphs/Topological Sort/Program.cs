using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topological_Sort
{
    class Program
    {
        static Graph PrepareGraph()
        {
            Graph g = new Graph(14);

            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 3);
            g.AddEdge(2, 4);
            g.AddEdge(3, 5);
            g.AddEdge(4, 5);
            g.AddEdge(5, 6);
            g.AddEdge(5, 10);
            g.AddEdge(6, 7);
            g.AddEdge(7, 12);
            g.AddEdge(8, 9);
            g.AddEdge(9, 10);
            g.AddEdge(10, 11);
            g.AddEdge(11, 12);
            g.AddEdge(12, 13);

            return g;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Topological Sort\nEdges of G:");
            Graph G = PrepareGraph();
            
            List <int> order = TopologicalSort.Sort(G);

            Console.WriteLine("\nTopological Order for graph G:");
            for (int i = 0; i < order.Count; i++)
                Console.Write("{0},", order[i]);
            Console.WriteLine();
        }
    }
}
