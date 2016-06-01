using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    static class CountingSort
    {
        public static int[] Sort(int[]a, int n, int m)
        {
            int[] equal = CountEqual(a, n, m);
            int[] less = CountLess(equal, m);
            return Rearrange(a, less, n, m);
        }

        private static int[] CountEqual(int[] a, int n, int m)
        {
            int[] equal = new int[m];
            int i;

            for (i = 0; i < m; i++)
                equal[i] = 0;

            for (i = 0; i < n; i++)
                equal[a[i]]++;

            return equal;
        }

        private static int[] CountLess(int[] a, int m)
        {
            int[] temp = new int[m];
            temp[0] = 0;

            for (int i = 1; i < m; i++)
                temp[i] = temp[i - 1] + a[i - 1];

            return temp;
        }

        private static int[] Rearrange(int[] a, int[] less, int n, int m)
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
