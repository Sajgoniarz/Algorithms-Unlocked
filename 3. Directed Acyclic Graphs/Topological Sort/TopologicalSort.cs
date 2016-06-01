using System;
using System.Collections.Generic;
using System.Linq;

namespace Topological_Sort
{
    static class TopologicalSort
    {
        public static List<int> Sort(Graph G)
        {
            List<int> order = new List<int>(); 
            int[] inDegree = new int[G.g.Length];
            List<int> next = new List<int>();

            for (int i = 0; i < inDegree.Length; i++)
                inDegree[i] = 0;

            for (int u = 0; u < G.g.Length; u++)
                for (int v = 0; v < G.g[u].Count; v++)
                    inDegree[G.g[u][v]]++;

            for (int i = 0; i < inDegree.Length; i++)
                if (inDegree[i] == 0)
                    next.Add(i);

            while (next.Count != 0)
            {
                int u = next.Last();
                next.RemoveAt(next.Count - 1);
                order.Add(u);

                for (int v = 0; v < G.g[u].Count; v++)
                {
                    int currV = G.g[u][v];
                    inDegree[currV]--;

                    if (inDegree[currV] == 0)
                        next.Add(currV);
                }
            }

            return order;
        }
    }
}
