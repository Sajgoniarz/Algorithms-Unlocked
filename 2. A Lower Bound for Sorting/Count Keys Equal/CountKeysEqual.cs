using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Keys_Equal
{
    static class CountKeysEqual
    {
        public static int[] Count(int[] a, int n, int m) {
            int[] equal = new int[m];
            int i;

            for (i = 0; i < m; i++)
                equal[i] = 0;

            for (i = 0; i < n; i++)
                equal[a[i]]++;

            return equal; 
        }
    }
}
