using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Keys_Less
{
    class CountKeysLess
    {
        public static int[] Count(int[] a, int m)
        {
            int[] temp = new int[m];
            temp[0] = 0;

            for (int i = 1; i < m; i++)
                temp[i] = temp[i - 1] + a[i - 1];

            return temp;
        }
    }
}
