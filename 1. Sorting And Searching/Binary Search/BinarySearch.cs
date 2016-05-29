using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class BinarySearch
    {
        public static int Search(int[] a, int x)
        {
            int p = 0;
            int r = a.Length - 1;
            int m = 0;
            int i = 0;
            while (p <= r)
            {
                i++;

                m = p + ((r - p) / 2);

                if (a[m] > x)
                    r = m - 1;
                else if (a[m] < x)
                    p = m + 1;
                else
                    return m;
            }

            return -1;
        }
    }
}
