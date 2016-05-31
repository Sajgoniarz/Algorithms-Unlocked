using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    static class QuickSort
    {
        public static int[] Sort(int[] a, int p, int r)
        {
            if (p >= r) return a;

            int q = Partition(a, p, r);
            Sort(a, p, q - 1);
            Sort(a, q + 1, r);
            return a;
        }

        private static int Partition(int[] a, int p, int r)
        {
            int q = p;
            int temp;

            for (int u = p; u < r; u++)
            {
                if(a[u] <= a[r])
                {
                    temp = a[q];
                    a[q] = a[u];
                    a[u] = temp;
                    q++;
                }
            }

            temp = a[q];
            a[q] = a[r];
            a[r] = temp;

            return q;
        }
    }
}
