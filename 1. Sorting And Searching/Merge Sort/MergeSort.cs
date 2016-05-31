using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    static class MergeSort
    {
        private static int[] Merge(int[] a, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] b = new int[n1];
            int[] c = new int[n2];

            Array.Copy(a, p, b, 0, n1);
            Array.Copy(a, q+1, c, 0, n2);

            int i = 0;
            int j = 0;
            for (int k = p; k <= r; k++)
            {
                if(i == b.Length)
                {
                    a[k] = c[j];
                    j++;
                }
                else if (j == c.Length)
                {
                    a[k] = b[i];
                    i++;
                } else if (b[i] <= c[j])
                {
                    a[k] = b[i];
                    i++;
                } else
                {
                    a[k] = c[j];
                    j++;
                }
            }
            return a;
        }

        public static int[] Sort(int[] a, int p, int r)
        {
            if (p >= r) return a;

            int q = (p + r) / 2;
            Sort(a, p, q);
            Sort(a, q + 1, r);
            return Merge(a, p, q, r);
        }
    }
}
