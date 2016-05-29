using System;

namespace Recursive_Binary_Search
{
    static class RecursiveBinarySearch
    {
        public static int Search(int[] a, int p, int r, int x)
        {
            if (p > r)
                return -1;

            int m = p + ((r - p) / 2);

            if (a[m] > x)
                return Search(a, p, m - 1, x);
            else if (a[m] < x)
                return Search(a, m + 1, r, x);
            else
                return m;
        }

        public static int Search(int[] a, int x)
        {
            return Search(a, 0, a.Length - 1, x);
        }

    }
}
