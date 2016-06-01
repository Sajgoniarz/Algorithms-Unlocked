using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange
{
    static class Rearrange
    {
        public static int[] Sort(int[] a, int[] less, int n, int m)
        {
            int[] b = new int[n];
            int[] next = new int[m];

            for (int i = 0; i < m; i++)
                next[i] = less[i];

            for (int i = 0; i < n; i++)
            {
                int key = a[i];
                int index = next[key];

                b[index] = a[i];
                next[key]++;
            }

            return b;
        }
    }
}
